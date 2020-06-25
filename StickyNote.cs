using StickyNote.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace StickyNote
{
    public partial class frmStickyNote : Form
    {
        public ArrayList psHolder = new ArrayList();
        public static int cpostion = 0;
        public frmStickyNote()
        {
            InitializeComponent();
        }

        public void readAFileIntoTextBox(FileInfo myFile)
        {
            if (myFile == null)
            { // Getting into the default directory and reading the last created file

                myFile = Helper.getLastCreatedFile();

            }
            if (myFile != null && File.Exists(myFile.FullName))
            {
                txtMessage.Text = "";
                using (StreamReader sr = File.OpenText(myFile.FullName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        txtMessage.Text += s + Environment.NewLine;
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //if (Debugger.IsAttached)
                //Settings.Default.Reset();
            if (!String.IsNullOrEmpty(Properties.Settings.Default.clientId) &&
                !String.IsNullOrEmpty(Properties.Settings.Default.clientSecret))
            {
                Helper.driveService = Helper.Authorize(Properties.Settings.Default.clientId,
                    Properties.Settings.Default.clientSecret);
            }

            
            Helper.dirPath = Properties.Settings.Default.default_folder;
            Helper.parentFolder = Properties.Settings.Default.parent_folder;
            if (!String.IsNullOrEmpty(Helper.dirPath))
            {
                readAFileIntoTextBox(null);
            }

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            this.txtSearch.Text = "";
        }
        // Generate a random number between two numbers  
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void searchText()
        {
            psHolder.Clear();
            statusStrip.Text = "Searching ...";
            int position = 0;
            int cnt = 1;
            for (int i = 0; i < txtMessage.Lines.Length; i++)
            {
                position += txtMessage.Lines[i].Length;
                if (txtMessage.Lines[i].ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    toolStripStatusLabel.Text = "Found. " + cnt.ToString();
                    //break;
                    cnt++;
                    psHolder.Add(position + 100);

                }


            }

            if (psHolder.Count > 0)
            {

                txtMessage.SelectionStart = int.Parse(psHolder[0].ToString());
                txtMessage.ScrollToCaret();
            }
            else
            {
                toolStripStatusLabel.Text = "Not Found.";
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (txtSearch.Text.Length == 0)
            {
                txtMessage.SelectionStart = 0;
                txtMessage.ScrollToCaret();
            }
            if (e.KeyChar.Equals((char)13))
            {
                searchText();
                e.Handled = true; // suppress default handling
            }

        }



        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newFileName = DateTime.Today.ToShortDateString().ToString().Replace(@":", "_").Replace(" ", "_").Replace(@"/", "_");
            DialogResult dialogResult = MessageBox.Show("Want to give new name ?", "Attention", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                newFileName = Prompt.ShowDialog("Enter a filename ", "Attention");
            }
           
            

            if (!Directory.Exists(Helper.dirPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(Helper.dirPath);
                Console.WriteLine("The directory was created successfully at {0}.",
                    Directory.GetCreationTime(Helper.dirPath));
            }
            string fileName = Helper.dirPath + "Note_" + RandomNumber(1, 1000) + "__" + newFileName + ".txt";

            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine(txtMessage.Text);

            }

            if (Helper.driveService != null)
            {
                try
                { DialogResult dialogResultNew = MessageBox.Show("Want to upload the file to drive now ?","Attention",  MessageBoxButtons.YesNo);
                if (dialogResultNew == DialogResult.Yes)
                    {
                        Helper.uploadFile(Helper.driveService, Helper.getLastCreatedFile().FullName,
                            Properties.Settings.Default.parent_folder);
                        MessageBox.Show("StickyNote Saved & Synced To Drive!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File saved. Synced Failed");
                    Console.WriteLine("Error "+ex.StackTrace);
                }
                   
            }
            else
            {
                MessageBox.Show("You are not authorize yet for google drive.");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Browse Text Files";
            openFileDialog.DefaultExt = "txt";
            openFileDialog.CheckFileExists = true;

            openFileDialog.ShowDialog();
            readAFileIntoTextBox(new FileInfo(openFileDialog.FileName));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void authorizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoogleDriveApi googleDrive = new GoogleDriveApi();
            googleDrive.Show();
        }

        private void setDefaultFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Helper.dirPath = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.default_folder = Helper.dirPath + @"\";
                MessageBox.Show("Default folder path set. | > " + Properties.Settings.Default.default_folder);
                Properties.Settings.Default.Save();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int cpos = cpostion - 1;
            if (cpos >= 0)
            {
                if (psHolder.Count >= 0 && cpos < psHolder.Count)
                {
                    txtMessage.SelectionStart = int.Parse(psHolder[cpos].ToString());
                    cpostion = cpos;
                    txtMessage.ScrollToCaret();
                    toolStripStatusLabel.Text = "Found : " + psHolder.Count + " | On : " + cpostion.ToString();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int cpos = cpostion + 1;
            if (cpos >= 0)
            {
                if (psHolder.Count >= 0 && cpos < psHolder.Count)
                {
                    txtMessage.SelectionStart = int.Parse(psHolder[cpos].ToString());
                    cpostion = cpos;
                    txtMessage.ScrollToCaret();
                    toolStripStatusLabel.Text = "Found : " + psHolder.Count + " | On : " + cpostion.ToString();
                }
            }
        }

        private void btnPaypalDonate_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.paypal.me/Prince898/20");
            Process.Start(sInfo);
        }

        private void frmStickyNote_Leave(object sender, EventArgs e)
        {
            
        }

        private void frmStickyNote_Deactivate(object sender, EventArgs e)
        {
            string newFileName = DateTime.Today.ToShortDateString().ToString().Replace(@":", "_").Replace(" ", "_").Replace(@"/", "_");
            if (!Directory.Exists(Helper.dirPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(Helper.dirPath);
                Console.WriteLine("The directory was created successfully at {0}.",
                    Directory.GetCreationTime(Helper.dirPath));
            }
            string fileName = Helper.dirPath + "Note_" + RandomNumber(1, 1000) + "__" + newFileName + ".txt";

            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine(txtMessage.Text);

            }
        }

    }
}
