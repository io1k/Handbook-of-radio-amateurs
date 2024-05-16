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
        public int ForwardVoltageDrop { get; set; }
        public int ReverseVoltage {  get; set; }
        public int MaximumForwardCurrent {  get; set; }
    }
}
