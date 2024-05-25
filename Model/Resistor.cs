using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook_of_radio_amateurs
{
    public class Resistor: Detail
    {
        public double Resistance {  get; set; }
        public double Power { get; set; }
        public int Tolerance { get; set; }
        public override double CalculateDeference(params object[] numbers)
        {
            var resistor = (Resistor)numbers[0];
            var model = (string)numbers[1];
            var resistance = (double)numbers[2];
            var tolerance = (int)numbers[3];
            double resistenceDifference = Math.Abs(resistor.Resistance - resistance);
            double toleranceDifference = Math.Abs(resistor.Tolerance - tolerance);
            double score = 15000 - (resistenceDifference * 10) - (toleranceDifference * 10);
            if (resistor.Model == model)
            {
                score += 10000;
            }
            return score;
        }
    }
}
