using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Data.OleDb;

namespace OpenITG_SM_Analyser {
    public partial class Main : Form {
        private string folderPath;
        private string[] songFolders;

        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
        }

        private void btn_openFile_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Simfile |*.sm";

            DialogResult result = dialog.ShowDialog();
            
            // if file selected successfully, lets try and read it
            if (result == DialogResult.OK) {
                string filePath = dialog.FileName;
                
                try {
                    SimfileReader smReader = new SimfileReader();
                    smReader.Read(filePath);

                    // output infomation to text box
                    txt_stepData.Text = String.Format("{0} {1}", smReader.SongName, smReader.Bpm);

                    for (int i = 0; i < smReader.Authors.Count; i++) {
                        string text = String.Format("{0} -> {1}", smReader.Difficulties[i], smReader.StepData[i]);
                        txt_stepData.Text += Environment.NewLine + text;
                    }
                } catch (IOException) {
                }
            }
        }

        private void btn_folderBrowse_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK) {
                folderPath = dialog.SelectedPath;
                songListBox.Items.Clear();

                // list all items in the songlistbox
                songFolders = Directory.GetDirectories(dialog.SelectedPath);
                foreach (string song in songFolders) {
                    songListBox.Items.Add(Path.GetFileName(song), true);
                }
            }
        }

        private void btn_exportXL_Click(object sender, EventArgs e) {
            txt_stepData.Clear();

            // for each checked box, go through the folders for .sm files and open them
            foreach (int index in songListBox.CheckedIndices) {
                DirectoryInfo info = new DirectoryInfo(songFolders[index]);
                FileInfo[] smFiles = info.GetFiles("*.sm");

                // if an .sm file is found, open it and get its data
                foreach (FileInfo smFile in smFiles) {
                    try {
                        SimfileReader smReader = new SimfileReader();
                        smReader.Read(smFile.FullName);

                        // output infomation to text box
                        txt_stepData.Text += String.Format("{0} {1}", smReader.SongName, smReader.Bpm);

                        for (int i = 0; i < smReader.Authors.Count; i++) {
                            string text = String.Format("{0} -> {1}", smReader.Difficulties[i], smReader.StepData[i]);
                            txt_stepData.Text += Environment.NewLine + text;
                        }

                        txt_stepData.Text += Environment.NewLine;
                    } catch (IOException) {
                    }
                }
            }

            
        }
    }
}
