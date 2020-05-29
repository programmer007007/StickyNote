using System.Net.Mime;
using System.Windows.Forms;

namespace StickyNote
{
    partial class GoogleDriveApi
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAuthorize = new System.Windows.Forms.Button();
            this.txtSecretId = new StickyNote.CueTextBox();
            this.txtClientId = new StickyNote.CueTextBox();
            this.txtParentFolder = new StickyNote.CueTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(9, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(218, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAuthorize
            // 
            this.btnAuthorize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthorize.Location = new System.Drawing.Point(233, 118);
            this.btnAuthorize.Name = "btnAuthorize";
            this.btnAuthorize.Size = new System.Drawing.Size(102, 32);
            this.btnAuthorize.TabIndex = 3;
            this.btnAuthorize.Text = "Authorize";
            this.btnAuthorize.UseVisualStyleBackColor = true;
            this.btnAuthorize.Click += new System.EventHandler(this.btnAuthorize_Click);
            // 
            // txtSecretId
            // 
            this.txtSecretId.Cue = "Enter secret id";
            this.txtSecretId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretId.Location = new System.Drawing.Point(13, 48);
            this.txtSecretId.Name = "txtSecretId";
            this.txtSecretId.Size = new System.Drawing.Size(322, 29);
            this.txtSecretId.TabIndex = 2;
            // 
            // txtClientId
            // 
            this.txtClientId.Cue = "Enter client id";
            this.txtClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientId.Location = new System.Drawing.Point(13, 13);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(322, 29);
            this.txtClientId.TabIndex = 1;
            // 
            // txtParentFolder
            // 
            this.txtParentFolder.Cue = "Enter parent folder id  / Optional";
            this.txtParentFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentFolder.Location = new System.Drawing.Point(12, 83);
            this.txtParentFolder.Name = "txtParentFolder";
            this.txtParentFolder.Size = new System.Drawing.Size(322, 29);
            this.txtParentFolder.TabIndex = 4;
            // 
            // GoogleDriveApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 157);
            this.Controls.Add(this.txtParentFolder);
            this.Controls.Add(this.btnAuthorize);
            this.Controls.Add(this.txtSecretId);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.btnSave);
            this.Name = "GoogleDriveApi";
            this.Text = "GoogleDriveApi";
            this.Load += new System.EventHandler(this.GoogleDriveApi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private CueTextBox txtClientId;
        private CueTextBox txtSecretId;
        private Button btnAuthorize;
        private CueTextBox txtParentFolder;
    }
}