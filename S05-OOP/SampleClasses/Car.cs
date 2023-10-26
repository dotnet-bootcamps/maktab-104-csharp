using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S04_OOP.SampleClasses
{
    public class Car
    {
        public static string name = "Pride";
        
        public string model = "";
        public string color = "";
        public string vin = "";
        public string engineNumber = "";
        
        private int _speed = 0;


        public void ChangeColor(string newColor)
        {
            color=newColor;
        }

        public void Start()
        {

        }

        public void IncreaseSpeed(int kph)
        {
            _speed = kph;
        }


    }
}