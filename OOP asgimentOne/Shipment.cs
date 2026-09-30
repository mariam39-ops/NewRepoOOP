using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_asgimentOne
{
    internal struct Shipment
    {
        private string trackingCode;
        private string descrption;
        private double weight;
        private double deleiveryFee;
        public DeliveryAdress destination { get; set; }
              public string TrackingCode
        {
            get {
                return trackingCode;
            }
             private set {
               if(  TrackingCode!=null && TrackingCode != " ")
                {
                    trackingCode = value;
                }
            }

        } public string Descrption
        {
            get {
                return descrption;
            }
            set
            {
               if(Descrption !=null && Descrption!=" ") {
                    descrption = value;
          
                }            } 
            
        }public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (Weight > 0)
                {
                    Weight = value;
                }
            }
        }public  double DeleiveryFee
        {
            get {
                return deleiveryFee;
            }
            private set {
                if (DeleiveryFee > 0)
                {
                    DeleiveryFee = value;
                }
            }

        }
        public double EstimatedCost
        {
            get
            {
                return DeleiveryFee + (weight * 5);
            }


        }

    }
}
