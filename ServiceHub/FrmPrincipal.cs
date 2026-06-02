namespace ServiceHub
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar uma instância do formulário Listar Clientes
            FrmListaClientes listaClientes = new();

            // Associando o form listar clientes como filho do principal 
            listaClientes.MdiParent = this;

            // Chamar o form de clientes
            listaClientes.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovoCliente novoCliente = new();
            novoCliente.MdiParent = this;
            novoCliente.Show();
        }
    }
}
