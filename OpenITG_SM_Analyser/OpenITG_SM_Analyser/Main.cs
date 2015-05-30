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
        }

        private void Main_Load(object sender, EventArgs e) {

        }

        private void btn_openFile_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Simfile (.sm)|*.sm";

            DialogResult result = dialog.ShowDialog();
            
            // if file selected successfully, lets try and read it
            if (result == DialogResult.OK) {
                string filePath = dialog.FileName;
                try {
                    SimfileReader smReader = new SimfileReader();
                    smReader.Read(filePath);

                    txt_stepData.Text = smReader.StepData;
                } catch (IOException) {
                }
            }
        }
    }
}
