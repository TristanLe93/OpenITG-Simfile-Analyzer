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
        public string SongArtist;
        public string Bpm;

        public List<StepChart> StepCharts = new List<StepChart>();
        private StepChart currentChart;

        // simfile information tags
        private const string NAME_TAG = "#TITLE:";
        private const string ARTIST_TAG = "#ARTIST:";
        private const string BPM_TAG = "#DISPLAYBPM:";
        private const string BPMS_TAG = "#BPMS:";
        private const string NOTES_TAG = "#NOTES:";

        /** 
         * A measure is considered a stream when the counted steps 
         * are GREATER than the threshold percentage.
         * 
         * Eg. a measure that contains 16 notes with a step threshold of 75% will only require
         * 12 notes to be considered a stream (16 notes * 0.75 = 12 notes). 
         * - This feature is only applied up to 24 note measures. 
         * - Greater than 24 note measures will use a constant variable, STEPS_THRESHOLD.
         */
        private const float STEPS_THRESHOLD_PERCENT = 0.75f;
        private const int STEPS_THRESHOLD = 18;
        private string line;

        private StreamReader reader = null;
        private int notesInMeasure;
        

        /// <summary>
        /// Readys the SimfileReader. Set streamMode according to stepsInMeasure.
        /// </summary>
        public SimfileReader(int streamMode) {
            if (streamMode == 0) {
                notesInMeasure = 16;
            } else if (streamMode == 1) {
                notesInMeasure = 24;
            }
        }

        /// <summary>
        /// Opens and reads the .sm file indicated by 'filePath'.
        /// </summary>
        public void Read(string filePath) {
            try {
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
            } catch (Exception e) {
                if (reader != null) {
                    reader.Close();
                    reader = null;
                }
            }
        }

        /// <summary>
        /// Returns true or false if the step threshold has been exceeded.
        /// Note: refer to comment above for step threshold explaination.
        /// </summary>
        private bool IsStepThresholdExceeded(int steps) {
            return (notesInMeasure > 24 && steps > STEPS_THRESHOLD) ||
                (notesInMeasure >= 16 && notesInMeasure <= 24 && steps > notesInMeasure * STEPS_THRESHOLD_PERCENT);
        }

        /// <summary>
        /// Fetches the song's Name and BPM.
        /// </summary>
        private void FetchSongProperties() {
            // loop through each line and find the song name and bpm
            while ((line = reader.ReadLine()) != null) {
                if (line.Contains(NAME_TAG)) {
                    SongName = line.Split(':')[1].Trim(';');
                } 
                else if (line.Contains(BPM_TAG)) {
                    Bpm = line.Split(':')[1].Trim(';');
                } 
                else if (line.Contains(ARTIST_TAG)) {
                    SongArtist = line.Split(':')[1].Trim(';');
                } 
                else if (line.Contains(BPMS_TAG)) {
                    Bpm = line.Split(':')[1].Split(',')[0].Split('=')[1].Trim(';');
                } 
                else if (line.Contains(NOTES_TAG)) {
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
                currentChart = new StepChart();

                // skip to line: "dance-single" / "dance-double"
                reader.ReadLine();

                currentChart.Author = reader.ReadLine().Trim(':').Trim();
                currentChart.Difficulty = reader.ReadLine().Trim(':').Trim();                    // difficulty name
                currentChart.Difficulty += " (" + reader.ReadLine().Trim(':').Trim() + ")";      // difficulty value

                reader.ReadLine();
            }
        }

        /// <summary>
        /// Loops through the step data line by line and 
        /// records measure data throughout the stepchart.
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
                    if (IsStepThresholdExceeded(steps)) {
                        streamMeasures++;

                        // enter rest measures step data if any
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

                        // enter stream measures step data if any
                        if (streamMeasures > 0) {
                            stepData += streamMeasures.ToString();
                            streamMeasures = 0;
                        }
                    }

                    currentChart.MeasureDensity.Add(steps);
                    currentChart.Steps += steps;
                    steps = 0;
                }

                // a step found?
                else if (line.Contains('1')) {
                    steps++;
                }

                // have we reached the end of the chart?
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

                    currentChart.MeasureDensity.Add(steps);
                    currentChart.StreamBreakdown = stepData;
                    StepCharts.Add(currentChart);
                    break;
                }
            }
        }
    }
}
