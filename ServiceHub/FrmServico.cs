using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceHubClass;

namespace ServiceHub
{
    public partial class FrmServico : Form
    {
        public FrmServico()
        {
            InitializeComponent();
        }

        private void FrmServico_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            double preco = (double)nudPreco.Value;

            var cmd = Banco.Abrir();
            cmd.CommandText = $"insert servicos (nome, descricao, preco)" +
                $"values('{nome}','{descricao}',{preco})";
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.CommandText = "select last_insert_id()";
                txtId.Text = cmd.ExecuteScalar().ToString();
                btnAdicionar.Enabled = false;
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (btnPesquisar.Text == "&Pesquisar")
            {
                txtId.ReadOnly = false;
                txtNome.ReadOnly = true;
                txtDescricao.ReadOnly = true;
                nudPreco.ReadOnly = true;
                checkBox1.Enabled = false;
                txtId.Focus();
                btnPesquisar.Text = "Buscar...";
            }
            else if (btnPesquisar.Text == "Buscar")
            {
                // busca no banco
                var cmd = Banco.Abrir();
                cmd.CommandText = $"select * from servicos where id = {txtId.Text}";
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNome.Text = dr.GetString(1);
                    txtDescricao.Text = dr.GetString(2);
                    nudPreco.Value = dr.GetDecimal(3);
                    checkBox1.Checked = dr.GetBoolean(4);
                }
                btnPesquisar.Text = "&Pesquisar";
                txtId.ReadOnly = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "&Editar")
            {
                txtDescricao.ReadOnly = false;
                txtNome.ReadOnly = false;
                nudPreco.ReadOnly = false;
                checkBox1.Enabled = true;
                btnEditar.Text = "Salvar...";

            }
            else
            {
                var cmd = Banco.Abrir();
                cmd.CommandText = $"update servicos set nome = '{txtNome.Text}', " +
                    $"descricao = {txtDescricao.Text}, preco = '{nudPreco.Value}'," +
                    $"descontinuado = {checkBox1.Checked} where id = '{txtId.Text}'";
                if (cmd.ExecuteNonQuery() > 0)
                {
                    btnEditar.Text = "&Editar";
                    txtNome.ReadOnly = true;
                    txtDescricao.ReadOnly= true;
                    nudPreco.ReadOnly= true;
                    checkBox1 .Enabled = false;
                }
               
            }
        }
    }
}
