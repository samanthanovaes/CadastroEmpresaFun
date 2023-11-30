using empresafunc.Configuracao;
using empresafunc.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresafunc
{
    public partial class ConsultaEmpresa : Form
    {
        public List<Empresa> empresaList = new List<Empresa>();



        public ConsultaEmpresa()
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


            try
            {

                var conexao = new Conexao();
                var comando = conexao.Comando("select * from Empresa");
                var leitor = comando.ExecuteReader();
                string resultado = null;


                while (leitor.Read())
                {
                    resultado += "\n" + leitor.GetString("razao_social");

                    var e = new Empresa();
                    e.Cnpj = leitor.GetString("cnpj_emp");
                    e.RazaoSocial = leitor.GetString("razao_social_emp");
                    e.Situacao = leitor.GetString("situacao_cadastral_emp");
                    e.Regime = leitor.GetString("regime_tributario_emp");
                    e.Datainicio = leitor.GetDateTime("data_inicio_emp");
                    e.Telefone = leitor.GetString("telefone_emp");
                    e.Capitalsocial = leitor.GetDouble("capital_social_emp");
                    e.Unifederal = leitor.GetString("uf_emp");
                    e.Cidade = leitor.GetString("cidade_emp");
                    e.Rua = leitor.GetString("rua_emp");
                    e.Bairro = leitor.GetString("bairro_emp");
                    e.Tipo = leitor.GetString("tipo_emp");
                    e.Porte = leitor.GetString("porte_emp");
                    e.Natureza = leitor.GetString("natureza_emp");
                    e.Proprietario = leitor.GetString("nome_proprietario_emp");
                    e.Cpf = leitor.GetString("cpf_proprietario_emp");


                    empresaList.Add(e);

                }

                dataGridView1.DataSource = empresaList;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroEmp CadastroEmp = new CadastroEmp();
            CadastroEmp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuuuuuuuuuu Menu = new Menuuuuuuuuuu();
            Menu.Show();
        }
    }
}
