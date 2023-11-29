using empresafunc.Configuracao;
using Org.BouncyCastle.Bcpg.Sig;
using System;
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
    public partial class CadastroEmp : Form
    {


        public CadastroEmp()
        {
            InitializeComponent();

            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;

            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;


        }

        private void Inserir(Empresa s)
        {
            try
            {

                Conexao conexao = new Conexao();
                var comando = conexao.Comando("insert into Empresa values (null, " +
                    "@cnpj, @razao_social, @situacao_cadastral, " +
                    "@regime_tributario, @data_inicio, @telefone, @capital_social, " +
                    "@uf, @cidade, @rua, @bairro, @tipo, @porte, @natureza, @nome_proprietario, @cpf_proprietario)");

                comando.Parameters.AddWithValue("@cnpj", "234");
                comando.Parameters.AddWithValue("@razao_social", s.RazaoSocial);
                comando.Parameters.AddWithValue("@nome_fantasia", "Nome Fantasia teste");
                comando.Parameters.AddWithValue("@situacao_cadastral", s.Situacao);
                comando.Parameters.AddWithValue("@regime_tributario", s.Regime);
                comando.Parameters.AddWithValue("@data_inicio", "2023-10-02");
                comando.Parameters.AddWithValue("@telefone", s.Telefone);
                comando.Parameters.AddWithValue("@capital_social", s.Capitalsocial);
                comando.Parameters.AddWithValue("@uf", s.Unifederal);
                comando.Parameters.AddWithValue("@cidade", s.Cidade);
                comando.Parameters.AddWithValue("@rua", "sda");
                comando.Parameters.AddWithValue("@bairro", s.Bairro);
                comando.Parameters.AddWithValue("@tipo", s.Tipo);
                comando.Parameters.AddWithValue("@porte", s.Porte);
                comando.Parameters.AddWithValue("@natureza", s.Natureza);
                comando.Parameters.AddWithValue("@nome_proprietario", s.Proprietario);
                comando.Parameters.AddWithValue("@cpf_proprietario", s.Cpf);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Empresa cadastrada com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string regime = "";
            string porte = "";
            string tipo = "";

            if (radioButton2.Checked)
            {
                regime = radioButton2.Text;
            }
            if (radioButton1.Checked)
            {
                regime = radioButton1.Text;
            }
            if (radioButton3.Checked)
            {
                regime = radioButton3.Text;
            }

            //

            if (radioButton4.Checked)
            {
                tipo = radioButton4.Text;
            }
            if (radioButton5.Checked)
            {
                tipo = radioButton5.Text;
            }

            //

            if (radioButton6.Checked)
            {
                porte = radioButton6.Text;
            }
            if (radioButton7.Checked)
            {
                porte = radioButton6.Text;
            }
            if (radioButton8.Checked)
            {
                porte = radioButton8.Text;
            }

            //

            DateTime data = DateTime.Parse(dateTimePicker1.Text);
            double capitals = Convert.ToDouble(textBox3.Text);
            Empresa s = new Empresa(textBox7.Text, textBox1.Text, comboBox1.Text, regime, data, maskedTextBox2.Text, capitals, comboBox2.Text, textBox4.Text,
            textBox2.Text, textBox6.Text, tipo, porte, comboBox3.Text, textBox5.Text, maskedTextBox1.Text);

            if (Validacao.Cnpjval(textBox7.Text))
            {

                if (Validacao.CPF(maskedTextBox1.Text))
                {

                    Inserir(s);
                    //Consulta();
                }

                else
                {

                    MessageBox.Show("CPF do proprietário inválido. Tente novamente.");

                }

            }
            else
            {

                MessageBox.Show("CNPJ inválido. Tente novamente.");

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
