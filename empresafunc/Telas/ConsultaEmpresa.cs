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

namespace empresafunc
{
    public partial class ConsultaEmpresa : Form
    {
        public List<Empresa> empresaList = new List<Empresa>();



        public ConsultaEmpresa(Empresa s)
        {
            InitializeComponent();
            Consulta();
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
    }
}
