using DumpBaseCSV.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DumpBaseCSV
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            chkNatures.Checked = true;
            chkProfils.Checked = true;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            { 
                // Exportation des données selon les options choisies.
            }
            catch (Exception ex)
            {
                // En cas d'échec.
                MessageBox.Show(ex.Message.ToString(), "Erreur critique!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                statusLabel.Text = "Echoué!";
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
