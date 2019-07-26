using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10_Circles
{
    class Circle
    {
        #region Fields
        //fields
        private double radius;
        #endregion

        #region Properties
        //properties
       
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        #endregion

        #region Constructors
        //constructors
        public Circle()
        {
            radius = 5;
            
        }
        public Circle(double _radius)
        {
            radius = _radius;
            
        }
        #endregion
        public void PrintInfo()
        {
            Console.WriteLine("Radius: "+ Radius);
        }
        public double CalculateCircumference(double input)
        {
            return Math.Round(Math.PI*(radius * 2),2);
        }
        public double CalculateArea(double input)
        {
            return Math.Round(Math.PI * (radius * radius),2);
             
        }
    }

}
