namespace aplicacion
{
    partial class cpu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.PRAM = new System.Diagnostics.PerformanceCounter();
            this.PCPU = new System.Diagnostics.PerformanceCounter();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbRAM = new MetroFramework.Controls.MetroLabel();
            this.lbCPU = new MetroFramework.Controls.MetroLabel();
            this.listRAM = new System.Windows.Forms.ListBox();
            this.PDISCO = new System.Diagnostics.PerformanceCounter();
            this.lbDISCO = new System.Windows.Forms.Label();
            this.PRED = new System.Diagnostics.PerformanceCounter();
            this.lbRED = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.PANCPU2 = new System.Windows.Forms.Panel();
            this.PANRAM = new System.Windows.Forms.Panel();
            this.PANMEMORIA = new System.Windows.Forms.Panel();
            this.PANRED = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.listRED = new System.Windows.Forms.ListView();
            this.chRED2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listDISCO = new System.Windows.Forms.ListView();
            this.chMEMORIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chRAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listCPU2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btcerrar = new System.Windows.Forms.Button();
            this.chCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picram = new System.Windows.Forms.PictureBox();
            this.picred = new System.Windows.Forms.PictureBox();
            this.piccpu = new System.Windows.Forms.PictureBox();
            this.datos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDISCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRED)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.PANCPU2.SuspendLayout();
            this.PANRAM.SuspendLayout();
            this.PANMEMORIA.SuspendLayout();
            this.PANRED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chRED2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chMEMORIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccpu)).BeginInit();
            this.SuspendLayout();
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Procesador";
            this.performanceCounter1.CounterName = "% de tiempo de procesador";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // PRAM
            // 
            this.PRAM.CategoryName = "Memoria";
            this.PRAM.CounterName = "% de bytes confirmados en uso";
            // 
            // PCPU
            // 
            this.PCPU.CategoryName = "Procesador";
            this.PCPU.CounterName = "% de tiempo de procesador";
            this.PCPU.InstanceName = "_Total";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbRAM
            // 
            this.lbRAM.AutoSize = true;
            this.lbRAM.BackColor = System.Drawing.Color.Transparent;
            this.lbRAM.Location = new System.Drawing.Point(461, 38);
            this.lbRAM.Name = "lbRAM";
            this.lbRAM.Size = new System.Drawing.Size(31, 19);
            this.lbRAM.TabIndex = 7;
            this.lbRAM.Text = "0 %";
            // 
            // lbCPU
            // 
            this.lbCPU.AutoSize = true;
            this.lbCPU.BackColor = System.Drawing.Color.Transparent;
            this.lbCPU.Location = new System.Drawing.Point(461, 38);
            this.lbCPU.Name = "lbCPU";
            this.lbCPU.Size = new System.Drawing.Size(31, 19);
            this.lbCPU.TabIndex = 6;
            this.lbCPU.Text = "0 %";
            // 
            // listRAM
            // 
            this.listRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRAM.ForeColor = System.Drawing.Color.RoyalBlue;
            this.listRAM.FormattingEnabled = true;
            this.listRAM.ItemHeight = 20;
            this.listRAM.Location = new System.Drawing.Point(22, 325);
            this.listRAM.Name = "listRAM";
            this.listRAM.Size = new System.Drawing.Size(443, 204);
            this.listRAM.TabIndex = 9;
            // 
            // PDISCO
            // 
            this.PDISCO.CategoryName = "Disco físico";
            this.PDISCO.CounterName = "% de tiempo de disco";
            this.PDISCO.InstanceName = "_Total";
            // 
            // lbDISCO
            // 
            this.lbDISCO.AutoSize = true;
            this.lbDISCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDISCO.Location = new System.Drawing.Point(463, 41);
            this.lbDISCO.Name = "lbDISCO";
            this.lbDISCO.Size = new System.Drawing.Size(29, 16);
            this.lbDISCO.TabIndex = 10;
            this.lbDISCO.Text = "0 %";
            // 
            // PRED
            // 
            this.PRED.CategoryName = "Proceso";
            this.PRED.CounterName = "% de tiempo de usuario";
            this.PRED.InstanceName = "chrome";
            // 
            // lbRED
            // 
            this.lbRED.AutoSize = true;
            this.lbRED.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRED.ForeColor = System.Drawing.Color.Black;
            this.lbRED.Location = new System.Drawing.Point(460, 45);
            this.lbRED.Name = "lbRED";
            this.lbRED.Size = new System.Drawing.Size(29, 16);
            this.lbRED.TabIndex = 11;
            this.lbRED.Text = "0 %";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 37);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::aplicacion.Properties.Resources.cerrar;
            this.pictureBox5.Location = new System.Drawing.Point(940, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLabel3.Location = new System.Drawing.Point(305, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.TabIndex = 20;
            // 
            // PANCPU2
            // 
            this.PANCPU2.Controls.Add(this.PANRAM);
            this.PANCPU2.Controls.Add(this.listCPU2);
            this.PANCPU2.Controls.Add(this.label1);
            this.PANCPU2.Controls.Add(this.btcerrar);
            this.PANCPU2.Controls.Add(this.chCPU);
            this.PANCPU2.Controls.Add(this.lbCPU);
            this.PANCPU2.Location = new System.Drawing.Point(405, 37);
            this.PANCPU2.Name = "PANCPU2";
            this.PANCPU2.Size = new System.Drawing.Size(568, 624);
            this.PANCPU2.TabIndex = 24;
            this.PANCPU2.Visible = false;
            // 
            // PANRAM
            // 
            this.PANRAM.Controls.Add(this.PANMEMORIA);
            this.PANRAM.Controls.Add(this.label2);
            this.PANRAM.Controls.Add(this.button1);
            this.PANRAM.Controls.Add(this.listRAM);
            this.PANRAM.Controls.Add(this.chRAM);
            this.PANRAM.Controls.Add(this.lbRAM);
            this.PANRAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANRAM.Location = new System.Drawing.Point(0, 0);
            this.PANRAM.Name = "PANRAM";
            this.PANRAM.Size = new System.Drawing.Size(568, 624);
            this.PANRAM.TabIndex = 1;
            this.PANRAM.Visible = false;
            // 
            // PANMEMORIA
            // 
            this.PANMEMORIA.Controls.Add(this.PANRED);
            this.PANMEMORIA.Controls.Add(this.label3);
            this.PANMEMORIA.Controls.Add(this.button2);
            this.PANMEMORIA.Controls.Add(this.listDISCO);
            this.PANMEMORIA.Controls.Add(this.lbDISCO);
            this.PANMEMORIA.Controls.Add(this.chMEMORIA);
            this.PANMEMORIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANMEMORIA.Location = new System.Drawing.Point(0, 0);
            this.PANMEMORIA.Name = "PANMEMORIA";
            this.PANMEMORIA.Size = new System.Drawing.Size(568, 624);
            this.PANMEMORIA.TabIndex = 12;
            this.PANMEMORIA.Visible = false;
            // 
            // PANRED
            // 
            this.PANRED.Controls.Add(this.label4);
            this.PANRED.Controls.Add(this.button3);
            this.PANRED.Controls.Add(this.listRED);
            this.PANRED.Controls.Add(this.chRED2);
            this.PANRED.Controls.Add(this.lbRED);
            this.PANRED.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANRED.Location = new System.Drawing.Point(0, 0);
            this.PANRED.Name = "PANRED";
            this.PANRED.Size = new System.Drawing.Size(568, 624);
            this.PANRED.TabIndex = 8;
            this.PANRED.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(406, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Porcentaje de Uso";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button3.Location = new System.Drawing.Point(481, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listRED
            // 
            this.listRED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRED.ForeColor = System.Drawing.Color.RoyalBlue;
            this.listRED.HideSelection = false;
            this.listRED.Location = new System.Drawing.Point(22, 325);
            this.listRED.Name = "listRED";
            this.listRED.Size = new System.Drawing.Size(443, 204);
            this.listRED.TabIndex = 12;
            this.listRED.UseCompatibleStateImageBehavior = false;
            // 
            // chRED2
            // 
            chartArea5.Name = "ChartArea1";
            this.chRED2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chRED2.Legends.Add(legend5);
            this.chRED2.Location = new System.Drawing.Point(22, 19);
            this.chRED2.Name = "chRED2";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "RED";
            this.chRED2.Series.Add(series5);
            this.chRED2.Size = new System.Drawing.Size(355, 300);
            this.chRED2.TabIndex = 0;
            this.chRED2.Text = "chart2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(409, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Porcentaje de Uso";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(481, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listDISCO
            // 
            this.listDISCO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.datos});
            this.listDISCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDISCO.ForeColor = System.Drawing.Color.RoyalBlue;
            this.listDISCO.HideSelection = false;
            this.listDISCO.Location = new System.Drawing.Point(22, 325);
            this.listDISCO.Name = "listDISCO";
            this.listDISCO.Size = new System.Drawing.Size(443, 204);
            this.listDISCO.TabIndex = 11;
            this.listDISCO.UseCompatibleStateImageBehavior = false;
            // 
            // chMEMORIA
            // 
            chartArea6.Name = "ChartArea1";
            this.chMEMORIA.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chMEMORIA.Legends.Add(legend6);
            this.chMEMORIA.Location = new System.Drawing.Point(22, 19);
            this.chMEMORIA.Name = "chMEMORIA";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "DISCO";
            this.chMEMORIA.Series.Add(series6);
            this.chMEMORIA.Size = new System.Drawing.Size(355, 300);
            this.chMEMORIA.TabIndex = 0;
            this.chMEMORIA.Text = "DISCO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(409, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Porcentaje de Uso";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(471, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chRAM
            // 
            chartArea7.Name = "ChartArea1";
            this.chRAM.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chRAM.Legends.Add(legend7);
            this.chRAM.Location = new System.Drawing.Point(22, 19);
            this.chRAM.Name = "chRAM";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "RAM";
            this.chRAM.Series.Add(series7);
            this.chRAM.Size = new System.Drawing.Size(355, 300);
            this.chRAM.TabIndex = 0;
            this.chRAM.Text = "RAM";
            // 
            // listCPU2
            // 
            this.listCPU2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCPU2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.listCPU2.FormattingEnabled = true;
            this.listCPU2.ItemHeight = 20;
            this.listCPU2.Location = new System.Drawing.Point(22, 325);
            this.listCPU2.Name = "listCPU2";
            this.listCPU2.Size = new System.Drawing.Size(443, 204);
            this.listCPU2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(409, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Porcentaje de Uso";
            // 
            // btcerrar
            // 
            this.btcerrar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btcerrar.Location = new System.Drawing.Point(471, 506);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(75, 23);
            this.btcerrar.TabIndex = 7;
            this.btcerrar.Text = "Cerrar";
            this.btcerrar.UseVisualStyleBackColor = true;
            this.btcerrar.Click += new System.EventHandler(this.btcerrar_Click);
            // 
            // chCPU
            // 
            chartArea8.Name = "ChartArea1";
            this.chCPU.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chCPU.Legends.Add(legend8);
            this.chCPU.Location = new System.Drawing.Point(22, 19);
            this.chCPU.Name = "chCPU";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "CPU";
            this.chCPU.Series.Add(series8);
            this.chCPU.Size = new System.Drawing.Size(355, 300);
            this.chCPU.TabIndex = 0;
            this.chCPU.Text = "CPU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::aplicacion.Properties.Resources.memoria241;
            this.pictureBox1.Location = new System.Drawing.Point(25, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picram
            // 
            this.picram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picram.Image = global::aplicacion.Properties.Resources.ram2;
            this.picram.Location = new System.Drawing.Point(25, 142);
            this.picram.Name = "picram";
            this.picram.Size = new System.Drawing.Size(285, 77);
            this.picram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picram.TabIndex = 22;
            this.picram.TabStop = false;
            this.picram.Click += new System.EventHandler(this.picram_Click);
            // 
            // picred
            // 
            this.picred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picred.Image = global::aplicacion.Properties.Resources.red3;
            this.picred.Location = new System.Drawing.Point(25, 308);
            this.picred.Name = "picred";
            this.picred.Size = new System.Drawing.Size(285, 77);
            this.picred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picred.TabIndex = 23;
            this.picred.TabStop = false;
            this.picred.Click += new System.EventHandler(this.picred_Click);
            // 
            // piccpu
            // 
            this.piccpu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piccpu.Image = global::aplicacion.Properties.Resources.cpu2;
            this.piccpu.Location = new System.Drawing.Point(25, 56);
            this.piccpu.Name = "piccpu";
            this.piccpu.Size = new System.Drawing.Size(285, 77);
            this.piccpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccpu.TabIndex = 21;
            this.piccpu.TabStop = false;
            this.piccpu.Click += new System.EventHandler(this.piccpu_Click);
            // 
            // cpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(973, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PANCPU2);
            this.Controls.Add(this.picram);
            this.Controls.Add(this.picred);
            this.Controls.Add(this.piccpu);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cpu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cpu";
            this.Load += new System.EventHandler(this.cpu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDISCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRED)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.PANCPU2.ResumeLayout(false);
            this.PANCPU2.PerformLayout();
            this.PANRAM.ResumeLayout(false);
            this.PANRAM.PerformLayout();
            this.PANMEMORIA.ResumeLayout(false);
            this.PANMEMORIA.PerformLayout();
            this.PANRED.ResumeLayout(false);
            this.PANRED.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chRED2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chMEMORIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Diagnostics.PerformanceCounter PRAM;
        private System.Diagnostics.PerformanceCounter PCPU;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroLabel lbRAM;
        private MetroFramework.Controls.MetroLabel lbCPU;
        private System.Windows.Forms.ListBox listRAM;
        private System.Diagnostics.PerformanceCounter PDISCO;
        private System.Windows.Forms.Label lbDISCO;
        private System.Diagnostics.PerformanceCounter PRED;
        private System.Windows.Forms.Label lbRED;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox piccpu;
        private System.Windows.Forms.PictureBox picram;
        private System.Windows.Forms.PictureBox picred;
        private System.Windows.Forms.Panel PANCPU2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chCPU;
        private System.Windows.Forms.Panel PANRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chRAM;
        private System.Windows.Forms.Panel PANRED;
        private System.Windows.Forms.DataVisualization.Charting.Chart chMEMORIA;
        private System.Windows.Forms.Button btcerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chRED2;
        private System.Windows.Forms.Panel PANMEMORIA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listCPU2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listDISCO;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listRED;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader datos;
    }
}