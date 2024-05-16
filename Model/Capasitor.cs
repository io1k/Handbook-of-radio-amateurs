﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook_of_radio_amateurs
{
    public class Capasitor: Detail
    {
        public int Capasity {  get; set; }
        public int AllowableTemperature { get; set; }
        public string Type {  get; set; }
        public double Voltage {  get; set; }
        public double CalculateDeference(Capasitor capasitor, string type, double AllowableTemperature, double Capasity, double Voltage)
        {
            double AllowableTemperatureDifference = Math.Abs(capasitor.AllowableTemperature - AllowableTemperature);
            double currentDifference = Math.Abs(capasitor.Capasity - Capasity);
            double voltageDifference = Math.Abs(capasitor.Voltage - Voltage);
            double score = 1500 - (voltageDifference * 10) - (currentDifference * 10) - (AllowableTemperatureDifference * 10);
            if (capasitor.Type == type)
            {
                score += 1000;
            }
            return score;
        }

    }
}