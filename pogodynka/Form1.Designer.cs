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
            pictureBoxIcon = new PictureBox();
            textBoxMaxTemperature = new TextBox();
            label = new Label();
            textBoxPredkoscWiatru = new TextBox();
            labelWiatr = new Label();
            buttonSprawdz = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
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
            groupBox1.Controls.Add(pictureBoxIcon);
            groupBox1.Controls.Add(textBoxMaxTemperature);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(textBoxPredkoscWiatru);
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
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(318, 93);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(182, 114);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxIcon.TabIndex = 13;
            pictureBoxIcon.TabStop = false;
            // 
            // textBoxMaxTemperature
            // 
            textBoxMaxTemperature.Location = new Point(189, 145);
            textBoxMaxTemperature.Name = "textBoxMaxTemperature";
            textBoxMaxTemperature.Size = new Size(100, 23);
            textBoxMaxTemperature.TabIndex = 14;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(170, 127);
            label.Name = "label";
            label.Size = new Size(142, 15);
            label.TabIndex = 13;
            label.Text = "maksymalna temperatura";
            // 
            // textBoxPredkoscWiatru
            // 
            textBoxPredkoscWiatru.Location = new Point(36, 145);
            textBoxPredkoscWiatru.Name = "textBoxPredkoscWiatru";
            textBoxPredkoscWiatru.Size = new Size(100, 23);
            textBoxPredkoscWiatru.TabIndex = 12;
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
            buttonSprawdz.Click += buttonSprawdz_Click;
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
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
        private Label label8;
        private TextBox textBoxUVIndex;
        private Label labelUv;
        private TextBox textBoxPredkoscWiatru;
        private Label labelWiatr;
        private Button buttonSprawdz;
        private TextBox textBoxMaxTemperature;
        private Label label;
        private PictureBox pictureBoxIcon;
    }
}
