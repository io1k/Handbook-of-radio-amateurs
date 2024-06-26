﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;

namespace Handbook_of_radio_amateurs
{

    public abstract class Detail
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public Image image { get; set; }
        public string imageLink { get; set; }
        public abstract double CalculateDeference(params object[] numbers);

    }
}
