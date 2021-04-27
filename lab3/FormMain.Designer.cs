namespace lab3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PlotGraph = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Step = new System.Windows.Forms.NumericUpDown();
            this.CoefC = new System.Windows.Forms.NumericUpDown();
            this.CoefA = new System.Windows.Forms.NumericUpDown();
            this.LowerBorder = new System.Windows.Forms.NumericUpDown();
            this.UpperBorder = new System.Windows.Forms.NumericUpDown();
            this.RightBorder = new System.Windows.Forms.NumericUpDown();
            this.LeftBorder = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoAboutProject = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoefC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoefA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(265, 46);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Name = "Series3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(868, 469);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chartOvalCassini";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "График функции овал Кассини";
            this.chart1.Titles.Add(title1);
            // 
            // PlotGraph
            // 
            this.PlotGraph.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlotGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlotGraph.Location = new System.Drawing.Point(12, 353);
            this.PlotGraph.Name = "PlotGraph";
            this.PlotGraph.Size = new System.Drawing.Size(238, 45);
            this.PlotGraph.TabIndex = 1;
            this.PlotGraph.Text = "Построить график";
            this.PlotGraph.UseVisualStyleBackColor = true;
            this.PlotGraph.Click += new System.EventHandler(this.PlotGraph_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Step);
            this.groupBox1.Controls.Add(this.CoefC);
            this.groupBox1.Controls.Add(this.CoefA);
            this.groupBox1.Controls.Add(this.LowerBorder);
            this.groupBox1.Controls.Add(this.UpperBorder);
            this.groupBox1.Controls.Add(this.RightBorder);
            this.groupBox1.Controls.Add(this.LeftBorder);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 280);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // Step
            // 
            this.Step.DecimalPlaces = 2;
            this.Step.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Step.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Step.Location = new System.Drawing.Point(149, 226);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(83, 26);
            this.Step.TabIndex = 8;
            this.Step.Tag = "";
            this.Step.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Step.ValueChanged += new System.EventHandler(this.Step_ValueChanged);
            // 
            // CoefC
            // 
            this.CoefC.DecimalPlaces = 1;
            this.CoefC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoefC.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CoefC.Location = new System.Drawing.Point(149, 194);
            this.CoefC.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.CoefC.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.CoefC.Name = "CoefC";
            this.CoefC.Size = new System.Drawing.Size(83, 26);
            this.CoefC.TabIndex = 8;
            this.CoefC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CoefC.ValueChanged += new System.EventHandler(this.CoefC_ValueChanged);
            // 
            // CoefA
            // 
            this.CoefA.DecimalPlaces = 1;
            this.CoefA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoefA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CoefA.Location = new System.Drawing.Point(149, 162);
            this.CoefA.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.CoefA.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.CoefA.Name = "CoefA";
            this.CoefA.Size = new System.Drawing.Size(83, 26);
            this.CoefA.TabIndex = 8;
            this.CoefA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CoefA.ValueChanged += new System.EventHandler(this.CoefA_ValueChanged);
            // 
            // LowerBorder
            // 
            this.LowerBorder.DecimalPlaces = 1;
            this.LowerBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LowerBorder.Location = new System.Drawing.Point(149, 132);
            this.LowerBorder.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.LowerBorder.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.LowerBorder.Name = "LowerBorder";
            this.LowerBorder.Size = new System.Drawing.Size(83, 26);
            this.LowerBorder.TabIndex = 9;
            this.LowerBorder.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.LowerBorder.ValueChanged += new System.EventHandler(this.LowerBorder_ValueChanged);
            // 
            // UpperBorder
            // 
            this.UpperBorder.DecimalPlaces = 1;
            this.UpperBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpperBorder.Location = new System.Drawing.Point(148, 100);
            this.UpperBorder.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.UpperBorder.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.UpperBorder.Name = "UpperBorder";
            this.UpperBorder.Size = new System.Drawing.Size(83, 26);
            this.UpperBorder.TabIndex = 8;
            this.UpperBorder.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpperBorder.ValueChanged += new System.EventHandler(this.UpperBorder_ValueChanged);
            // 
            // RightBorder
            // 
            this.RightBorder.DecimalPlaces = 1;
            this.RightBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightBorder.Location = new System.Drawing.Point(149, 69);
            this.RightBorder.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.RightBorder.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(83, 26);
            this.RightBorder.TabIndex = 8;
            this.RightBorder.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RightBorder.ValueChanged += new System.EventHandler(this.RightBorder_ValueChanged);
            // 
            // LeftBorder
            // 
            this.LeftBorder.DecimalPlaces = 1;
            this.LeftBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftBorder.Location = new System.Drawing.Point(148, 37);
            this.LeftBorder.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LeftBorder.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.LeftBorder.Name = "LeftBorder";
            this.LeftBorder.Size = new System.Drawing.Size(83, 26);
            this.LeftBorder.TabIndex = 7;
            this.LeftBorder.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.LeftBorder.ValueChanged += new System.EventHandler(this.LeftBorder_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(98, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Шаг:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Коэффициант с:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Коэффициант a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Нижняя граница:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Верхняя граница:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Правая граница:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Левая граница:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem,
            this.AboutProjectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1145, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTextToolStripMenuItem,
            this.SaveTextToolStripMenuItem,
            this.OpenTableToolStripMenuItem});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.MenuToolStripMenuItem.Text = "Меню";
            // 
            // OpenTextToolStripMenuItem
            // 
            this.OpenTextToolStripMenuItem.Name = "OpenTextToolStripMenuItem";
            this.OpenTextToolStripMenuItem.Size = new System.Drawing.Size(317, 30);
            this.OpenTextToolStripMenuItem.Text = "Ввести данные из файла";
            this.OpenTextToolStripMenuItem.Click += new System.EventHandler(this.OpenTextToolStripMenuItem_Click);
            // 
            // SaveTextToolStripMenuItem
            // 
            this.SaveTextToolStripMenuItem.Enabled = false;
            this.SaveTextToolStripMenuItem.Name = "SaveTextToolStripMenuItem";
            this.SaveTextToolStripMenuItem.Size = new System.Drawing.Size(317, 30);
            this.SaveTextToolStripMenuItem.Text = "Сохранить данные в файл";
            this.SaveTextToolStripMenuItem.Click += new System.EventHandler(this.SaveTextToolStripMenuItem_Click);
            // 
            // OpenTableToolStripMenuItem
            // 
            this.OpenTableToolStripMenuItem.Enabled = false;
            this.OpenTableToolStripMenuItem.Name = "OpenTableToolStripMenuItem";
            this.OpenTableToolStripMenuItem.Size = new System.Drawing.Size(317, 30);
            this.OpenTableToolStripMenuItem.Text = "Открыть таблицу значений";
            this.OpenTableToolStripMenuItem.Click += new System.EventHandler(this.OpenTableToolStripMenuItem_Click);
            // 
            // AboutProjectToolStripMenuItem
            // 
            this.AboutProjectToolStripMenuItem.Checked = true;
            this.AboutProjectToolStripMenuItem.CheckOnClick = true;
            this.AboutProjectToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AboutProjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckToolStrip,
            this.InfoAboutProject});
            this.AboutProjectToolStripMenuItem.Name = "AboutProjectToolStripMenuItem";
            this.AboutProjectToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.AboutProjectToolStripMenuItem.Text = "О проекте";
            // 
            // CheckToolStrip
            // 
            this.CheckToolStrip.Checked = true;
            this.CheckToolStrip.CheckOnClick = true;
            this.CheckToolStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckToolStrip.Name = "CheckToolStrip";
            this.CheckToolStrip.Size = new System.Drawing.Size(542, 30);
            this.CheckToolStrip.Text = "Показывать окно информации при открытии проекта";
            this.CheckToolStrip.Click += new System.EventHandler(this.CheckToolStrip_Click);
            // 
            // InfoAboutProject
            // 
            this.InfoAboutProject.Name = "InfoAboutProject";
            this.InfoAboutProject.Size = new System.Drawing.Size(542, 30);
            this.InfoAboutProject.Text = "Информация о проекте";
            this.InfoAboutProject.Click += new System.EventHandler(this.инфомацияToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::lab3.Properties.Resources._1;
            this.pictureBox1.InitialImage = global::lab3.Properties.Resources.Снимок_экрана_2021_04_10_165542;
            this.pictureBox1.Location = new System.Drawing.Point(527, 537);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 67);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PlotGraph);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Построение графика овала Кассини";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoefC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoefA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button PlotGraph;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Step;
        private System.Windows.Forms.NumericUpDown CoefC;
        private System.Windows.Forms.NumericUpDown CoefA;
        private System.Windows.Forms.NumericUpDown LowerBorder;
        private System.Windows.Forms.NumericUpDown UpperBorder;
        private System.Windows.Forms.NumericUpDown RightBorder;
        private System.Windows.Forms.NumericUpDown LeftBorder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProjectToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem CheckToolStrip;
        private System.Windows.Forms.ToolStripMenuItem InfoAboutProject;
    }
}

