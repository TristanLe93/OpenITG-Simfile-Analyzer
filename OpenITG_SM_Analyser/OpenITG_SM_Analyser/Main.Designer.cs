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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_openFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Bpm = new System.Windows.Forms.TextBox();
            this.txt_Artist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.streamMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.txt_densityPercent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_maxDensity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_avgDensity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_steps = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_streamBreakdown = new System.Windows.Forms.TextBox();
            this.difficultyList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_openFile
            // 
            this.btn_openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openFile.Location = new System.Drawing.Point(12, 113);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(187, 40);
            this.btn_openFile.TabIndex = 0;
            this.btn_openFile.Text = "Open Simfile...";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OpenITG_SM_Analyser.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Version 1.0 - By Tristan Le";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Bpm);
            this.groupBox1.Controls.Add(this.txt_Artist);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(205, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 115);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simfile Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "BPM:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_Bpm
            // 
            this.txt_Bpm.BackColor = System.Drawing.Color.White;
            this.txt_Bpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bpm.Location = new System.Drawing.Point(95, 81);
            this.txt_Bpm.Name = "txt_Bpm";
            this.txt_Bpm.ReadOnly = true;
            this.txt_Bpm.Size = new System.Drawing.Size(259, 22);
            this.txt_Bpm.TabIndex = 4;
            // 
            // txt_Artist
            // 
            this.txt_Artist.BackColor = System.Drawing.Color.White;
            this.txt_Artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Artist.Location = new System.Drawing.Point(95, 53);
            this.txt_Artist.Name = "txt_Artist";
            this.txt_Artist.ReadOnly = true;
            this.txt_Artist.Size = new System.Drawing.Size(259, 22);
            this.txt_Artist.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Song Artist:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.White;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(95, 25);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(259, 22);
            this.txt_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Song Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.streamMode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 62);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // streamMode
            // 
            this.streamMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.streamMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamMode.FormattingEnabled = true;
            this.streamMode.Items.AddRange(new object[] {
            "16ths",
            "24ths"});
            this.streamMode.Location = new System.Drawing.Point(104, 24);
            this.streamMode.Name = "streamMode";
            this.streamMode.Size = new System.Drawing.Size(70, 24);
            this.streamMode.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stream mode:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Difficulty:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_copy);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_Author);
            this.groupBox3.Controls.Add(this.txt_densityPercent);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_maxDensity);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_avgDensity);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_steps);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_streamBreakdown);
            this.groupBox3.Controls.Add(this.difficultyList);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 152);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step Chart Data";
            // 
            // btn_copy
            // 
            this.btn_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy.Location = new System.Drawing.Point(448, 114);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(106, 29);
            this.btn_copy.TabIndex = 13;
            this.btn_copy.Text = "Copy to clipboard";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(84, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Author:";
            // 
            // txt_Author
            // 
            this.txt_Author.BackColor = System.Drawing.Color.White;
            this.txt_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Author.Location = new System.Drawing.Point(139, 61);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.ReadOnly = true;
            this.txt_Author.Size = new System.Drawing.Size(192, 22);
            this.txt_Author.TabIndex = 21;
            // 
            // txt_densityPercent
            // 
            this.txt_densityPercent.BackColor = System.Drawing.Color.White;
            this.txt_densityPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_densityPercent.Location = new System.Drawing.Point(282, 89);
            this.txt_densityPercent.Name = "txt_densityPercent";
            this.txt_densityPercent.ReadOnly = true;
            this.txt_densityPercent.Size = new System.Drawing.Size(49, 22);
            this.txt_densityPercent.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(261, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "=";
            // 
            // txt_maxDensity
            // 
            this.txt_maxDensity.BackColor = System.Drawing.Color.White;
            this.txt_maxDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maxDensity.Location = new System.Drawing.Point(209, 89);
            this.txt_maxDensity.Name = "txt_maxDensity";
            this.txt_maxDensity.ReadOnly = true;
            this.txt_maxDensity.Size = new System.Drawing.Size(46, 22);
            this.txt_maxDensity.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(192, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "/";
            // 
            // txt_avgDensity
            // 
            this.txt_avgDensity.BackColor = System.Drawing.Color.White;
            this.txt_avgDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_avgDensity.Location = new System.Drawing.Point(139, 89);
            this.txt_avgDensity.Name = "txt_avgDensity";
            this.txt_avgDensity.ReadOnly = true;
            this.txt_avgDensity.Size = new System.Drawing.Size(47, 22);
            this.txt_avgDensity.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Stream Density:";
            // 
            // txt_steps
            // 
            this.txt_steps.BackColor = System.Drawing.Color.White;
            this.txt_steps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_steps.Location = new System.Drawing.Point(487, 21);
            this.txt_steps.Name = "txt_steps";
            this.txt_steps.ReadOnly = true;
            this.txt_steps.Size = new System.Drawing.Size(59, 22);
            this.txt_steps.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(435, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Steps:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stream Breakdown:";
            // 
            // txt_streamBreakdown
            // 
            this.txt_streamBreakdown.BackColor = System.Drawing.Color.White;
            this.txt_streamBreakdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_streamBreakdown.Location = new System.Drawing.Point(139, 117);
            this.txt_streamBreakdown.Name = "txt_streamBreakdown";
            this.txt_streamBreakdown.ReadOnly = true;
            this.txt_streamBreakdown.Size = new System.Drawing.Size(303, 22);
            this.txt_streamBreakdown.TabIndex = 6;
            // 
            // difficultyList
            // 
            this.difficultyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyList.FormattingEnabled = true;
            this.difficultyList.Location = new System.Drawing.Point(83, 21);
            this.difficultyList.Name = "difficultyList";
            this.difficultyList.Size = new System.Drawing.Size(226, 24);
            this.difficultyList.TabIndex = 11;
            this.difficultyList.SelectedIndexChanged += new System.EventHandler(this.difficultyList_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 422);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_openFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simfile Analyser [SM 3.95 and OpenITG only]";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Artist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.ComboBox streamMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Bpm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox difficultyList;
        private System.Windows.Forms.TextBox txt_steps;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_streamBreakdown;
        private System.Windows.Forms.TextBox txt_avgDensity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.TextBox txt_densityPercent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_maxDensity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_copy;
    }
}

