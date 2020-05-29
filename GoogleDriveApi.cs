using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StickyNote
{
    public partial class GoogleDriveApi : Form
    {
        public GoogleDriveApi()
        {
            InitializeComponent();
        }

        private void GoogleDriveApi_Load(object sender, EventArgs e)
        {
            txtClientId.Text = Properties.Settings.Default.clientId;
            txtSecretId.Text = Properties.Settings.Default.clientSecret;
            txtParentFolder.Text = Properties.Settings.Default.parent_folder;
        }

        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            Helper.driveService = Helper.Authorize(txtClientId.Text.Trim(),txtSecretId.Text.Trim());
            if (Helper.driveService != null)
            {
                MessageBox.Show("You are already given us the rights to upload the file.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.clientSecret = txtSecretId.Text;
            Properties.Settings.Default.clientId = txtClientId.Text;
            Properties.Settings.Default.parent_folder = txtParentFolder.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Credentials Saved!");

        }
    }
}
