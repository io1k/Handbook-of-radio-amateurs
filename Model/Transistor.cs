using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook_of_radio_amateurs
{
    public class Transistor: Detail
    {   
        public string Type {  get; set; }
        public double Voltage { get; set; }
        public double Current {  get; set; }
        public override double CalculateDeference(params object[] numbers)
        {
            var transistor = (Transistor)numbers[0];
            var model = (string)numbers[1];
            var type = (string)numbers[2];
            var voltage = (double)numbers[3];
            var current = (double)numbers[4];
            double voltageDifference = Math.Abs(transistor.Voltage - voltage);
            double currentDifference = Math.Abs(transistor.Current - current);
            double score = 10000 - (voltageDifference * 10) - (currentDifference * 10);
            if (transistor.Type == type)
            {
                score += 10000;
            }
            if (transistor.Model == model)
            {
                score += 10000;
            }
            return score;
        }
    }
}
