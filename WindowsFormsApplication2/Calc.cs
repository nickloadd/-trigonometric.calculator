using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public class Calc : InterfaceCalc
    {
                private double a=0;
                public void Put_A(double a)
        {
            this.a = a;
        }
        public void Clear_A()
        {
            a = 0;
        }
        public double siin(double b)
        {
            double c;
            if (a == double.PositiveInfinity || a == double.NegativeInfinity)
            {
                MessageBox.Show("Не существует!Совет: Введите корректное значение");
                c = 0;              
            }
            else
            if (a % 180 == 0.0) 
            {
                c = 0;
            }
            else
                c = Math.Sin(Math.PI * a / 180);
            return Math.Round(c, 5);
        }
        public double coos(double b)
        {
            double c;
            if (a == double.PositiveInfinity || a == double.NegativeInfinity)
            {
                MessageBox.Show("Не существует!Совет: Введите корректное значение");
                c = 0;
            }
            else
            if ((a % 90 == 0.0) && (a % 180 != 0.0))
            {
                             c = 0;
            }
            else
                c = Math.Cos(Math.PI * a / 180);
            return Math.Round(c, 5);
        }
        public double tan(double b)
        {

            double c;
            if (a == double.PositiveInfinity || a == double.NegativeInfinity)
            {
                MessageBox.Show("Не существует!Совет: Введите корректное значение");
                c = 0;
            }
            else
            if (a < 0)
            {
                if (a % 180 == 0.0) c = 0;
                else
                if ((a % 90 == 0.0) && (a % 180 != 0.0))
                {
                    
                    c = double.NegativeInfinity;
                }
                else
                    c = Math.Tan(Math.PI * a / 180);
            }
            else
                if (a % 180 == 0.0) c = 0;
            else
                if ((a % 90 == 0.0) && (a % 180 != 0.0))
            {
                
                c = double.PositiveInfinity;
            }
            else
                c = Math.Tan(Math.PI * a / 180);

            return Math.Round(c, 5);
        }
        public double ctan(double b)
        {
            double c;
            if (a == double.PositiveInfinity || a == double.NegativeInfinity)
            {
                MessageBox.Show("Не существует! Совет: Введите корректное значение");
                c = 0;
            }
            else
            if (a < 0)
            {
                if (a % 180 == 0.0) c = double.NegativeInfinity;
                else
                if ((a % 180 == 0.0) && (a % 90 != 0.0))
                {

                    c = 0;
                }
                else
                    c = 1/Math.Tan(Math.PI * a / 180);
            }
            else
                if (a % 90 == 0.0) c = double.PositiveInfinity;
            else
                if ((a % 180 == 0.0) && (a % 90 != 0.0))
            {

                c = 0;
            }
            else
                c = 1/Math.Tan(Math.PI * a / 180);

            return Math.Round(c, 5);
        }
        public double sec(double b)
        {
            double c;
            if (a == double.PositiveInfinity || a == double.NegativeInfinity)
            {
                MessageBox.Show("Не существует! Совет: Введите корректное значение угла");
                c = 0;
            }
            else
            if ((a % 90 == 0.0) && (a % 180 != 0.0))
            {
                c = double.PositiveInfinity;
            }
            else c = 1 / Math.Cos(Math.PI * a / 180);
            return Math.Round(c, 5);
        }
        public double cosec(double b)
        {
            double c;
            if (a == double.PositiveInfinity || a == double.NegativeInfinity)
            {
                MessageBox.Show("Не существует!Совет: Введите корректное значение");
                c = 0;
            }
            else
            if (a % 180 == 0.0)
            {
                c = double.PositiveInfinity;
            }
            else c = 1 / Math.Sin(Math.PI * a / 180);
            return Math.Round(c, 5);
        }
    }
}
