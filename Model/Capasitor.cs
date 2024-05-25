using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Handbook_of_radio_amateurs
{
    public class Capasitor: Detail
    {
        public double Capasity {  get; set; }
        public double AllowableTemperature { get; set; }
        public string Type {  get; set; }
        public double Voltage {  get; set; }
        public override double CalculateDeference(params object[] numbers)
        {
            var capasitor = (Capasitor)numbers[0];
            var model = (string)numbers[1];
            var type = (string)numbers[2];
            var AllowableTemperature = (double)numbers[3];
            var capasity = (double)numbers[4];
            var voltage = (double)numbers[5];
            double AllowableTemperatureDifference = Math.Abs(capasitor.AllowableTemperature - AllowableTemperature);
            double currentDifference = Math.Abs(capasitor.Capasity - capasity);
            double voltageDifference = Math.Abs(capasitor.Voltage - voltage);
            double score = 15000 - (voltageDifference * 10) - (currentDifference * 10) - (AllowableTemperatureDifference * 10);
            if (capasitor.Type == type)
            {
                score += 10000;
            }
            if (capasitor.Model == model)
            {
                score += 10000;
            }
            return score;
        }

    }
}
