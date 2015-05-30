using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OpenITG_SM_Analyser {
    /// <summary>
    /// SimfileReader is a text reader that opens .SM files.
    /// </summary>
    public class SimfileReader {
        // song information
        public string SongName;
        public string Difficulty;
        public string Bpm;
        public string Author;
        public string StepData;

        // simfile information tags
        private const string NAME_TAG = "#TITLE";
        private const string BPM_TAG = "#DISPLAYBPM";
        private const string NOTES_TAG = "#NOTES";
       
        // current line being read from .sm
        private string line;

        // no. of steps required to be considered a stream measure
        private const int STEPS_THRESHOLD = 13;
        
        private StreamReader reader = null;

        public SimfileReader() {
        }

        public void Read(string filePath) {
            reader = new StreamReader(filePath);

            FetchSongProperties();
            FetchChartProperties();
            FetchStepData();

            // finish reading
            reader.Close();
            reader = null;
        }

        /// <summary>
        /// Fetches the song's Name and BPM.
        /// </summary>
        private void FetchSongProperties() {
            // loop through each line and find the song name and bpm
            while ((line = reader.ReadLine()) != null) {
                if (line.Contains(NAME_TAG)) {
                    SongName = line.Split(':')[1].Trim(';');
                } else if (line.Contains(BPM_TAG)) {
                    Bpm = line.Split(':')[1].Trim(';');
                } else if (line.Contains(NOTES_TAG)) {
                    // exit
                    break;
                }
            }
        }

        /// <summary>
        /// Fetches the chart's properties including the Author and Difficulty Level.
        /// Note: Only works if the "#NOTES" tag is present in the current 'line'.
        /// </summary>
        private void FetchChartProperties() {
            if (line.Contains(NOTES_TAG)) {
                // skip to line: "dance-single" / "dance-double"
                reader.ReadLine();

                Author = reader.ReadLine().Trim(':');
                reader.ReadLine();
                Difficulty = reader.ReadLine().Trim(':');
                reader.ReadLine();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void FetchStepData() {
            int streamMeasures = 0;
            int restMeasures = 0;
            int steps = 0;

            // get step data
            while ((line = reader.ReadLine()) != null) {
                // end of song?
                if (line.Contains(';')) {
                    break;
                }

                // end of measure?
                else if (line.Contains(',')) {
                    if (steps >= STEPS_THRESHOLD) {
                        streamMeasures++;

                        if (restMeasures > 0) {
                            if (restMeasures == 1) {
                                StepData += "-";
                            } else if (restMeasures >= 17) {
                                StepData += " ... ";
                            } else if (restMeasures >= 5) {
                                StepData += " .. ";
                            } else if (restMeasures > 1) {
                                StepData += " . ";
                            }

                            restMeasures = 0;
                        }

                    } else {
                        restMeasures++;

                        if (streamMeasures > 0) {
                            StepData += streamMeasures.ToString();
                            streamMeasures = 0;
                        }
                    }

                    steps = 0;
                }

                // a step found?
                else if (line.Contains('1')) {
                    steps++;
                }
            }
        }
    }
}
