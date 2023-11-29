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
        private List<Empresa> empresaList = new List<Empresa>();

        public ConsultaEmpresa()
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
                }

                dataGridView1.DataSource = empresaList;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
