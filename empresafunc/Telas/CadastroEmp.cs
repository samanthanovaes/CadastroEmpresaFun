using empresafunc.Configuracao;
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

        private List<Empresa> empresaList = new List<Empresa>();  
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
                var comando = conexao.Comando("insert into Empresa values (null, @cnpj, @razao_social, @situacao_cadastral, " +
                "@regime_tributario, @data_inicio, @telefone, @capital_social, @uf, @cidade, @rua, @bairro, @tipo, @porte, @natureza, @nome_proprietario, @cpf_proprietario)");

                comando.Parameters.AddWithValue("@cnpj", s.Cnpj);
                comando.Parameters.AddWithValue("@razao_social", s.RazaoSocial);
                comando.Parameters.AddWithValue("@situacao_cadastral", s.Situacao);
                comando.Parameters.AddWithValue("@regime_tributario", s.Regime);
                comando.Parameters.AddWithValue("@data_inicio", s.Datainicio);
                comando.Parameters.AddWithValue("@telefone", s.Telefone);
                comando.Parameters.AddWithValue("@capital_social", s.Capitalsocial);
                comando.Parameters.AddWithValue("@uf", s.Unifederal);
                comando.Parameters.AddWithValue("@cidade", s.Cidade);
                comando.Parameters.AddWithValue("@rua", s.Rua);
                comando.Parameters.AddWithValue("@tipo", s.Tipo);
                comando.Parameters.AddWithValue("@porte", s.Porte);
                comando.Parameters.AddWithValue("@natureza", s.Natureza);
                comando.Parameters.AddWithValue("@nome_proprietario", s.Proprietario);
                comando.Parameters.AddWithValue("@cpf_pro", s.Porte);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Empresa cadastrado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void Consulta()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("select * from Empresa");
                var leitor = comando.ExecuteReader();
                string resultado = null;

                while (leitor.Read())
                {
                    resultado += "\n" + leitor.GetString("cnpj_emp");
                }

                MessageBox.Show(resultado);

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

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
