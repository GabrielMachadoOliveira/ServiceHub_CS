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

        private int categoriaSelecionadaId = 0;
        private bool editando = false;

        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            // Configurações ideais para a tabela aceitar o DataSource
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.MultiSelect = false;
            dgvCategorias.ReadOnly = true;
            dgvCategorias.AutoGenerateColumns = true;

            CarregaGrid();
        }
        private void CarregaGrid(string busca = "")
        {
            try
            {
                // 1. Limpa o vínculo anterior
                dgvCategorias.DataSource = null;

                // 2. IMPORTANTE: Apaga as colunas manuais desenhadas no modo Design 
                // para dar espaço às colunas dinâmicas que vêm da classe Categoria
                dgvCategorias.Columns.Clear();

                // 3. Busca a lista atualizada do banco de dados
                List<Categoria> lista = Categoria.ObterLista(busca);

                // 4. Atribui a lista ao DataGridView
                dgvCategorias.DataSource = lista;

                // Opcional: Deixar os cabeçalhos das colunas bonitos e com letra maiúscula
                if (dgvCategorias.Columns.Contains("Id")) dgvCategorias.Columns["Id"].HeaderText = "ID";
                if (dgvCategorias.Columns.Contains("Nome")) dgvCategorias.Columns["Nome"].HeaderText = "Nome da Categoria";
                if (dgvCategorias.Columns.Contains("Sigla")) dgvCategorias.Columns["Sigla"].HeaderText = "Sigla";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao renderizar dados no Grid: {ex.Message}", "Erro de Visualização");
            }
        }

        private void LimparCampos()
        {
            categoriaSelecionadaId = 0;
            editando = false;
            btnEditar.Text = "Editar";

            txtId.Clear();
            txtNome.Clear();
            txtSigla.Clear();
            txtNome.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("O nome da categoria é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // CORRIGIDO: Passando txtSigla.Text em vez de Sigla.Text
                Categoria categoria = new Categoria(txtNome.Text, txtSigla.Text);
                categoria.Inserir();

                if (categoria.Id > 0)
                {
                    MessageBox.Show($"Categoria {categoria.Nome} inserida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaGrid();
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir categoria: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (categoriaSelecionadaId == 0)
            {
                MessageBox.Show("Selecione uma categoria na lista para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!editando)
            {
                // Modo Visualização -> Carrega os dados nos inputs
                Categoria cat = Categoria.ObterPorId(categoriaSelecionadaId);
                txtId.Text = cat.Id.ToString();
                txtNome.Text = cat.Nome;
                txtSigla.Text = cat.Sigla;

                editando = true;
                btnEditar.Text = "Salvar";
                txtNome.Focus();
            }
            else
            {
                // Modo Salvar -> Executa a Procedure de Update
                try
                {
                    Categoria cat = new Categoria(categoriaSelecionadaId, txtNome.Text, txtSigla.Text);

                    if (cat.Atualizar())
                    {
                        MessageBox.Show("Categoria atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaGrid();
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma alteração foi realizada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Extrai o objeto da linha usando a mesma estrutura limpa das outras telas
            Categoria categoria = dgvCategorias.Rows[e.RowIndex].DataBoundItem as Categoria;
            if (categoria == null) return;

            categoriaSelecionadaId = categoria.Id;
            txtId.Text = categoria.Id.ToString();
            txtNome.Text = categoria.Nome;
            txtSigla.Text = categoria.Sigla;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGrid(txtBuscar.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Se limpar a caixa de busca, recarrega a lista completa automaticamente
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                CarregaGrid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (categoriaSelecionadaId == 0)
            {
                MessageBox.Show("Selecione uma categoria para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir esta categoria?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                if (Categoria.Excluir(categoriaSelecionadaId))
                {
                    MessageBox.Show("Categoria excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaGrid();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir a categoria.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregaGrid();
        }
    }
}
