using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook_of_radio_amateurs
{
    public class Diode: Detail
    {
        public double Current { get; set; }
        public double Voltage {  get; set; }
        public string ShellType {  get; set; }
        public double CalculateDeference(Diode diode, string model, string shellType, double current, double voltage)
        {
            double currentDifference = Math.Abs(diode.Current - current);
            double voltageDifference = Math.Abs(diode.Voltage - voltage);
            double score = 15000 - (voltageDifference * 10) - (currentDifference * 10);

            if (diode.ShellType == shellType)
            {
                score += 10000;
            }

            if (diode.Model == model)
            {
                score += 10000;
            }
            return score;
        }
    }
}
