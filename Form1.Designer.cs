namespace SayariDemonstration
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_fileCountofRecords = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_GetFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isAuthenticated_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_authenticate = new System.Windows.Forms.Button();
            this.btn_exeAPI = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_closestToSayariHQ = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_chatGPToutput = new System.Windows.Forms.RichTextBox();
            this.btn_ChatGPT_actionplan = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(18, 44);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1217, 871);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_fileCountofRecords);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.btn_GetFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1209, 838);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "\"Extract\" Load";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_fileCountofRecords
            // 
            this.lbl_fileCountofRecords.AutoSize = true;
            this.lbl_fileCountofRecords.Location = new System.Drawing.Point(187, 58);
            this.lbl_fileCountofRecords.Name = "lbl_fileCountofRecords";
            this.lbl_fileCountofRecords.Size = new System.Drawing.Size(127, 20);
            this.lbl_fileCountofRecords.TabIndex = 8;
            this.lbl_fileCountofRecords.Text = "Please load data";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(30, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1089, 644);
            this.listBox1.TabIndex = 7;
            // 
            // btn_GetFile
            // 
            this.btn_GetFile.BackColor = System.Drawing.Color.LightGray;
            this.btn_GetFile.Location = new System.Drawing.Point(30, 43);
            this.btn_GetFile.Name = "btn_GetFile";
            this.btn_GetFile.Size = new System.Drawing.Size(120, 49);
            this.btn_GetFile.TabIndex = 0;
            this.btn_GetFile.Text = "Load Data";
            this.btn_GetFile.UseVisualStyleBackColor = false;
            this.btn_GetFile.Click += new System.EventHandler(this.btn_GetFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.isAuthenticated_lbl);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_authenticate);
            this.tabPage2.Controls.Add(this.btn_exeAPI);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1209, 838);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "\"Transform\" Enrich";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(45, 156);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1123, 664);
            this.listBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Will display count of matched records";
            // 
            // isAuthenticated_lbl
            // 
            this.isAuthenticated_lbl.AutoSize = true;
            this.isAuthenticated_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.isAuthenticated_lbl.Location = new System.Drawing.Point(171, 38);
            this.isAuthenticated_lbl.Name = "isAuthenticated_lbl";
            this.isAuthenticated_lbl.Size = new System.Drawing.Size(61, 20);
            this.isAuthenticated_lbl.TabIndex = 4;
            this.isAuthenticated_lbl.Text = "FALSE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "isAuthenticated:";
            // 
            // btn_authenticate
            // 
            this.btn_authenticate.BackColor = System.Drawing.Color.LightGray;
            this.btn_authenticate.Location = new System.Drawing.Point(64, 81);
            this.btn_authenticate.Name = "btn_authenticate";
            this.btn_authenticate.Size = new System.Drawing.Size(169, 48);
            this.btn_authenticate.TabIndex = 2;
            this.btn_authenticate.Text = "Authenticate";
            this.btn_authenticate.UseVisualStyleBackColor = false;
            this.btn_authenticate.Click += new System.EventHandler(this.btn_authenticate_Click);
            // 
            // btn_exeAPI
            // 
            this.btn_exeAPI.BackColor = System.Drawing.Color.LightGray;
            this.btn_exeAPI.Location = new System.Drawing.Point(323, 80);
            this.btn_exeAPI.Name = "btn_exeAPI";
            this.btn_exeAPI.Size = new System.Drawing.Size(120, 49);
            this.btn_exeAPI.TabIndex = 1;
            this.btn_exeAPI.Text = "Execute API";
            this.btn_exeAPI.UseVisualStyleBackColor = false;
            this.btn_exeAPI.Click += new System.EventHandler(this.btn_exeAPI_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_closestToSayariHQ);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.tb_chatGPToutput);
            this.tabPage3.Controls.Add(this.btn_ChatGPT_actionplan);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1209, 838);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Do Something Awesome";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_closestToSayariHQ
            // 
            this.btn_closestToSayariHQ.Location = new System.Drawing.Point(28, 16);
            this.btn_closestToSayariHQ.Name = "btn_closestToSayariHQ";
            this.btn_closestToSayariHQ.Size = new System.Drawing.Size(136, 55);
            this.btn_closestToSayariHQ.TabIndex = 5;
            this.btn_closestToSayariHQ.Text = "Closest to Sayari HQ";
            this.btn_closestToSayariHQ.UseVisualStyleBackColor = true;
            this.btn_closestToSayariHQ.Click += new System.EventHandler(this.btn_closestToSayariHQ_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(936, 117);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // tb_chatGPToutput
            // 
            this.tb_chatGPToutput.Location = new System.Drawing.Point(28, 157);
            this.tb_chatGPToutput.Name = "tb_chatGPToutput";
            this.tb_chatGPToutput.Size = new System.Drawing.Size(1148, 638);
            this.tb_chatGPToutput.TabIndex = 1;
            this.tb_chatGPToutput.Text = "";
            // 
            // btn_ChatGPT_actionplan
            // 
            this.btn_ChatGPT_actionplan.Location = new System.Drawing.Point(28, 78);
            this.btn_ChatGPT_actionplan.Name = "btn_ChatGPT_actionplan";
            this.btn_ChatGPT_actionplan.Size = new System.Drawing.Size(179, 65);
            this.btn_ChatGPT_actionplan.TabIndex = 0;
            this.btn_ChatGPT_actionplan.Text = "Create Mitigation Plan";
            this.btn_ChatGPT_actionplan.UseVisualStyleBackColor = true;
            this.btn_ChatGPT_actionplan.Click += new System.EventHandler(this.btn_ChatGPT_actionplan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 954);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Sayari Technical Demonstration";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_GetFile;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_exeAPI;
        private System.Windows.Forms.Button btn_authenticate;
        private System.Windows.Forms.Label isAuthenticated_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_fileCountofRecords;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_ChatGPT_actionplan;
        private System.Windows.Forms.RichTextBox tb_chatGPToutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_closestToSayariHQ;
    }
}

