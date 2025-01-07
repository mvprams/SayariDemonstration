using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace SayariDemonstration
{
    public partial class Form1 : Form
    {
        #region variables
        private static readonly string baseUrl = "https://api.sayari.com"; // Sayari's API base URL
        private static readonly string authEndpoint = "/oauth/token"; // actual authentication endpoint
        private static readonly string clientId = "f87uCTW8o2sGdFwJElI4KC14XGD5OmNG";
        private static readonly string clientSecret = "";
        public List<CsvRow> fileData = new List<CsvRow>();

        public class AuthResponse
        {
            [JsonPropertyName("access_token")]
            public string AccessToken { get; set; }

            [JsonPropertyName("token_type")]
            public string TokenType { get; set; }

            [JsonPropertyName("expires_in")]
            public int ExpiresIn { get; set; }

            [JsonPropertyName("scope")]
            public string Scope { get; set; }
        }


        public class CsvRow
        {
            public string Name { get; set; }
            public string Address { get; set; } 
            public string Country { get; set; }
        }

        
        #endregion

        

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_GetFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Data Files | *.csv"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                {

                    string line;
                    int rowNumber = 0;

                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into columns
                        var columns = line.Split(',');

                        if (rowNumber == 0)
                        {
                            // Assume the first row contains headers
                            Console.WriteLine($"Headers: {string.Join(", ", columns)}");
                        }
                        else
                        {
                            // Create a new CsvRow object and populate its properties
                            var row = new CsvRow
                            {
                                Name = columns.Length > 0 ? columns[0] : "",
                                Address = columns.Length > 1 ? columns[1] : "",
                                Country = columns.Length > 2 ? columns[2] : ""
                            };

                            fileData.Add(row); // Add the row object to the list
                        }

                        rowNumber++;
                    }
                }

                // Output the parsed rows to the Console.Writeline LOG - Working proof
                foreach (var row in fileData)
                {
                    Console.WriteLine($"Name: {row.Name}, Address: {row.Address}, Country: {row.Country}");
                }
            }
        }

        private void btn_exeAPI_Click(object sender, EventArgs e)
        {
            //WebUtility.UrlEncode(originalString)
        }

        private void btn_authenticate_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                // Prepare the request
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, authEndpoint);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Add client credentials to the body
                var credentials = new
                {
                    client_id = clientId,
                    client_secret = clientSecret,
                    audience = "sayari.com",
                    grant_type = "client_credentials"
                };

                string jsonBody = JsonSerializer.Serialize(credentials);
                request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                // Send the request synchronously
                HttpResponseMessage response = client.PostAsync(authEndpoint, request.Content).Result;

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = response.Content.ReadAsStringAsync().Result;

                    // Deserialize the JSON response to extract access_token
                    AuthResponse jsonResponse = JsonSerializer.Deserialize<AuthResponse>(responseBody);
                    if (jsonResponse != null && !string.IsNullOrEmpty(jsonResponse.AccessToken))
                    {
                        Console.WriteLine("Authentication successful.");
                        //return jsonResponse.AccessToken;
                        isAuthenticated_lbl.Text = "TRUE";
                        isAuthenticated_lbl.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        throw new Exception("Access token not found in the response.");
                    }
                }
                else
                {
                    Console.WriteLine($"Authentication failed: {response.StatusCode}");
                    string errorBody = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(errorBody);
                    throw new Exception("Failed to authenticate.");
                }
            }
        }
    }
}
