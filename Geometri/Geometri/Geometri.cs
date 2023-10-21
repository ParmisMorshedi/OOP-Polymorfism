using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Geometri
    {
        //polymorfism
        public virtual double Area()
        {
            return 0.0;
        }

    }
    public class Rectangle : Geometri
    {
        public int Length {  get; set; }  
        public int Width { get; set; }

        public Rectangle()     
        
        {
            Length=7;
            Width = 8;
        
        }
       
        public override double Area()
        {
            return Length* Width;
        }


    }
    public class Square : Geometri 
    {
        public int Side { get; set; }

        public Square() 
        {
            Side = 4;
        
        }


        public override double Area()
        {
            return Side* Side;
        }
    }
    public class Circle : Geometri
    {
        public int Radius { get; set; }
        public Circle() 
        {
            Radius = 3;
        }
    
    public override double Area()
        {
            return Math.PI* Radius* Radius;
        }
    }
    public class Parallellogram : Geometri 
    {
        public int BaseLength { get; set; }
        public int Height { get; set; }

        public Parallellogram() 
        {
            BaseLength = 9;
            Height = 2;
        
        }
        public override double Area()
        {
            return BaseLength* Height;
        }
    }
    public class Ellipse : Geometri 
    {
        public int MajorAxis { get; set; }
        public int MinorAxis { get; set; }

        public Ellipse() 
        {
            MajorAxis = 3;
            MinorAxis = 6;
        
        }
        public override double Area()
        {
            return Math.PI* MajorAxis* MajorAxis;
        }
    }

}
