﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresafunc.Telas
{
    public partial class ConsultaFuncionario : Form
    {
        public ConsultaFuncionario()
        {
            InitializeComponent();

            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;

            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadFuncionario cadFuncionario = new CadFuncionario();
            cadFuncionario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuuuuuuuuuu menuuuuuuuuuu = new Menuuuuuuuuuu();
            menuuuuuuuuuu.Show();
        }
    }
}
