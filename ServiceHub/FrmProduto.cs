using ServiceHubClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceHub
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = Categoria.ObterLista();
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";

            dataGridView1.DataSource = Produto.ObterLista();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new(
            txtCodBarras.Text,
            txtDescricao.Text,
            (double)nudValorUnit.Value,
            txtUnidadeVenda.Text,
            Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
            (double)nudEstoqueMinimo.Value,
                (double)nudClasseDesconto.Value
            );
            produto.Inserir();
            if (produto.Id > 0)
                MessageBox.Show($"Produto {produto.Descricao} gravado com sucesso!");
        }
    }
}
