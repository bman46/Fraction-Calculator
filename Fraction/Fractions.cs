using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fraction
{
    public class Fractions
    {
        public void FractionConvert(string fraction)
        {
            string[] split = fraction.Split(new char[] { '/' });

            if (split.Length == 2)
            {
                if (double.TryParse(split[0], out double a) && double.TryParse(split[1], out double b))
                {
                    if (split.Length == 2)
                    {
                        Numerator = a;
                        Denominator = b;

                        return;
                    }
                }
            }
            throw new FormatException("Not a valid fraction.");
        }
        public static double Gcd(double a, double b)
        {
            if (a == 0)
            {
                return b;
            }

            return Gcd(b % a, a);
        } 
        public void Simp()
        {
            double common_factor = Gcd(Numerator, Denominator);

            Denominator /= common_factor;
            Numerator /= common_factor;
            if (Numerator < 0 && Math.Abs(Numerator) >= Denominator)
            {
                Numerator += Denominator;
                WholeNumber--;

                Simp();
            }
            if (Numerator >= Denominator)
            {
                Numerator -= Denominator;
                WholeNumber++;

                Simp();
            }
            if(WholeNumber < 0 && Numerator < 0)
            {
                Numerator = Math.Abs(Numerator);
            }
        }
        public double WholeNumber { get; set; }
        public double Numerator { get; set; }
        public double Denominator { get; set; }
    }
}