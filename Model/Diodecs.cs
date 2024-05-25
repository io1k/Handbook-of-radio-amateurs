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
        public override double CalculateDeference(params object[] numbers)
        {
            var diode = (Diode)numbers[0];
            var model = (string)numbers[1];
            var shellType = (string)numbers[2];
            var voltage = (double)numbers[3];
            var current = (double)numbers[4];
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
