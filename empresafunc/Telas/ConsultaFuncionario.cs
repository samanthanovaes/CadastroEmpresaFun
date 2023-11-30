using MySql.Data.MySqlClient;
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
    public partial class ConsultaFuncionario : Form
    {
        public ConsultaFuncionario()
        {
            InitializeComponent();
            Consulta();

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

        void Consulta()
        {


            using (var conexao = new MySqlConnection("server=localhost;uid=root;pwd=root;database=empresa_x2a_bd"))
            {
                try
                {
                    conexao.Open();
                    string query = "select * from Funcionario";
                    using (var da = new MySqlDataAdapter(query, conexao))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
