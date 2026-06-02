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
    public partial class FrmListaClientes : Form
    {
        public FrmListaClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.Rows.Add();
            dgvClientes.Rows[0].Cells[0].Value = 1;
            dgvClientes.Rows[0].Cells[1].Value = 123456;
            dgvClientes.Rows[0].Cells[2].Value = "Gabriely da Silva Rocha Hora";
            dgvClientes.Rows[0].Cells[3].Value = "598.230.987-02";
            dgvClientes.Rows[0].Cells[4].Value = "gabrielyrhora@gmail.com";
            dgvClientes.Rows[0].Cells[5].Value = 11919026588;
            dgvClientes.Rows[0].Cells[6].Value = true;

            dgvClientes.Rows.Add();
            dgvClientes.Rows[1].Cells[0].Value = 1;
            dgvClientes.Rows[1].Cells[1].Value = 123456;
            dgvClientes.Rows[1].Cells[2].Value = "Gabriel Machado Oliveira";
            dgvClientes.Rows[1].Cells[3].Value = "549.226.518-22";
            dgvClientes.Rows[1].Cells[4].Value = "gabrielmoliviera@gmail.com";
            dgvClientes.Rows[1].Cells[5].Value = 11919934972;
            dgvClientes.Rows[1].Cells[6].Value = true;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show(e.RowIndex.ToString());
            string id = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            MessageBox.Show(id);
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
