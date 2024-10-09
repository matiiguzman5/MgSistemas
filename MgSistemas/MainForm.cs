namespace MgSistemas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void verInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verInventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var InventarioForm = new InventarioForm();
            InventarioForm.Show();

            this.Hide();
        }
    }
}
