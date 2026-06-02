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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void CarregaGrid(string texto = "")
        {
            dgvCategorias.Rows.Clear();
            List<Categoria> categorias = Categoria.ObterLista();
            foreach (var categoria in categorias)
            {
                dgvCategorias.Rows.Add();
                dgvCategorias.Rows[dgvCategorias.Rows.Count - 1].Cells[0].Value = categoria.Id;
                dgvCategorias.Rows[dgvCategorias.Rows.Count - 1].Cells[1].Value = categoria.Nome;
                dgvCategorias.Rows[dgvCategorias.Rows.Count - 1].Cells[2].Value = categoria.Sigla;

            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new(txtNome.Text, Sigla.Text);
            categoria.Inserir();
            if (categoria.Id > 0)
            {
                MessageBox.Show($"Categoria {categoria.Id} inserida com sucesso!");
                CarregaGrid();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 1)
            {
                CarregaGrid(txtBuscar.Text);
            }
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvCategorias.Rows[e.RowIndex].Cells[0].Value;
            MessageBox.Show(id.ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria(int.Parse(txtId.Text), txtNome.Text, txtSigla.Text);
            if (cat.Atualizar())
            {

            txtId.Clear();
            txtNome.Clear();
            txtSigla.Clear();
            CarregaGrid();
            MessageBox.Show($"Categoria {cat.Id} alterada com sucesso!");

            }
        }
    }
}
