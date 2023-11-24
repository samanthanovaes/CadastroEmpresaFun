using empresafunc.Configuracao;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace empresafunc
{
    public partial class CadFuncionario : Form
    {

        private List<Funcionario> listaFuncionario = new List<Funcionario>();
        public CadFuncionario()
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

        void Inserir(Funcionario s)
        {
            try
            {
                Conexao conexao = new Conexao();
                var comando = conexao.Comando("insert into Funcionario values (null, @nome, @dataNasc, @cpf, @rg, " +
                "@telefone, @email, @rua, @numero, @bairro, @estado_civil, @funcao, @salario)");

                comando.Parameters.AddWithValue("@nome", s.Nome);
                comando.Parameters.AddWithValue("@dataNasc", s.DataNasc);
                comando.Parameters.AddWithValue("@cpf", s.Cpf);
                comando.Parameters.AddWithValue("@rg", s.Rg);
                comando.Parameters.AddWithValue("@telefone", s.Telefone);
                comando.Parameters.AddWithValue("@email", s.Email);
                comando.Parameters.AddWithValue("@rua", s.Rua);
                comando.Parameters.AddWithValue("@bairro", s.Bairro);
                comando.Parameters.AddWithValue("@numero", s.Numero);
                comando.Parameters.AddWithValue("@estado_civil", s.EstadoCivil);
                comando.Parameters.AddWithValue("@funcao", s.Funcao);
                comando.Parameters.AddWithValue("@salario", s.Salario);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso.");
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
                var comando = conexao.Comando("select * from Funcionario");
                var leitor = comando.ExecuteReader();
                string resultado = null;

                while (leitor.Read())
                {
                    resultado += "\n" + leitor.GetString("nome_fun");
                }

                MessageBox.Show(resultado);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Parse(dateTimePicker1.Text);
            double salario = Convert.ToDouble(textBox12.Text);
            Funcionario s = new Funcionario(textBox1.Text, textBox2.Text, maskedTextBox1.Text, textBox5.Text, textBox3.Text, textBox6.Text, textBox7.Text, textBox8.Text,
            textBox9.Text, dateTime, textBox10.Text, comboBox1.Text, salario);
            if (Validacao.CPF(maskedTextBox1.Text))
            {
                if (Validacao.Email(textBox6.Text))
                {

                    MessageBox.Show("Salvo com sucesso.");
                    Inserir(s);
                    Consulta();
                }
                else
                {
                    MessageBox.Show("Email inváido. Tente novamente.");
                }
            }
            else
            {
                MessageBox.Show("Erro. CPF falso.");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}