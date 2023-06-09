using System;
using System.Linq;
using System.Windows.Forms;
using Tech.CodeGeneration;

namespace Sintax_Analizator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private char[] Get_char_symbols(string input_str)
        {
            char[] output_symbols = input_str.ToCharArray();
            return output_symbols;
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            string[] str = { "x", "y", "z" };
            // скрыть/показать кнопки
            btn_repeat.Visible = true;
            btn_clear.Visible = true;
            btn_calc.Visible = false;
            txb_function.ReadOnly = true;
            txb_start_point.ReadOnly = true;
            rtxb_grad.ReadOnly = true;

            double EPS = 0.1; //точность

            string[] a = txb_start_point.Text.Split(',');  // массив из координат начальной точки 

            double[] A = new double[a.Length]; // массив чисел координат начальной точки
            double[] x0 = new double[A.Length];
            double[] x1 = new double[A.Length];
            // заполнение массива координатами
            for (int i = 0; i < a.Length; i++)
            {
                A[i] = Convert.ToInt32(a[i]);
            }

            for (int i = 0; i < A.Length; i++)
            {
                x0[i] = i+2;
            }

            for (int i = 0; i < A.Length; i++)
            {
                x1[i] = 1;
            }
            // градиент
            string grad = rtxb_grad.Text; // получение всеъ частных производных
            string[] grad_array = grad.Split(';'); // получили массив частных производных

            double[] lin_form = new double[A.Length];
            double f1 = 1, f2 = 0;

            // ГЛАВНЫЙ ЦИКЛ МЕТОДА
            int y = 1;
            while (Math.Abs(f1 - f2) >= EPS)
            {

                for (int i = 0; i < grad_array.Length; i++)
                {
                    lin_form[i] = value_grad(grad_array[i], x1);
                }

                //  СОСТАВЛЕНИЕ строки линеаризированной формы

                string lin = "";
                for (int i = 0; i < lin_form.Length; i++)
                {
                    if (lin_form[i] < 0)
                    {
                        lin += lin_form[i].ToString() + "*" + str[i];
                        i++;
                    }
                    if (lin_form[i] >= 0 && i != 0)
                        lin += "+" + lin_form[i].ToString() + "*" + str[i];
                    else
                        lin += lin_form[i].ToString() + "*" + str[i];
                }

                double[] x_lin = new double[x1.Length];//  массив с присвоенными коэф. (большему == меньший из перестановки)
                double[] x_lin_temp = new double[x1.Length];

                // SORT
                for (int i = 0; i < x_lin.Length; i++)
                    x_lin_temp[i] = lin_form[i];
                Array.Sort(x_lin_temp);
                Array.Sort(A);
                Array.Reverse(x_lin_temp);

                int[] ind = new int[x_lin_temp.Length];


                for (int i = 0; i < lin_form.Length; i++)
                { for (int j = 0; j < x_lin_temp.Length; j++)
                    {
                        if (x_lin_temp[j] == lin_form[i])
                            ind[i] = j;
                    }
                }

                for (int i = 0; i < x_lin.Length; i++)
                {
                    x_lin[i] = A[ind[i]];
                }
                // ИТЕРАЦИЯ
                for (int i = 0; i < x1.Length; i++)
                {
                    x1[i] = x0[i] - Math.Pow(0.5, y) * x_lin[i];

                }

                f1 = Function(txb_function.Text, x0);
                f2 = Function(txb_function.Text, x1);

                if (f2 > f1)
                    y++;
                else
                {
                    for (int i = 0; i < x0.Length; i++)
                    {
                        x0[i] = x1[i];

                    }
                }

            } /// WHILE


            /*char[] output_symbols=txb_function.Text.ToLower().ToCharArray();

            char t = (char)122;
            int q = (int)t;
            MessageBox.Show(t.ToString());
            */

            /*

            // разбитие функции
            string str2 = txb_function.Text;
                string[] part = str2.Split('-');
                part = str2.Split('-');
                
            //если не ввели функцию, то завершить работу
            if (txb_function.Text.Any() == false || rtxb_grad.Text.Any() == false)
                    return;

                int[] A = new int[str1.Length];
                for (int i = 0; i < part.Count(); i++)
                {
                    if (part[i] != "")
                        part[i] = "-" + part[i];
                }
                for (int i = 0; i < str1.Length; i++)
                {
                    A[i] = Convert.ToInt32(str1[i]);
                }
                // MessageBox.Show(A[0].ToString()+" "+A[1].ToString());*/
            for (int i=0;i<x1.Length;i++)
            {
                rtxb_res.Text +=str[i]+" = " + x1[i] +";"+ "\n";
            }
        }


        /// Проверяет, является ли строка числом
        /// str Начальная строка
        /// вернет True or False
        static private bool IsNumber(string str)
        {
            try
            {
                double.Parse(str);
            }
            catch
            {
                return false;
            }
            return true;
        }


        private static double value_grad(string sourceCode ,double [] x0)
        {
            try
            {
                sourceCode = string.Format("return " + sourceCode + ";");

                var result2 = CodeGenerator.ExecuteCode<double>(sourceCode,
                CodeParameter.Create("x", x0[0]),
                CodeParameter.Create("y", x0[1]),
                CodeParameter.Create("z", x0[2]));

                //MessageBox.Show(result2.ToString());

                return result2;
            }
            catch
            {
                MessageBox.Show("Ошибка компиляции значение градиента!!!");
                return -1;
            }
        }

        private static double Function(string sourceCode,double [] array)
        {
            try
            {
                sourceCode = string.Format("return " + sourceCode + ";");

                var result2 = CodeGenerator.ExecuteCode<double>(sourceCode,
                CodeParameter.Create("x", array[0]),
                CodeParameter.Create("y", array[1]),
                CodeParameter.Create("z", array[2]));

                //MessageBox.Show(result2.ToString());

                return result2;
            }
            catch
            {
                MessageBox.Show("Ошибка компиляции функции!!!");
                return -1;
            }
        }

        //кнопка очистить ВСЕ поля
        private void txb_clear_Click(object sender, EventArgs e)
        {
            btn_calc.Visible = true;
            btn_repeat.Visible = false;
            btn_clear.Visible = false;
            rtxb_grad.ReadOnly = false;
            txb_function.ReadOnly = false;
            rtxb_grad.Text = "";
            txb_function.Text = "";
            txb_start_point.Text = "";
        }
        // кнопка разблокировки полей для изменения вводимых данных
        private void btn_cont_Click(object sender, EventArgs e)
        {
            txb_function.ReadOnly = false;
            rtxb_grad.ReadOnly = false;
            txb_start_point.ReadOnly = false;
            btn_calc.Visible = true;
            rtxb_res.Text = "";
        }
    }
}