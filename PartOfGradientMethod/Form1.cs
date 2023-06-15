using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech.CodeGeneration.PicGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
   
        private void _button_Click(object sender, EventArgs e)
        {
            double[] CoefLin = new double[] { 0,0,0};

            string x = textBox1.Text;
            string y = textBox2.Text;
            string z = textBox3.Text;

            Lin_function_x(ref CoefLin,x);
            Lin_function_x(ref CoefLin,y);
            Lin_function_x(ref CoefLin,z);

            Lin_function_y(ref CoefLin, x);
            Lin_function_y(ref CoefLin, y);
            Lin_function_y(ref CoefLin, z);

            Lin_function_z(ref CoefLin, x);
            Lin_function_z(ref CoefLin, y);
            Lin_function_z(ref CoefLin, z);


            string str = textBox4.Text;
            string[] sub_str = str.Split(',');
            double[] A = new double[sub_str.Length];
            for(int i=0;i<sub_str.Length;i++)
            {
                A[i] = Convert.ToDouble(sub_str[i]);
                
            }
            ArraySort(ref A);

        }

        //// вычисление значения функции
        //private static double Function(string sourceCode, double a, double b, double c)
        //{
        //    try
        //    {
        //        sourceCode = string.Format("return " + sourceCode + ";");
        //        var result2 = CodeGenerator.ExecuteCode<double>(sourceCode,
        //    CodeParameter.Create("x", a),
        //    CodeParameter.Create("y", b),
        //    CodeParameter.Create("z", c));

        //    MessageBox.Show(result2.ToString());

        //        return result2;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Ошибка компиляции!!!");
        //        return -1;
        //    }
            

        //}
    /*    private static double[] Calculate()
        {
            double[] x1 = new double[3];
            double[] x0 = new double[3] { 1,1,1};
            for(int i=0;i<x1.Length;i++)
            {
             //   x1[i]=x0[i]-0,5*x
            }



            return result;
        }
        */
        private static void Lin_function_x(ref double[] CoefLin, string str)
        {
            int k = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'x')
                {
                    if (str[i - 1] == '-')
                    {
                        CoefLin[k] += -1;
                        
                    }
                    else if (str[i - 1] == '+')
                    {
                        CoefLin[k] += 1;
                        
                    }
                    else
                    {
                        CoefLin[k] += double.Parse(Convert.ToString(str[i - 2]));
                     
                    }
                }
               
            }

                
        }
        private static void Lin_function_y(ref double[] CoefLin, string str)
        {
            int k = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'y')
                {
                    if (str[i - 1] == '-')
                    {
                        CoefLin[k] += -1;
                        
                    }
                    else if (str[i - 1] == '+')
                    {
                        CoefLin[k] += 1;
                        
                    }
                    else
                    {
                        CoefLin[k] += double.Parse(Convert.ToString(str[i - 2]));
                      
                    }
                }

            }


        }
        private static void Lin_function_z(ref double[] CoefLin, string str)
        {
            int k = 2;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'z')
                {
                    if (str[i - 1] == '-')
                    {
                        CoefLin[k] += -1;
                       
                    }
                    else if (str[i - 1] == '+')
                    {
                        CoefLin[k] += 1;
                        
                    }
                    else
                    {
                        CoefLin[k] += double.Parse(Convert.ToString(str[i - 2]));
                     
                    }
                }

            }


        }
        private static void ArraySort(ref double[] A)
        {
             Array.Sort(A);
        }
    }
}
// Math.Cos(100 * x *x - 100 * Math.Cos(10*y) * Math.Sin(15 * x))
// Math.Sin(50 * y * y - 50 * x * Math.Sin(5 * y))