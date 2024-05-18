using Handbook_of_radio_amateurs;
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
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<T>>(json);
        }
        public void FormPicture<T>(List<T> list)  where T : Detail
        {
            foreach (var item in list)
            {
                if (item.imageLink != null)
                {
                    item.image = Image.FromFile(item.imageLink);
                }
            }
        }
        public List<Transistor> SortedTransistor(List<Transistor> list, string type, double voltage, double current)
        {
            List<Transistor> resultList = new List<Transistor>(list);

            resultList.Sort((a, b) =>
            {
                double scoreA = a.CalculateDeference(a, type, voltage, current);
                double scoreB = b.CalculateDeference(b, type, voltage, current);
                return scoreB.CompareTo(scoreA);
            });

            return resultList;
        }
        public List<Capasitor> SortedCapasitor(List<Capasitor> list, string type, double voltage, double capasity,double allovebletemp)
        {
            List<Capasitor> resultList = new List<Capasitor>(list);

            resultList.Sort((a, b) =>
            {
                double scoreA = a.CalculateDeference(a, type, allovebletemp, capasity, voltage);
                double scoreB = b.CalculateDeference(b, type, allovebletemp, capasity, voltage);
                return scoreB.CompareTo(scoreA);
            });

            return resultList;
        }
        public string TakeDataListType(string type)
        {
            if (type == "Transistor")
            {
                return "C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of amaters try\\Data\\TransistorData.json";
            }
            else if (type == "Capasitor")
            {
                return "C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of amaters try\\Data\\CapasitorData.json";
            }
            else
            {
                MessageBox.Show("Проблема з типом , зверніться до спеціаліста");
            }
            return string.Empty;
        }
        public List<List<object>> AddAllLists()
        {
            List<List<object>> myList = new List<List<object>>();
            myList.Add(ReadDetails<Transistor>("C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of radio amateurs\\Data\\TransistorData.json").Select(x => (object)x).ToList());
            myList.Add(ReadDetails<Capasitor>("C:\\Users\\iolk\\Desktop\\visual folder\\Handbook of radio amateurs\\Data\\CapasitorData.json").Select(x => (object)x).ToList());
            return myList;
        }
    }   
}   
