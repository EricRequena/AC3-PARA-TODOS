namespace AC3___Eric_Requena_Jiménez
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Gestioner = new Label();
            Year = new Label();
            Comarca = new Label();
            Poblation = new Label();
            AnyText = new ComboBox();
            ComarcaText = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            PoblacióText = new TextBox();
            ConsumText = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TotalText = new TextBox();
            ActivitatsText = new TextBox();
            DomésticText = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            LBLPoblacio = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            Cuadro = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Cuadro).BeginInit();
            SuspendLayout();
            // 
            // Gestioner
            // 
            Gestioner.AutoSize = true;
            Gestioner.Location = new Point(22, 38);
            Gestioner.Name = "Gestioner";
            Gestioner.Size = new Size(231, 15);
            Gestioner.TabIndex = 0;
            Gestioner.Text = "Gestió de dades demogràfiques de regions";
            Gestioner.Click += Gestio_Click;
            // 
            // Year
            // 
            Year.AutoSize = true;
            Year.Location = new Point(26, 31);
            Year.Name = "Year";
            Year.Size = new Size(28, 15);
            Year.TabIndex = 1;
            Year.Text = "Any\r\n";
            Year.Click += Year_Click;
            // 
            // Comarca
            // 
            Comarca.AutoSize = true;
            Comarca.Location = new Point(184, 31);
            Comarca.Name = "Comarca";
            Comarca.Size = new Size(55, 15);
            Comarca.TabIndex = 2;
            Comarca.Text = "Comarca";
            // 
            // Poblation
            // 
            Poblation.AutoSize = true;
            Poblation.Location = new Point(384, 111);
            Poblation.Name = "Poblation";
            Poblation.Size = new Size(60, 15);
            Poblation.TabIndex = 3;
            Poblation.Text = "Población";
            // 
            // AnyText
            // 
            AnyText.FormattingEnabled = true;
            AnyText.Items.AddRange(new object[] { "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050" });
            AnyText.Location = new Point(26, 49);
            AnyText.Name = "AnyText";
            AnyText.Size = new Size(121, 23);
            AnyText.TabIndex = 4;
            // 
            // ComarcaText
            // 
            ComarcaText.FormattingEnabled = true;
            ComarcaText.Location = new Point(184, 49);
            ComarcaText.Name = "ComarcaText";
            ComarcaText.Size = new Size(121, 23);
            ComarcaText.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 85);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 7;
            label1.Text = "Domèstic xarxa";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PoblacióText);
            groupBox1.Controls.Add(ConsumText);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TotalText);
            groupBox1.Controls.Add(ComarcaText);
            groupBox1.Controls.Add(Comarca);
            groupBox1.Controls.Add(ActivitatsText);
            groupBox1.Controls.Add(AnyText);
            groupBox1.Controls.Add(DomésticText);
            groupBox1.Controls.Add(Year);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(512, 229);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestió de dades demogràfiques de regions";
            groupBox1.UseCompatibleTextRendering = true;
            // 
            // PoblacióText
            // 
            PoblacióText.Location = new Point(372, 50);
            PoblacióText.Name = "PoblacióText";
            PoblacióText.Size = new Size(118, 23);
            PoblacióText.TabIndex = 15;
            // 
            // ConsumText
            // 
            ConsumText.Location = new Point(400, 116);
            ConsumText.Name = "ConsumText";
            ConsumText.Size = new Size(100, 23);
            ConsumText.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 152);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 14;
            label4.Text = "Total\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 99);
            label3.Name = "label3";
            label3.Size = new Size(104, 30);
            label3.TabIndex = 13;
            label3.Text = "Consum domèstic\r\nper càpita\r\n";
            // 
            // TotalText
            // 
            TotalText.Location = new Point(400, 152);
            TotalText.Name = "TotalText";
            TotalText.Size = new Size(100, 23);
            TotalText.TabIndex = 12;
            // 
            // ActivitatsText
            // 
            ActivitatsText.Location = new Point(184, 119);
            ActivitatsText.Name = "ActivitatsText";
            ActivitatsText.Size = new Size(100, 23);
            ActivitatsText.TabIndex = 10;
            // 
            // DomésticText
            // 
            DomésticText.Location = new Point(26, 119);
            DomésticText.Name = "DomésticText";
            DomésticText.Size = new Size(100, 23);
            DomésticText.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 85);
            label2.Name = "label2";
            label2.Size = new Size(131, 30);
            label2.TabIndex = 8;
            label2.Text = "Activitats econòmiques\r\ni fonts pròpies";
            // 
            // button1
            // 
            button1.Location = new Point(465, 332);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(369, 332);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Netejar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(LBLPoblacio);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Location = new Point(530, 87);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(267, 135);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadístiques";
            groupBox2.UseCompatibleTextRendering = true;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.RoyalBlue;
            label14.Location = new Point(223, 112);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 22;
            label14.Text = "label14";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.RoyalBlue;
            label13.Location = new Point(214, 82);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 21;
            label13.Text = "label13";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.RoyalBlue;
            label12.Location = new Point(149, 51);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 20;
            label12.Text = "label12";
            // 
            // LBLPoblacio
            // 
            LBLPoblacio.AutoSize = true;
            LBLPoblacio.ForeColor = Color.RoyalBlue;
            LBLPoblacio.Location = new Point(138, 25);
            LBLPoblacio.Name = "LBLPoblacio";
            LBLPoblacio.Size = new Size(44, 15);
            LBLPoblacio.TabIndex = 19;
            LBLPoblacio.Text = "label11";
            LBLPoblacio.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 113);
            label10.Name = "label10";
            label10.Size = new Size(212, 15);
            label10.TabIndex = 18;
            label10.Text = "Consum domèstic per càpita més baix:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 82);
            label9.Name = "label9";
            label9.Size = new Size(203, 15);
            label9.TabIndex = 17;
            label9.Text = "Consum domèstic per càpita més alt:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 51);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 16;
            label8.Text = "Consum domèstic mitjà:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 25);
            label7.Name = "label7";
            label7.Size = new Size(126, 15);
            label7.TabIndex = 15;
            label7.Text = "Població > 20000 hab.:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(383, 149);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 14;
            label5.Text = "Total\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(358, 92);
            label6.Name = "label6";
            label6.Size = new Size(104, 30);
            label6.TabIndex = 13;
            label6.Text = "Consum domèstic\r\nper càpita\r\n";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(468, 146);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(468, 92);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 11;
            // 
            // Cuadro
            // 
            Cuadro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Cuadro.Location = new Point(22, 382);
            Cuadro.Name = "Cuadro";
            Cuadro.Size = new Size(826, 234);
            Cuadro.TabIndex = 16;
            Cuadro.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 628);
            Controls.Add(Cuadro);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Poblation);
            Controls.Add(Gestioner);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = " ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Cuadro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Gestioner;
        private Label Year;
        private Label Comarca;
        private Label Poblation;
        private ComboBox AnyText;
        private ComboBox ComarcaText;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox ActivitatsText;
        private TextBox DomésticText;
        private Label label4;
        private Label label3;
        private TextBox TotalText;
        private TextBox ConsumText;
        private Button button1;
        private Button button2;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label12;
        private Label LBLPoblacio;
        private Label label14;
        private Label label13;
        private TextBox PoblacióText;
        private DataGridView Cuadro;
    }
}
