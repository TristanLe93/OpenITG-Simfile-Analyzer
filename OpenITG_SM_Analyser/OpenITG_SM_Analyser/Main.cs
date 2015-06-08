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
        private List<StepChart> stepCharts;

        public Main() {
            InitializeComponent();
            streamMode.SelectedIndex = 0;
        }

        private void Main_Load(object sender, EventArgs e) {
            // create tooltips to help user with controls information
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 250;
            toolTip1.ReshowDelay = 500;

            toolTip1.SetToolTip(label4, "Determines which measure of notes to look for in a stream.");
            toolTip1.SetToolTip(streamMode, "Determines which measure of notes to look for in a stream.");
            toolTip1.SetToolTip(label9, "Stream Density (%) = measures of stream / total measures.");
            toolTip1.SetToolTip(label5, "A stream breakdown using notation. (dots = breaks, numbers = measures of stream");
            toolTip1.SetToolTip(txt_avgDensity, "Measures of stream.");
            toolTip1.SetToolTip(txt_maxDensity, "Total Measures");
        }

        private void btn_openFile_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Simfile |*.sm";

            DialogResult result = dialog.ShowDialog();
            
            if (result == DialogResult.OK) {
                string filePath = dialog.FileName;
                
                try {
                    // try reading the file and output information
                    SimfileReader smReader = new SimfileReader(streamMode.SelectedIndex);
                    smReader.Read(filePath);

                    difficultyList.Items.Clear();

                    // set stepchart comboBox
                    for (int i = 0; i < smReader.StepCharts.Count; i++) {
                        difficultyList.Items.Add(smReader.StepCharts[i].Difficulty);
                    }

                    // simfile information
                    txt_Name.Text = smReader.SongName;
                    txt_Artist.Text = smReader.SongArtist;
                    txt_Bpm.Text = smReader.Bpm;

                    stepCharts = smReader.StepCharts;
                    difficultyList.SelectedIndex = 0;
                    
                } catch (IOException) {
                }
            }
        }

        private void difficultyList_SelectedIndexChanged(object sender, EventArgs e) {
            int index = difficultyList.SelectedIndex;
            StepChart stepChart = stepCharts[index];

            txt_Author.Text = stepChart.Author;
            txt_steps.Text = stepChart.Steps.ToString();
            txt_streamBreakdown.Text = stepChart.StreamBreakdown;
            txt_avgDensity.Text = stepChart.OverallDensity.ToString();
            txt_maxDensity.Text = stepChart.MaxDensity.ToString();
            txt_densityPercent.Text = stepChart.DensityPercent + "%";
        }

        private void btn_copy_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txt_streamBreakdown.Text)) {
                Clipboard.SetText(txt_streamBreakdown.Text);
            }
        }
    }
}
