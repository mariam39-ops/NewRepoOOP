using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_asgimentOne
{
    internal struct DeliveryAdress
    {
        private string City;
        private string Street;
        private int BuldingNumber;
        public DeliveryAdress(string c,string s,int b)
        {
            City = c;
            Street = s;
            BuldingNumber = b;
        }
        public void setCity(string c)
        {
            City = c;
        }public string getCity()
        {
            return City;
        }
        public void setStreet(string s)
        {
            Street = s;
        }
        public string getStreet()
        {
            return Street;
        }
        public void setBuldingNum(int b)
        {
            BuldingNumber= b;
        }
        public string getBuldingNum()
        {
            return City;
        }
        public string GetFullAdress()
        {
            return $" {getCity()}: {getStreet()}: {getBuldingNum()} ";
        }

    }
}
