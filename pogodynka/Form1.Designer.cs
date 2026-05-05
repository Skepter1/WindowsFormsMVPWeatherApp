namespace pogodynka
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
            textBoxNazwaMiasta = new TextBox();
            nazwaMiasta = new Label();
            comboBoxStolica = new ComboBox();
            stolica = new Label();
            label3 = new Label();
            textBoxTemperatura = new TextBox();
            textBoxCisnienie = new TextBox();
            textBoxWilgotnosc = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            labelUv = new Label();
            textBox5 = new TextBox();
            labelWiatr = new Label();
            buttonSprawdz = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxNazwaMiasta
            // 
            textBoxNazwaMiasta.Location = new Point(129, 84);
            textBoxNazwaMiasta.Name = "textBoxNazwaMiasta";
            textBoxNazwaMiasta.Size = new Size(155, 23);
            textBoxNazwaMiasta.TabIndex = 0;
            // 
            // nazwaMiasta
            // 
            nazwaMiasta.AutoSize = true;
            nazwaMiasta.Location = new Point(43, 87);
            nazwaMiasta.Name = "nazwaMiasta";
            nazwaMiasta.Size = new Size(80, 15);
            nazwaMiasta.TabIndex = 2;
            nazwaMiasta.Text = "Nazwa miasta";
            // 
            // comboBoxStolica
            // 
            comboBoxStolica.FormattingEnabled = true;
            comboBoxStolica.Location = new Point(399, 84);
            comboBoxStolica.Name = "comboBoxStolica";
            comboBoxStolica.Size = new Size(155, 23);
            comboBoxStolica.TabIndex = 3;
            // 
            // stolica
            // 
            stolica.AutoSize = true;
            stolica.Location = new Point(351, 87);
            stolica.Name = "stolica";
            stolica.Size = new Size(42, 15);
            stolica.TabIndex = 4;
            stolica.Text = "Stolica";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 46);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "temperatura";
            // 
            // textBoxTemperatura
            // 
            textBoxTemperatura.Location = new Point(36, 64);
            textBoxTemperatura.Name = "textBoxTemperatura";
            textBoxTemperatura.Size = new Size(100, 23);
            textBoxTemperatura.TabIndex = 6;
            // 
            // textBoxCisnienie
            // 
            textBoxCisnienie.Location = new Point(192, 64);
            textBoxCisnienie.Name = "textBoxCisnienie";
            textBoxCisnienie.Size = new Size(100, 23);
            textBoxCisnienie.TabIndex = 7;
            // 
            // textBoxWilgotnosc
            // 
            textBoxWilgotnosc.Location = new Point(363, 64);
            textBoxWilgotnosc.Name = "textBoxWilgotnosc";
            textBoxWilgotnosc.Size = new Size(100, 23);
            textBoxWilgotnosc.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 46);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 9;
            label4.Text = "ciśnienie atmosferyczne";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(380, 46);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 10;
            label5.Text = "wilgotność";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(labelUv);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(labelWiatr);
            groupBox1.Controls.Add(textBoxTemperatura);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxWilgotnosc);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxCisnienie);
            groupBox1.Location = new Point(43, 196);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 213);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacje o pogodzie";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(356, 145);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(389, 127);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 15;
            label8.Text = "label8";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(189, 145);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 14;
            // 
            // labelUv
            // 
            labelUv.AutoSize = true;
            labelUv.Location = new Point(208, 127);
            labelUv.Name = "labelUv";
            labelUv.Size = new Size(54, 15);
            labelUv.TabIndex = 13;
            labelUv.Text = "UV Index";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(36, 145);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 12;
            // 
            // labelWiatr
            // 
            labelWiatr.AutoSize = true;
            labelWiatr.Location = new Point(69, 127);
            labelWiatr.Name = "labelWiatr";
            labelWiatr.Size = new Size(33, 15);
            labelWiatr.TabIndex = 11;
            labelWiatr.Text = "wiatr";
            // 
            // buttonSprawdz
            // 
            buttonSprawdz.Location = new Point(213, 158);
            buttonSprawdz.Name = "buttonSprawdz";
            buttonSprawdz.Size = new Size(155, 23);
            buttonSprawdz.TabIndex = 12;
            buttonSprawdz.Text = "Sprawdź pogodę";
            buttonSprawdz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSprawdz);
            Controls.Add(groupBox1);
            Controls.Add(stolica);
            Controls.Add(comboBoxStolica);
            Controls.Add(nazwaMiasta);
            Controls.Add(textBoxNazwaMiasta);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNazwaMiasta;
        private Label nazwaMiasta;
        private ComboBox comboBoxStolica;
        private Label stolica;
        private Label label3;
        private TextBox textBoxTemperatura;
        private TextBox textBoxCisnienie;
        private TextBox textBoxWilgotnosc;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox6;
        private Label labelUv;
        private TextBox textBox5;
        private Label labelWiatr;
        private Button buttonSprawdz;
    }
}
