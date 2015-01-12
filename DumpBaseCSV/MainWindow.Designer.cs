namespace DumpBaseCSV
{
    partial class MainWindow
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
            this.LblTableName = new System.Windows.Forms.Label();
            this.LblCSVFileName = new System.Windows.Forms.Label();
            this.LblCSVFolderName = new System.Windows.Forms.Label();
            this.TxtTableName = new System.Windows.Forms.TextBox();
            this.TxtCSVFileName = new System.Windows.Forms.TextBox();
            this.TxtCSVFolderName = new System.Windows.Forms.TextBox();
            this.BtnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTableName
            // 
            this.LblTableName.AutoSize = true;
            this.LblTableName.Location = new System.Drawing.Point(38, 24);
            this.LblTableName.Name = "LblTableName";
            this.LblTableName.Size = new System.Drawing.Size(187, 13);
            this.LblTableName.TabIndex = 0;
            this.LblTableName.Text = "Table from where data will be fetched:";
            // 
            // LblCSVFileName
            // 
            this.LblCSVFileName.AutoSize = true;
            this.LblCSVFileName.Location = new System.Drawing.Point(38, 74);
            this.LblCSVFileName.Name = "LblCSVFileName";
            this.LblCSVFileName.Size = new System.Drawing.Size(224, 13);
            this.LblCSVFileName.TabIndex = 1;
            this.LblCSVFileName.Text = "CSV File Name to be saved as on web server:";
            // 
            // LblCSVFolderName
            // 
            this.LblCSVFolderName.AutoSize = true;
            this.LblCSVFolderName.Location = new System.Drawing.Point(38, 124);
            this.LblCSVFolderName.Name = "LblCSVFolderName";
            this.LblCSVFolderName.Size = new System.Drawing.Size(186, 13);
            this.LblCSVFolderName.TabIndex = 2;
            this.LblCSVFolderName.Text = "Save CSV file to folder on web server:";
            // 
            // TxtTableName
            // 
            this.TxtTableName.Location = new System.Drawing.Point(41, 40);
            this.TxtTableName.Name = "TxtTableName";
            this.TxtTableName.Size = new System.Drawing.Size(221, 20);
            this.TxtTableName.TabIndex = 3;
            // 
            // TxtCSVFileName
            // 
            this.TxtCSVFileName.Location = new System.Drawing.Point(41, 90);
            this.TxtCSVFileName.Name = "TxtCSVFileName";
            this.TxtCSVFileName.Size = new System.Drawing.Size(221, 20);
            this.TxtCSVFileName.TabIndex = 4;
            // 
            // TxtCSVFolderName
            // 
            this.TxtCSVFolderName.Location = new System.Drawing.Point(41, 140);
            this.TxtCSVFolderName.Name = "TxtCSVFolderName";
            this.TxtCSVFolderName.Size = new System.Drawing.Size(221, 20);
            this.TxtCSVFolderName.TabIndex = 5;
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(187, 183);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(75, 23);
            this.BtnExport.TabIndex = 6;
            this.BtnExport.Text = "&Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 225);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.TxtCSVFolderName);
            this.Controls.Add(this.TxtCSVFileName);
            this.Controls.Add(this.TxtTableName);
            this.Controls.Add(this.LblCSVFolderName);
            this.Controls.Add(this.LblCSVFileName);
            this.Controls.Add(this.LblTableName);
            this.Name = "Form1";
            this.Text = "ToCSV Database Dumper ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTableName;
        private System.Windows.Forms.Label LblCSVFileName;
        private System.Windows.Forms.Label LblCSVFolderName;
        private System.Windows.Forms.TextBox TxtTableName;
        private System.Windows.Forms.TextBox TxtCSVFileName;
        private System.Windows.Forms.TextBox TxtCSVFolderName;
        private System.Windows.Forms.Button BtnExport;
    }
}

