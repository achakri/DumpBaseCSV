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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            this.tabExport = new System.Windows.Forms.TabPage();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.chkDatabaseName = new System.Windows.Forms.Label();
            this.chkProfils = new System.Windows.Forms.CheckBox();
            this.chkNatures = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtTargetFolder = new System.Windows.Forms.TextBox();
            this.lblTargetFolder = new System.Windows.Forms.Label();
            this.lblExportedTables = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.tabExport.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 352);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(391, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(31, 17);
            this.statusLabel.Text = "Prêt.";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabConnection);
            this.tabControl.Controls.Add(this.tabExport);
            this.tabControl.Location = new System.Drawing.Point(12, 44);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(367, 291);
            this.tabControl.TabIndex = 10;
            this.tabControl.TabStop = false;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.btnConnect);
            this.tabConnection.Controls.Add(this.txtPassword);
            this.tabConnection.Controls.Add(this.txtUserName);
            this.tabConnection.Controls.Add(this.txtServerName);
            this.tabConnection.Controls.Add(this.lblPassword);
            this.tabConnection.Controls.Add(this.lblUserName);
            this.tabConnection.Controls.Add(this.lblServerName);
            this.tabConnection.Location = new System.Drawing.Point(4, 22);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnection.Size = new System.Drawing.Size(359, 265);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Connexion";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(216, 196);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "&Connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(70, 157);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(221, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "PASSWORD";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(70, 109);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(221, 20);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.Text = "USERNAME";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(70, 61);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(221, 20);
            this.txtServerName.TabIndex = 3;
            this.txtServerName.Text = "localhost";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(67, 141);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mot de passe:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(67, 93);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(98, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Nom de l\'utilisateur:";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(67, 45);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(85, 13);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Nom du serveur:";
            // 
            // tabExport
            // 
            this.tabExport.Controls.Add(this.txtDatabaseName);
            this.tabExport.Controls.Add(this.chkDatabaseName);
            this.tabExport.Controls.Add(this.chkProfils);
            this.tabExport.Controls.Add(this.chkNatures);
            this.tabExport.Controls.Add(this.btnExport);
            this.tabExport.Controls.Add(this.txtTargetFolder);
            this.tabExport.Controls.Add(this.lblTargetFolder);
            this.tabExport.Controls.Add(this.lblExportedTables);
            this.tabExport.Location = new System.Drawing.Point(4, 22);
            this.tabExport.Name = "tabExport";
            this.tabExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabExport.Size = new System.Drawing.Size(359, 265);
            this.tabExport.TabIndex = 1;
            this.tabExport.Text = "Export";
            this.tabExport.UseVisualStyleBackColor = true;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(70, 115);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(221, 20);
            this.txtDatabaseName.TabIndex = 18;
            this.txtDatabaseName.Text = "DATABASE";
            // 
            // chkDatabaseName
            // 
            this.chkDatabaseName.AutoSize = true;
            this.chkDatabaseName.Location = new System.Drawing.Point(70, 99);
            this.chkDatabaseName.Name = "chkDatabaseName";
            this.chkDatabaseName.Size = new System.Drawing.Size(143, 13);
            this.chkDatabaseName.TabIndex = 17;
            this.chkDatabaseName.Text = "Nom de la base de données:";
            // 
            // chkProfils
            // 
            this.chkProfils.AutoSize = true;
            this.chkProfils.Location = new System.Drawing.Point(70, 61);
            this.chkProfils.Name = "chkProfils";
            this.chkProfils.Size = new System.Drawing.Size(54, 17);
            this.chkProfils.TabIndex = 16;
            this.chkProfils.Text = "Profils";
            this.chkProfils.UseVisualStyleBackColor = true;
            // 
            // chkNatures
            // 
            this.chkNatures.AutoSize = true;
            this.chkNatures.Location = new System.Drawing.Point(228, 61);
            this.chkNatures.Name = "chkNatures";
            this.chkNatures.Size = new System.Drawing.Size(63, 17);
            this.chkNatures.TabIndex = 15;
            this.chkNatures.Text = "Natures";
            this.chkNatures.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(216, 196);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "&Exporter";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // txtTargetFolder
            // 
            this.txtTargetFolder.Location = new System.Drawing.Point(70, 160);
            this.txtTargetFolder.Name = "txtTargetFolder";
            this.txtTargetFolder.Size = new System.Drawing.Size(221, 20);
            this.txtTargetFolder.TabIndex = 13;
            // 
            // lblTargetFolder
            // 
            this.lblTargetFolder.AutoSize = true;
            this.lblTargetFolder.Location = new System.Drawing.Point(67, 144);
            this.lblTargetFolder.Name = "lblTargetFolder";
            this.lblTargetFolder.Size = new System.Drawing.Size(88, 13);
            this.lblTargetFolder.TabIndex = 11;
            this.lblTargetFolder.Text = "Dossier de sortie:";
            // 
            // lblExportedTables
            // 
            this.lblExportedTables.AutoSize = true;
            this.lblExportedTables.Location = new System.Drawing.Point(67, 45);
            this.lblExportedTables.Name = "lblExportedTables";
            this.lblExportedTables.Size = new System.Drawing.Size(103, 13);
            this.lblExportedTables.TabIndex = 9;
            this.lblExportedTables.Text = "Données à exporter:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(391, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.aideToolStripMenuItem.Text = "?";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 374);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "DumpBase: MS SQL To CSV";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.tabConnection.PerformLayout();
            this.tabExport.ResumeLayout(false);
            this.tabExport.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.TabPage tabExport;
        private System.Windows.Forms.CheckBox chkProfils;
        private System.Windows.Forms.CheckBox chkNatures;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtTargetFolder;
        private System.Windows.Forms.Label lblTargetFolder;
        private System.Windows.Forms.Label lblExportedTables;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label chkDatabaseName;
    }
}

