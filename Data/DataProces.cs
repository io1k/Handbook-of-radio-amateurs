﻿using Handbook_of_radio_amateurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handbook_of_radio_amauter.Data
{
    class DataProces
    {
        public DataProces() { } 
        public List<T> ReadDetails<T>(string filePath) where T : new()
        {
            try
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<T>>(json);
            }
            catch(Exception) 
            {
                MessageBox.Show("There is a problem with the file, contact a specialist.");
                return new List<T>() ;
            }

        }
        public void FormPicture<T>(List<T> list)  where T : Detail
        {
            foreach (var item in list)
            {
                try
                {
                    if (item.imageLink != null)
                    {
                        var bit1 = new Bitmap(150,150);
                        bit1 = new Bitmap(item.imageLink);
                        item.image = bit1;
                    }
                }
                catch (Exception)
                {
                    item.image = Image.FromFile("C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of radio amateurs\\Data\\src\\cprruptedFile.jpg");
                }    
            }
        }
        public List<Transistor> SortedTransistor(List<Transistor> list, string model, string type, double voltage, double current)
        {
            List<Transistor> resultList = new List<Transistor>(list);

            resultList.Sort((a, b) =>
            {
                double scoreA = a.CalculateDeference(a,model, type, voltage, current);
                double scoreB = b.CalculateDeference(b,model, type, voltage, current);
                return scoreB.CompareTo(scoreA);
            });

            return resultList;
        }
        public List<Capasitor> SortedCapasitor(List<Capasitor> list,string model, string type, double voltage, double capasity,double allovebletemp)
        {
            List<Capasitor> resultList = new List<Capasitor>(list);

            resultList.Sort((a, b) =>
            {
                double scoreA = a.CalculateDeference(a, model,type, allovebletemp, capasity, voltage);
                double scoreB = b.CalculateDeference(b, model, type, allovebletemp, capasity, voltage);
                return scoreB.CompareTo(scoreA);
            });

            return resultList;
        }
        public List<Diode> SortedDiode(List<Diode> list, string model, string shellType, double voltage, double current)
        {
            List<Diode> resultList = new List<Diode>(list);

            resultList.Sort((a, b) =>
            {
                double scoreA = a.CalculateDeference(a, model, shellType, current, voltage);
                double scoreB = b.CalculateDeference(b, model, shellType, current, voltage);
                return scoreB.CompareTo(scoreA);
            });

            return resultList;
        }
        public List<Resistor> SortedResistors(List<Resistor> list, string model, double resistence, int tolerance)
        {
            List<Resistor> resultList = new List<Resistor>(list);

            resultList.Sort((a, b) =>
            {
                double scoreA = a.CalculateDeference(a, model, resistence, tolerance);
                double scoreB = b.CalculateDeference(b, model, resistence, tolerance);
                return scoreB.CompareTo(scoreA);
            });

            return resultList;
        }
        public List<List<object>> AddAllLists()
        {
            List<List<object>> myList = new List<List<object>>();
            myList.Add(ReadDetails<Transistor>("C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of radio amateurs\\Data\\DetailsData\\TransistorData.json").Select(x => (object)x).ToList());
            myList.Add(ReadDetails<Capasitor>("C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of radio amateurs\\Data\\DetailsData\\CapasitorData.json").Select(x => (object)x).ToList());
            myList.Add(ReadDetails<Diode>("C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of radio amateurs\\Data\\DetailsData\\DiodesData.json").Select(x => (object)x).ToList());
            myList.Add(ReadDetails<Resistor>("C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of radio amateurs\\Data\\DetailsData\\ResistorsData.json").Select(x => (object)x).ToList());
            return myList;
        }
    }   
}   
