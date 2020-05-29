namespace StickyNote
{
    partial class frmStickyNote
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
            this.pnlHolder = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtSearch = new StickyNote.CueTextBox();
            this.btnPaypalDonate = new System.Windows.Forms.Button();
            this.pnlHolder.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHolder
            // 
            this.pnlHolder.AutoSize = true;
            this.pnlHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHolder.Controls.Add(this.txtMessage);
            this.pnlHolder.Controls.Add(this.statusStrip);
            this.pnlHolder.Location = new System.Drawing.Point(12, 101);
            this.pnlHolder.Name = "pnlHolder";
            this.pnlHolder.Size = new System.Drawing.Size(262, 504);
            this.pnlHolder.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(0, 4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtMessage.Size = new System.Drawing.Size(257, 473);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.Text = "";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 480);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(260, 22);
            this.statusStrip.TabIndex = 1;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel.Text = "None";
            this.toolStripStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(264, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save && Sync";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(283, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorizeToolStripMenuItem,
            this.setDefaultFolderToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // authorizeToolStripMenuItem
            // 
            this.authorizeToolStripMenuItem.Name = "authorizeToolStripMenuItem";
            this.authorizeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.authorizeToolStripMenuItem.Text = "Authorize";
            this.authorizeToolStripMenuItem.Click += new System.EventHandler(this.authorizeToolStripMenuItem_Click);
            // 
            // setDefaultFolderToolStripMenuItem
            // 
            this.setDefaultFolderToolStripMenuItem.Name = "setDefaultFolderToolStripMenuItem";
            this.setDefaultFolderToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.setDefaultFolderToolStripMenuItem.Text = "Set Default Folder";
            this.setDefaultFolderToolStripMenuItem.Click += new System.EventHandler(this.setDefaultFolderToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Select File ...";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(237, 23);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 36);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(197, 23);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(40, 36);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cue = "Type to search ....";
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 29);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnPaypalDonate
            // 
            this.btnPaypalDonate.Location = new System.Drawing.Point(12, 612);
            this.btnPaypalDonate.Name = "btnPaypalDonate";
            this.btnPaypalDonate.Size = new System.Drawing.Size(264, 23);
            this.btnPaypalDonate.TabIndex = 8;
            this.btnPaypalDonate.Text = "Paypal Donate";
            this.btnPaypalDonate.UseVisualStyleBackColor = true;
            this.btnPaypalDonate.Click += new System.EventHandler(this.btnPaypalDonate_Click);
            // 
            // frmStickyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 643);
            this.Controls.Add(this.btnPaypalDonate);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlHolder);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmStickyNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sticky Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHolder.ResumeLayout(false);
            this.pnlHolder.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CueTextBox txtSearch;
        private System.Windows.Forms.Panel pnlHolder;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem authorizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDefaultFolderToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnPaypalDonate;
    }
}

