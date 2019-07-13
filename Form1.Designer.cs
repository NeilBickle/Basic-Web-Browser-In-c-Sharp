namespace Web_Browser
{
    partial class WebBrowser
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
            this.WebBrwsrTest = new System.Windows.Forms.WebBrowser();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.Btnfrwd = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnRfh = new System.Windows.Forms.Button();
            this.BtnGo = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebBrwsrTest
            // 
            this.WebBrwsrTest.Location = new System.Drawing.Point(0, 95);
            this.WebBrwsrTest.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrwsrTest.Name = "WebBrwsrTest";
            this.WebBrwsrTest.Size = new System.Drawing.Size(1322, 812);
            this.WebBrwsrTest.TabIndex = 0;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(3, 3);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(1123, 31);
            this.TxtSearch.TabIndex = 0;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(3, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(125, 41);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Btnfrwd
            // 
            this.Btnfrwd.Location = new System.Drawing.Point(3, 50);
            this.Btnfrwd.Name = "Btnfrwd";
            this.Btnfrwd.Size = new System.Drawing.Size(125, 41);
            this.Btnfrwd.TabIndex = 2;
            this.Btnfrwd.Text = "Forward";
            this.Btnfrwd.UseVisualStyleBackColor = true;
            this.Btnfrwd.Click += new System.EventHandler(this.Btnfrwd_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(3, 144);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(125, 41);
            this.BtnHome.TabIndex = 3;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnRfh
            // 
            this.BtnRfh.Location = new System.Drawing.Point(3, 97);
            this.BtnRfh.Name = "BtnRfh";
            this.BtnRfh.Size = new System.Drawing.Size(125, 41);
            this.BtnRfh.TabIndex = 4;
            this.BtnRfh.Text = "Refresh";
            this.BtnRfh.UseVisualStyleBackColor = true;
            this.BtnRfh.Click += new System.EventHandler(this.BtnRfh_Click);
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(1132, 3);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(125, 41);
            this.BtnGo.TabIndex = 5;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(1263, 3);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(125, 41);
            this.BtnStop.TabIndex = 6;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TxtSearch);
            this.flowLayoutPanel1.Controls.Add(this.BtnGo);
            this.flowLayoutPanel1.Controls.Add(this.BtnStop);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1443, 87);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.BtnBack);
            this.flowLayoutPanel2.Controls.Add(this.Btnfrwd);
            this.flowLayoutPanel2.Controls.Add(this.BtnRfh);
            this.flowLayoutPanel2.Controls.Add(this.BtnHome);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1328, 100);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(224, 812);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // WebBrowser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1462, 911);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.WebBrwsrTest);
            this.Name = "WebBrowser";
            this.Text = "WebBrowser";
            this.Load += new System.EventHandler(this.WebBrowser_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebBrwsrTest;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.Button BtnRfh;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button Btnfrwd;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

