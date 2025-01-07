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

namespace SayariDemonstration
{
    public partial class Form1 : Form
    {
        #region variables
        private static string bearToken = string.Empty;
        private static readonly string baseUrl = "https://api.sayari.com"; // Replace with Sayari's API base URL
        private static readonly string authEndpoint = "/v1/auth/token"; // Replace with the actual authentication endpoint
        private static readonly string apiKey = "YOUR_API_KEY"; // Replace with your actual API key
        public List<CsvRow> fileData = new List<CsvRow>();


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

                // Add API key or other credentials
                var credentials = new
                {
                    apiKey = apiKey // Adjust based on Sayari's API requirements
                };

                string jsonBody = System.Text.Json.JsonSerializer.Serialize(credentials);
                request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                // Send the request
                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Authentication successful.");
                    return responseBody; // Typically includes the token
                }
                else
                {
                    Console.WriteLine($"Authentication failed: {response.StatusCode}");
                    string errorBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(errorBody);
                    throw new Exception("Failed to authenticate.");
                }
            }
        }
    }
}
