namespace OpenITG_SM_Analyser {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btn_openFile = new System.Windows.Forms.Button();
            this.txt_stepData = new System.Windows.Forms.TextBox();
            this.btn_folderBrowse = new System.Windows.Forms.Button();
            this.songListBox = new System.Windows.Forms.CheckedListBox();
            this.btn_exportXL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(13, 359);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(121, 23);
            this.btn_openFile.TabIndex = 0;
            this.btn_openFile.Text = "Open Simfile...";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // txt_stepData
            // 
            this.txt_stepData.Location = new System.Drawing.Point(12, 388);
            this.txt_stepData.Multiline = true;
            this.txt_stepData.Name = "txt_stepData";
            this.txt_stepData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_stepData.Size = new System.Drawing.Size(670, 171);
            this.txt_stepData.TabIndex = 1;
            // 
            // btn_folderBrowse
            // 
            this.btn_folderBrowse.Location = new System.Drawing.Point(13, 13);
            this.btn_folderBrowse.Name = "btn_folderBrowse";
            this.btn_folderBrowse.Size = new System.Drawing.Size(120, 23);
            this.btn_folderBrowse.TabIndex = 2;
            this.btn_folderBrowse.Text = "Browse Song Folder";
            this.btn_folderBrowse.UseVisualStyleBackColor = true;
            this.btn_folderBrowse.Click += new System.EventHandler(this.btn_folderBrowse_Click);
            // 
            // songListBox
            // 
            this.songListBox.FormattingEnabled = true;
            this.songListBox.Location = new System.Drawing.Point(13, 43);
            this.songListBox.Name = "songListBox";
            this.songListBox.Size = new System.Drawing.Size(311, 259);
            this.songListBox.TabIndex = 3;
            // 
            // btn_exportXL
            // 
            this.btn_exportXL.Location = new System.Drawing.Point(13, 308);
            this.btn_exportXL.Name = "btn_exportXL";
            this.btn_exportXL.Size = new System.Drawing.Size(100, 23);
            this.btn_exportXL.TabIndex = 4;
            this.btn_exportXL.Text = "Export to .xlsx...";
            this.btn_exportXL.UseVisualStyleBackColor = true;
            this.btn_exportXL.Click += new System.EventHandler(this.btn_exportXL_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 571);
            this.Controls.Add(this.btn_exportXL);
            this.Controls.Add(this.songListBox);
            this.Controls.Add(this.btn_folderBrowse);
            this.Controls.Add(this.txt_stepData);
            this.Controls.Add(this.btn_openFile);
            this.Name = "Main";
            this.Text = "Simfile Analyzer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.TextBox txt_stepData;
        private System.Windows.Forms.Button btn_folderBrowse;
        private System.Windows.Forms.CheckedListBox songListBox;
        private System.Windows.Forms.Button btn_exportXL;
    }
}

