using System;

namespace lab3
{
    public class CalcFuncOvalCassini 
    {
        public static Table tab;

        public double CalcY(double coefA, double coefC, double x)
        {
            return Math.Round(Math.Sqrt(Math.Sqrt(Math.Pow(coefA, 4) + (4 * Math.Pow(x, 2) * Math.Pow(coefC, 2))) - Math.Pow(x, 2) - Math.Pow(coefC, 2)), 2);
        }

        public bool Calc(double leftBorder, double rightBorder, double lowerBorder, double upperBorder, double x, double yPlus, double yMinus, double coefA, double coefC, double step, System.Windows.Forms.DataVisualization.Charting.Chart chart1)
        {
            bool value;
             tab = new Table();

            for (x = leftBorder; x < rightBorder; x += step)
            {
                value = true;
                while (value)
                {
                    yPlus = CalcY(coefA, coefC, x);
                    yMinus = -CalcY(coefA, coefC, x);
                    if (double.IsNaN(yPlus) || double.IsNaN(yMinus))
                    {
                        break;
                    }
                    if (coefA == 0 && coefC != 0)
                    {
                        chart1.Series[2].Points.AddXY(x, yPlus);
                       tab.Input(Math.Round(x, 2),Math.Round(yPlus, 2), Math.Round(yMinus, 2));
                        break;

                    }
                    if (0 < coefA && coefA < coefC)
                    {
                        if (x > -coefA && x < coefA)
                        {
                            break;
                        }
                        else
                        {
                            if (x > 0)
                            {
                                chart1.Series[0].Points.AddXY(x, yPlus);
                                chart1.Series[0].Points.AddXY(x, yMinus);
                                tab.Input(Math.Round(x, 2), Math.Round(yPlus, 2), Math.Round(yMinus, 2));
                                break;
                            }
                            else
                            {
                                chart1.Series[1].Points.AddXY(x, yPlus);
                                chart1.Series[1].Points.AddXY(x, yMinus);
                                tab.Input(Math.Round(x, 2), Math.Round(yPlus, 2), Math.Round(yMinus, 2));
                                break;
                            }
                        }
                    }
                    if (!CheckFunc.CoordinateX(leftBorder, rightBorder, x))  return false;
                    if (!CheckFunc.InnerRoot(coefA, coefC, x)) return false;
                    if (!CheckFunc.ExternalRoot(coefA, coefC, x)) return false;
                    if (!CheckFunc.CoordinateY(lowerBorder, upperBorder, yPlus)) return false;
                    if (!CheckFunc.CoordinateY(lowerBorder, upperBorder, yMinus)) return false;

                        chart1.Series[0].Points.AddXY(x, yPlus);
                        chart1.Series[1].Points.AddXY(x, yMinus);
                    tab.Input(Math.Round(x, 2), Math.Round(yPlus, 2), Math.Round(yMinus, 2));
                    value = false;
                }
            }
            return true;
        }
    }
}