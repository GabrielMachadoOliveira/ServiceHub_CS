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
        private int produtoSelecionadoId = 0;
        private bool editando = false;

        public FrmProduto()
        {
            InitializeComponent();
        }

        private void CarregarProdutos(string busca = "")
        {
            dgvProduto.AutoGenerateColumns = true;
            dgvProduto.DataSource = null;
            dgvProduto.DataSource = Produto.ObterLista(busca);
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = Categoria.ObterLista();
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";

            dgvProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduto.MultiSelect = false;
            dgvProduto.ReadOnly = true;
            dgvProduto.AutoGenerateColumns = true;

            CarregarProdutos();
        }

        // Limpa a tela após inserções, edições ou cancelamentos
        private void LimparCampos()
        {
            produtoSelecionadoId = 0;
            editando = false;
            btnEditar.Text = "Editar";

            txtCodBarras.Clear();
            txtDescricao.Clear();
            txtUnidadeVenda.Clear();
            nudValorUnit.Value = 0;
            nudEstoqueMinimo.Value = 0;
            nudClasseDesconto.Value = 0;

            if (cmbCategoria.Items.Count > 0) cmbCategoria.SelectedIndex = 0;
            txtCodBarras.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescricao.Text))
                {
                    MessageBox.Show("A descrição do produto é obrigatória.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Produto produto = new Produto(
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
                {
                    MessageBox.Show($"Produto {produto.Descricao} gravado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarProdutos();
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (produtoSelecionadoId == 0)
            {
                MessageBox.Show("Selecione um produto na lista para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!editando)
            {
                Produto produto = Produto.ObterPorId(produtoSelecionadoId);

                txtCodBarras.Text = produto.CodBarras;
                txtDescricao.Text = produto.Descricao;
                nudValorUnit.Value = Convert.ToDecimal(produto.ValorUnit);
                txtUnidadeVenda.Text = produto.UnidadeVenda;
                nudEstoqueMinimo.Value = Convert.ToDecimal(produto.EstoqueMinimo);
                nudClasseDesconto.Value = Convert.ToDecimal(produto.ClasseDesconto);

                if (produto.Categoria != null)
                {
                    cmbCategoria.SelectedValue = produto.Categoria.Id;
                }

                editando = true;
                btnEditar.Text = "Salvar";
                txtCodBarras.Focus();
            }
            else
            {
                try
                {
                    // Criando o objeto passando o ID selecionado para que o Update saiba qual linha alterar
                    Produto produto = new Produto(
                        produtoSelecionadoId,
                        txtCodBarras.Text,
                        txtDescricao.Text,
                        Convert.ToDouble(nudValorUnit.Value),
                        txtUnidadeVenda.Text,
                        Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                        Convert.ToDouble(nudEstoqueMinimo.Value),
                        Convert.ToDouble(nudClasseDesconto.Value)
                    );

                    if (produto.Atualizar())
                    {
                        MessageBox.Show("Produto updated com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarProdutos();
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum Produto foi atualizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Produto produto = dgvProduto.Rows[e.RowIndex].DataBoundItem as Produto;
            if (produto == null) return;

            produtoSelecionadoId = produto.Id;
            txtCodBarras.Text = produto.CodBarras;
            txtDescricao.Text = produto.Descricao;
            nudValorUnit.Value = Convert.ToDecimal(produto.ValorUnit);
            txtUnidadeVenda.Text = produto.UnidadeVenda;
            nudEstoqueMinimo.Value = Convert.ToDecimal(produto.EstoqueMinimo);
            nudClasseDesconto.Value = Convert.ToDecimal(produto.ClasseDesconto);

            if (produto.Categoria != null)
            {
                cmbCategoria.SelectedValue = produto.Categoria.Id;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Se o seu campo de texto de busca chamar 'txtBuscar', mude aqui para txtBuscar.Text
            CarregarProdutos(txtCodBarras.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (produtoSelecionadoId == 0)
            {
                MessageBox.Show("Selecione um produto na lista para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente descontinuar este produto?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                if (Produto.Excluir(produtoSelecionadoId))
                {
                    MessageBox.Show("Produto descontinuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarProdutos();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possível descontinuar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarProdutos();
        }
    }
}
