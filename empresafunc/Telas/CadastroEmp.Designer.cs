namespace empresafunc.Telas
{
    partial class CadastroEmp
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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            textBox6 = new TextBox();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            comboBox3 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gold;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(168, 96);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Horizontal;
            textBox1.Size = new Size(181, 25);
            textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Gold;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(188, 311);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Horizontal;
            textBox3.Size = new Size(181, 25);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Gold;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(302, 351);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Horizontal;
            textBox4.Size = new Size(181, 25);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Gold;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(572, 179);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ScrollBars = ScrollBars.Horizontal;
            textBox5.Size = new Size(206, 23);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.Gold;
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox1.Location = new Point(598, 226);
            maskedTextBox1.Mask = "000,000,000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(180, 20);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = Color.Gold;
            maskedTextBox2.BorderStyle = BorderStyle.None;
            maskedTextBox2.Location = new Point(145, 262);
            maskedTextBox2.Mask = "(00) 00000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(180, 20);
            maskedTextBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gold;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ativa", "Nula", "Suspensa,", "Inapta", "Baixada" });
            comboBox1.Location = new Point(168, 137);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Gold;
            radioButton1.Location = new Point(145, 179);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 24);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Lucro";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Gold;
            radioButton2.Location = new Point(217, 179);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(59, 24);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Real";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Gold;
            radioButton3.Location = new Point(287, 179);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(82, 24);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "Simples";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Gold;
            dateTimePicker1.Location = new Point(168, 219);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(181, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Gold;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "AC  ", "AL  ", "AM  ", "AP  ", "BA  ", "CE  ", "DF  ", "ES  ", "GO  ", "MA  ", "MG  ", "MS  ", "MT  ", "PA  ", "PB  ", "PE  ", "PI  ", "PR  ", "RJ  ", "RN  ", "RO  ", "RR  ", "RS  ", "SC  ", "SE  ", "SP  ", "TO" });
            comboBox2.Location = new Point(112, 351);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(82, 28);
            comboBox2.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gold;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(95, 397);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Horizontal;
            textBox2.Size = new Size(213, 25);
            textBox2.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Gold;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(436, 397);
            textBox6.Name = "textBox6";
            textBox6.ScrollBars = ScrollBars.Horizontal;
            textBox6.Size = new Size(202, 20);
            textBox6.TabIndex = 15;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Gold;
            radioButton4.Location = new Point(452, 56);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(72, 24);
            radioButton4.TabIndex = 16;
            radioButton4.TabStop = true;
            radioButton4.Text = "Matriz";
            radioButton4.UseVisualStyleBackColor = false;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.BackColor = Color.Gold;
            radioButton5.Location = new Point(555, 56);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(61, 24);
            radioButton5.TabIndex = 17;
            radioButton5.TabStop = true;
            radioButton5.Text = "Filial";
            radioButton5.UseVisualStyleBackColor = false;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.BackColor = Color.Gold;
            radioButton6.Location = new Point(485, 97);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(38, 24);
            radioButton6.TabIndex = 18;
            radioButton6.TabStop = true;
            radioButton6.Text = "P";
            radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.BackColor = Color.Gold;
            radioButton7.Location = new Point(555, 97);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(43, 24);
            radioButton7.TabIndex = 19;
            radioButton7.TabStop = true;
            radioButton7.Text = "M";
            radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.BackColor = Color.Gold;
            radioButton8.Location = new Point(625, 97);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(40, 24);
            radioButton8.TabIndex = 20;
            radioButton8.TabStop = true;
            radioButton8.Text = "G";
            radioButton8.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.Gold;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "EI – Empresário Individual", "MEI – Microempreendedor Individual", "Sociedade Anônima", "Sociedade Simples Limitada", "Sociedade Limitada Unipessoal" });
            comboBox3.Location = new Point(544, 137);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(221, 28);
            comboBox3.TabIndex = 21;
            // 
            // button3
            // 
            button3.Location = new Point(555, 271);
            button3.Name = "button3";
            button3.Size = new Size(146, 38);
            button3.TabIndex = 22;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(555, 329);
            button4.Name = "button4";
            button4.Size = new Size(146, 38);
            button4.TabIndex = 23;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button2_Click;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Gold;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(112, 58);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ScrollBars = ScrollBars.Horizontal;
            textBox7.Size = new Size(181, 25);
            textBox7.TabIndex = 24;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // CadastroEmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox3);
            Controls.Add(radioButton8);
            Controls.Add(radioButton7);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(textBox6);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Name = "CadastroEmp";
            Text = "CadastroEmp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private TextBox textBox6;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private ComboBox comboBox3;
        private Button button3;
        private Button button4;
        private TextBox textBox7;
    }
}