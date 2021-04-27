using System;
using System.IO;
using System.Windows.Forms;
using System.Configuration;



namespace lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings == null)
            {
                settings.Add("set", "true");
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            if (settings["set"].Value == "true")
            {
                MessageBox.Show("Вариант №3. Лабораторная работа №3. " + Environment.NewLine + Environment.NewLine +
    "Знакомство с WinFroms. " + Environment.NewLine +
    "Построение графика овала Кассини и вывод таблицы значений функции. " + Environment.NewLine + Environment.NewLine +
    "Студент группы 495, Гнипель Анна Владимировна." + Environment.NewLine + "2021 год", "Информация о проекте", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            chart1.ChartAreas[0].AxisX.Minimum = (double)LeftBorder.Value;
            chart1.ChartAreas[0].AxisX.Maximum = (double)RightBorder.Value;
            chart1.ChartAreas[0].AxisY.Minimum = (double)LowerBorder.Value;
            chart1.ChartAreas[0].AxisY.Maximum = (double)UpperBorder.Value;
            CalcFuncOvalCassini calcFunc = new CalcFuncOvalCassini();
            calcFunc.Calc(-10, 10, -10, 10, 0, 0, 0, 1, 1, 0.01, chart1);
        }

        private void PlotGraph_Click(object sender, EventArgs e)
        {
            double leftBorder = (double)LeftBorder.Value;
            double rightBorder = (double)RightBorder.Value;
            double upperBorder = (double)UpperBorder.Value;
            double lowerBorder = (double)LowerBorder.Value;
            double coefA = (double)CoefA.Value;
            double coefC = (double)CoefC.Value;
            double step = (double)Step.Value;
            double yPlus = 0, yMinus = 0, x = 0;
            bool value;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();

            chart1.ChartAreas[0].AxisX.Minimum = leftBorder;
            chart1.ChartAreas[0].AxisX.Maximum = rightBorder;
            chart1.ChartAreas[0].AxisY.Minimum = lowerBorder;
            chart1.ChartAreas[0].AxisY.Maximum = upperBorder;

            CalcFuncOvalCassini calcFunc = new CalcFuncOvalCassini();
            value = calcFunc.Calc(leftBorder, rightBorder, lowerBorder, upperBorder, x, yPlus, yMinus, coefA, coefC, step, chart1);
            try
            {
                System.IO.File.Delete(@"C:\Users\admin\Desktop\lab3\\chart.jpeg");
            }
            catch
            {

            }
            this.chart1.SaveImage(@"C:\Users\admin\Desktop\lab3\\chart.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);



            if (chart1.Series[0].Points == null || !value)
            {
                SaveTextToolStripMenuItem.Enabled = false;
                OpenTableToolStripMenuItem.Enabled = false;

            }
            else
            {
                SaveTextToolStripMenuItem.Enabled = true;
                OpenTableToolStripMenuItem.Enabled = true;
            }
        }

        private void LeftBorder_ValueChanged(object sender, EventArgs e)
        {
            PlotGraph_Click(sender, e);
        }

        private void RightBorder_ValueChanged(object sender, EventArgs e)
        {
            PlotGraph_Click(sender, e);
        }

        private void UpperBorder_ValueChanged(object sender, EventArgs e)
        {
            PlotGraph_Click(sender, e);
        }

        private void LowerBorder_ValueChanged(object sender, EventArgs e)
        {
            PlotGraph_Click(sender, e);
        }

        private void CoefA_ValueChanged(object sender, EventArgs e)
        {
            PlotGraph_Click(sender, e);
        }

        private void CoefC_ValueChanged(object sender, EventArgs e)
        {
            PlotGraph_Click(sender, e);
        }

        private void Step_ValueChanged(object sender, EventArgs e)
        {
            if ((double)Step.Value == 0 || (double)Step.Value < 0)
            {
                MessageBox.Show("Измените значение шага. Оно должно быть положительным");
            }
            else
            {
                PlotGraph_Click(sender, e);
            }
        }

        private void OpenTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текстовый файл должен содержать строку из вещественных чисел. Она должна содержать 7 элементов." + Environment.NewLine
                + "Первое число - левая граница" + Environment.NewLine
                + "Второе число - правая граница" + Environment.NewLine
                + "Третье число - верхняя граница" + Environment.NewLine
                + "Четвертое число - нижняя граница" + Environment.NewLine
                + "Пятое число - коэффициант а" + Environment.NewLine
                + "Шестое число - коэффициент с" + Environment.NewLine
                + "Седьмое число - шаг", "Информация о вводе текстового файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var fileContent = string.Empty; // string.Empty - пустая строка (не может употреблять в качестве параметра функции)
            decimal[] value = new decimal[7];
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                /// <summary>
                /// считывание содержимого файла в поток
                /// </summary>

                var fileStream = openFileDialog1.OpenFile();

                /// <summary>
                /// StreamReader - класс для считывания текста из файла
                /// </summary>

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                    fileContent.Trim();
                    string[] mas = fileContent.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    if (mas.Length == 7)
                    {
                            for (int i = 0; i < 7; i++)
                                try
                                {
                                    {
                                        value[i] = Convert.ToDecimal(mas[i]);
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Введите корректные данные в текстовом файле", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                                }
                    }
                    else
                    {
                        MessageBox.Show("Введите корректные данные в текстовом файле", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LeftBorder.Value = Convert.ToDecimal(mas[0]);
                    RightBorder.Value = Convert.ToDecimal(mas[1]);
                    UpperBorder.Value = Convert.ToDecimal(mas[2]);
                    LowerBorder.Value = Convert.ToDecimal(mas[3]);
                    CoefA.Value = Convert.ToDecimal(mas[4]);
                    CoefC.Value = Convert.ToDecimal(mas[5]);
                    Step.Value = Convert.ToDecimal(mas[6]);
                    PlotGraph_Click(sender, e);
                }
            }
        }

        private void SaveTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(LeftBorder.Value + " " + RightBorder.Value + " " + UpperBorder.Value + " " + LowerBorder.Value + " " + CoefA.Value + " " + CoefC.Value + " " + Step.Value);
                streamWriter.Close();
            }
        }

        private void OpenTableToolStripMenuItem_Click(object sender, EventArgs e)
        {


            CalcFuncOvalCassini.tab.Show();
        }

        private void инфомацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вариант №3. Лабораторная работа №3. " + Environment.NewLine + Environment.NewLine +
    "Знакомство с WinFroms. " + Environment.NewLine +
    "Построение графика овала Кассини и вывод таблицы значений функции. " + Environment.NewLine + Environment.NewLine +
    "Студент группы 495, Гнипель Анна Владимировна." + Environment.NewLine + "2021 год", "Информация о проекте", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CheckToolStrip_Click(object sender, EventArgs e)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (CheckToolStrip.Checked) 
            {
                settings["set"].Value = "true";
            }
            else
            {
                settings["set"].Value = "false";
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }
    }
}