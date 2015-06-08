using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace OpenITG_SM_Analyser {
    public partial class Main : Form {

        public Main() {
            InitializeComponent();
            streamMode.SelectedIndex = 0;
        }

        private void Main_Load(object sender, EventArgs e) {
        }

        private void btn_openFile_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Simfile |*.sm";

            DialogResult result = dialog.ShowDialog();
            
            if (result == DialogResult.OK) {
                string filePath = dialog.FileName;
                
                // try reading the file and output information
                try {
                    SimfileReader smReader = new SimfileReader(streamMode.SelectedIndex);
                    smReader.Read(filePath);

                    txt_stepData.Clear();

                    // output step chart breakdown
                    for (int i = 0; i < smReader.Authors.Count; i++) {
                        string text = String.Format("{0} -> {1}", smReader.Difficulties[i], smReader.StepData[i]);

                        if (i > 0) {
                            txt_stepData.Text += Environment.NewLine;
                        }
                        txt_stepData.Text += text;
                    }

                    // simfile information
                    txt_Name.Text = smReader.SongName;
                    txt_Artist.Text = smReader.SongArtist;
                    txt_Bpm.Text = smReader.Bpm;

                } catch (IOException) {
                }
            }
        }
    }
}
