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
        private StreamReader reader = null;

        // simfile information tags
        private const string NAME_TAG = "#TITLE:";
        private const string BPM_TAG = "#DISPLAYBPM:";
        private const string NOTES_TAG = "#NOTES:";
        
        private const int STEPS_THRESHOLD = 13;
        private string line;

        // song information
        public string SongName;
        public string Bpm;
        public List<string> Authors = new List<string>();
        public List<string> StepData = new List<string>();
        public List<string> Difficulties = new List<string>();

  
        public SimfileReader() {
        }

        /// <summary>
        /// Opens and reads the .sm file indicated by 'filePath'.
        /// </summary>
        public void Read(string filePath) {
            reader = new StreamReader(filePath);

            FetchSongProperties();

            // loop through each line until we find a step chart ("#NOTES:" tag)
            do {
                if (line.Contains(NOTES_TAG)) {
                    FetchChartProperties();
                    FetchStepData();
                }
            } while ((line = reader.ReadLine()) != null);

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
                    break; // exit
                }
            }
        }

        /// <summary>
        /// Fetches the chart's properties including the Author and Difficulty Level.
        /// Note: Only works if the "#NOTES" tag is present in the current 'line'.
        /// </summary>
        private void FetchChartProperties() {
            if (line.Contains(NOTES_TAG)) {
                string difficulty;
                string author;

                // skip to line: "dance-single" / "dance-double"
                reader.ReadLine();

                author = reader.ReadLine().Trim(':');
                difficulty = reader.ReadLine().Trim(':');
                difficulty += "(" + reader.ReadLine().Trim(':') + ")";

                reader.ReadLine();

                Authors.Add(author);
                Difficulties.Add(difficulty);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void FetchStepData() {
            string stepData = string.Empty;
            int streamMeasures = 0;
            int restMeasures = 0;
            int steps = 0;

            // get step data
            while ((line = reader.ReadLine()) != null) {

                // end of measure?
                if (line.Contains(',') || line.Contains(';')) {
                    if (steps >= STEPS_THRESHOLD) {
                        streamMeasures++;

                        if (restMeasures > 0) {
                            if (restMeasures == 1) {
                                stepData += "-";
                            } else if (restMeasures >= 17) {
                                stepData += " ... ";
                            } else if (restMeasures >= 5) {
                                stepData += " .. ";
                            } else if (restMeasures > 1) {
                                stepData += " . ";
                            }

                            restMeasures = 0;
                        }
                    } else {
                        restMeasures++;

                        if (streamMeasures > 0) {
                            stepData += streamMeasures.ToString();
                            streamMeasures = 0;
                        }
                    }

                    steps = 0;

                    // have we reached the end of the song?
                    if (line.Contains(';')) {
                        if (streamMeasures > 0) {
                            stepData += streamMeasures.ToString();
                        } else if (restMeasures > 0) {
                            if (restMeasures == 1) {
                                stepData += "-";
                            } else if (restMeasures >= 17) {
                                stepData += " ... ";
                            } else if (restMeasures >= 5) {
                                stepData += " .. ";
                            } else if (restMeasures > 1) {
                                stepData += " . ";
                            }
                        }

                        StepData.Add(stepData);
                        break;
                    }
                }

                // a step found?
                else if (line.Contains('1')) {
                    steps++;
                }
            }
        }
    }
}
