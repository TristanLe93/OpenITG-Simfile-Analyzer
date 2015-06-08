using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenITG_SM_Analyser {
    /// <summary>
    /// Stores data for a single step chart found in the simfile.
    /// </summary>
    public class StepChart {
        public string Difficulty;
        public string Author;
        public string StreamBreakdown;
        public List<int> MeasureDensity = new List<int>();
        public int Steps;

        public int MaxDensity {
            get {
                return MeasureDensity.Count;
            }
            private set {
                return;
            }
        }

        public int OverallDensity {
            get {
                int count = MeasureDensity.Count(n => n > 12);
                return count;
            }
            private set {
                return;
            }
        }

        public double DensityPercent {
            get {
                return Math.Round(OverallDensity / (float)MaxDensity * 100);
            }
            set {
                return;
            }
        }

        public StepChart() {
        }

    }
}
