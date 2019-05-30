using System;
using System.Web.UI;

namespace Fraction
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            error1.Visible = false;
            error2.Visible = false;
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Fractions frac1 = new Fractions();
                Fractions frac2 = new Fractions();

                try
                {
                    frac1.FractionConvert(Fraction1.Text);
                }
                catch
                {
                    error1.Visible = true;
                    error1.Text = "Not a valid fraction";
                }

                try
                {
                    frac2.FractionConvert(Fraction2.Text);
                }
                catch
                {
                    error2.Visible = true;
                    error2.Text = "Not a valid fraction";
                }
                error1.Visible = false;
                error2.Visible = false;

                Fractions output = new Fractions();

                double gcd = Fractions.Gcd(frac1.Denominator, frac2.Denominator);
                output.Denominator = (frac1.Denominator * frac2.Denominator) / gcd;
                output.Numerator = (frac1.Numerator) * (output.Denominator / frac1.Denominator) + (frac2.Numerator) * (output.Denominator / frac2.Denominator);

                output.Simp();

                if (output.Numerator == 0 && output.WholeNumber != 0)
                {
                    Output.Text = output.WholeNumber + "";
                }
                else if (output.WholeNumber != 0 && output.Numerator != 0)
                {
                    Output.Text = output.WholeNumber + " " + output.Numerator + "/" + output.Denominator;
                }
                else
                {
                    Output.Text = output.Numerator + "/" + output.Denominator;
                }

            }
        }

        protected void Subtract_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Fractions frac1 = new Fractions();
                Fractions frac2 = new Fractions();

                try
                {
                    frac1.FractionConvert(Fraction1.Text);
                }
                catch
                {
                    error1.Visible = true;
                    error1.Text = "Not a valid fraction";
                }

                try
                {
                    frac2.FractionConvert(Fraction2.Text);
                }
                catch
                {
                    error2.Visible = true;
                    error2.Text = "Not a valid fraction";
                }
                error1.Visible = false;
                error2.Visible = false;

                Fractions output = new Fractions();

                double gcd = Fractions.Gcd(frac1.Denominator, frac2.Denominator);
                output.Denominator = (frac1.Denominator * frac2.Denominator) / gcd;
                output.Numerator = (frac1.Numerator) * (output.Denominator / frac1.Denominator) - (frac2.Numerator) * (output.Denominator / frac2.Denominator);

                output.Simp();
                if (output.Numerator == 0 && output.WholeNumber != 0)
                {
                    Output.Text = output.WholeNumber + "";
                }
                else if (output.WholeNumber != 0 && output.Numerator != 0)
                {
                    Output.Text = output.WholeNumber + " " + output.Numerator + "/" + output.Denominator;
                }
                else
                {
                    Output.Text = output.Numerator + "/" + output.Denominator;
                }

            }
        }

        protected void Multiply_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Fractions frac1 = new Fractions();
                Fractions frac2 = new Fractions();

                try
                {
                    frac1.FractionConvert(Fraction1.Text);
                }
                catch
                {
                    error1.Visible = true;
                    error1.Text = "Not a valid fraction";
                }

                try
                {
                    frac2.FractionConvert(Fraction2.Text);
                }
                catch
                {
                    error2.Visible = true;
                    error2.Text = "Not a valid fraction";
                }
                error1.Visible = false;
                error2.Visible = false;

                Fractions output = new Fractions
                {
                    Numerator = frac1.Numerator * frac2.Numerator,
                    Denominator = frac1.Denominator * frac2.Denominator
                };

                output.Simp();
                if (output.Numerator == 0 && output.WholeNumber != 0)
                {
                    Output.Text = output.WholeNumber + "";
                }
                else if (output.WholeNumber != 0 && output.Numerator != 0)
                {
                    Output.Text = output.WholeNumber + " " + output.Numerator + "/" + output.Denominator;
                }
                else
                {
                    Output.Text = output.Numerator + "/" + output.Denominator;
                }
            }
        }

        protected void Divide_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Fractions frac1 = new Fractions();
                Fractions frac2 = new Fractions();

                try
                {
                    frac1.FractionConvert(Fraction1.Text);
                }
                catch
                {
                    error1.Visible = true;
                    error1.Text = "Not a valid fraction";
                }

                try
                {
                    frac2.FractionConvert(Fraction2.Text);
                }
                catch
                {
                    error2.Visible = true;
                    error2.Text = "Not a valid fraction";
                }
                error1.Visible = false;
                error2.Visible = false;

                Fractions output = new Fractions
                {
                    Numerator = frac1.Numerator * frac2.Denominator,
                    Denominator = frac1.Denominator * frac2.Numerator
                };

                output.Simp();

                if (output.Numerator == 0 && output.WholeNumber != 0)
                {
                    Output.Text = output.WholeNumber + "";
                }
                else if (output.WholeNumber != 0 && output.Numerator != 0)
                {
                    Output.Text = output.WholeNumber + " " + output.Numerator + "/" + output.Denominator;
                }
                else
                {
                    Output.Text = output.Numerator + "/" + output.Denominator;
                }
            }
        }

        protected void Power_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Fractions frac1 = new Fractions();
                Fractions frac2 = new Fractions();

                try
                {
                    frac1.FractionConvert(Fraction1.Text);
                }
                catch
                {
                    error1.Visible = true;
                    error1.Text = "Not a valid fraction";
                }

                try
                {
                    frac2.FractionConvert(Fraction2.Text);
                }
                catch
                {
                    error2.Visible = true;
                    error2.Text = "Not a valid fraction";
                }
                error1.Visible = false;
                error2.Visible = false;

                //Output.Text = Math.Pow(frac1.Numerator / frac1.Denominator, frac2.Numerator / frac2.Denominator) + "";
            }
        }
    }
}