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
            this.btn_GetFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_authenticate = new System.Windows.Forms.Button();
            this.btn_exeAPI = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.isAuthenticated_lbl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(18, 98);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 575);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_GetFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1156, 542);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "\"Extract\" Load";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Controls.Add(this.isAuthenticated_lbl);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_authenticate);
            this.tabPage2.Controls.Add(this.btn_exeAPI);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1156, 542);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "\"Transform\" Enrich";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1156, 542);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Do Something Awesome";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "isAuthenticated:";
            // 
            // isAuthenticated_lbl
            // 
            this.isAuthenticated_lbl.AutoSize = true;
            this.isAuthenticated_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.isAuthenticated_lbl.Location = new System.Drawing.Point(185, 180);
            this.isAuthenticated_lbl.Name = "isAuthenticated_lbl";
            this.isAuthenticated_lbl.Size = new System.Drawing.Size(61, 20);
            this.isAuthenticated_lbl.TabIndex = 4;
            this.isAuthenticated_lbl.Text = "FALSE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Sayari Technical Demonstration";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}

