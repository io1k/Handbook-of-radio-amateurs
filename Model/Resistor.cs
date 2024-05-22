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
        public double CalculateDeference(Resistor resistor, string model,double resistance,int tolerance)
        {
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
