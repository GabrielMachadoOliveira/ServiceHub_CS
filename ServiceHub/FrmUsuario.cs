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
    public partial class FrmUsuario : Form
    {
        private int usuarioSelecionadoId = 0;
        private bool editando = false;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregaNiveis();
            LimparCampos();
        }

        // Método auxiliar para atualizar o DataGridView
        private void CarregaGrid(string busca = "")
        {
            // O seu método ObterLista retorna uma List<Usuario> que o DataGridView aceita direto
            dgvUsuarios.DataSource = Usuario.ObterLista(busca);

            // Opcional: Ocultar colunas sensíveis ou desnecessárias na grade
            if (dgvUsuarios.Columns["Senha"] != null) dgvUsuarios.Columns["Senha"].Visible = false;
        }

        // Método auxiliar para carregar o ComboBox de Níveis
        private void CarregaNiveis()
        {
            // Supondo que sua classe Nivel tenha um método semelhante para listar
            // cmbNivel.DataSource = Nivel.ObterLista(); 
            // cmbNivel.DisplayMember = "Nome"; // O que aparece para o usuário
            // cmbNivel.ValueMember = "Id";      // O valor interno (ID)
        }

        // Método auxiliar para limpar a tela
        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            if (cmbNivel.Items.Count > 0) cmbNivel.SelectedIndex = 0;

            txtNome.Focus();
        }

        // Botão ADICIONAR (Insert)
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                // Instancia o usuário usando o construtor de Insert que você criou
                // Nota: Certifique-se de pegar o objeto Nivel selecionado no ComboBox
                Nivel nivelSelecionado = (Nivel)cmbNivel.SelectedItem;

                Usuario usuario = new Usuario(txtNome.Text, txtEmail.Text, txtSenha.Text, nivelSelecionado);

                usuario.Inserir();

                MessageBox.Show($"Usuário gravado com sucesso! ID gerado: {usuario.Id}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CarregaGrid();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botão EDITAR (Update)
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Selecione um usuário na lista primeiro para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Nivel nivelSelecionado = (Nivel)cmbNivel.SelectedItem;

                // Instancia usando o seu construtor de Update (com ID)
                Usuario usuario = new Usuario(Convert.ToInt32(txtId.Text), txtNome.Text, txtEmail.Text, txtSenha.Text, nivelSelecionado);

                if (usuario.Atualizar())
                {
                    MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaGrid();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar o usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botão EXCLUIR (Delete)
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Selecione um usuário para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacao = MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text);
                if (Usuario.Excluir(id))
                {
                    MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaGrid();
                    LimparCampos();
                }
            }
        }

        // Botão PESQUISAR (Filtro por nome)
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Passa o texto digitado na caixa "Buscar Categoria" (ou buscar usuário) para o método
            CarregaGrid(txtBuscar.Text);

            // Se a caixa de busca ficar vazia, recarrega a grade com todos os usuários
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                CarregaGrid();
            }
        }

        // Evento de Clique na Grade (Para puxar os dados de volta para as caixas de texto ao clicar na linha)
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Garante que não clicou no cabeçalho
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];

                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSenha.Text = row.Cells["Senha"].Value.ToString();

                // Para o nível, você precisará selecionar o item correspondente no combobox baseando-se no ID dele
                // Exemplo lógico:
                // cmbNivel.SelectedValue = ((Nivel)row.Cells["nivel"].Value).Id;
            }
        }

        // Botão CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}