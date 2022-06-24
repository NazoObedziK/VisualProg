using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public class Line
    {
        private Graphics graphics;
        public int X1,X2,Y1,Y2;
        
        public Line(Panel canvas,Pen pen,Point point1,Point point2)
        {//creating graphics on the our panel canvas
            graphics = canvas.CreateGraphics();
            //we r building line on 2 points and their x,y
            graphics.DrawLine(pen, point1, point2);
            this.X1 = point1.X;
            this.Y1 = point1.Y;
            this.X2 = point2.X;
            this.Y2 = point2.Y;
        }
        
    }
    /*public class Triangle
    {
        public Point[] vertex = new Point[3]; 
        public Triangle(Point point1,Point point2,Point point3)
        {
            this.vertex[0] = point1;
            this.vertex[1] = point2;
            this.vertex[2] = point3;
        }
       
    }*/
}
