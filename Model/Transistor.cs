using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Handbook_of_radio_amauter.Data.DataProces;

namespace Handbook_of_radio_amateurs
{
    public class Transistor: Detail
    {   
        public string Type {  get; set; }
        public double Voltage { get; set; }
        public double Current {  get; set; }
        public double CalculateDeference(Transistor transistor, string model,string type, double voltage, double current)
        {
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
