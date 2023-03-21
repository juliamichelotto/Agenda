using BLL_;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Lista Lista { get; set; } = new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Pessoas pessoas = new Pessoas();

            pessoas.Nome = txtNome.Text;
            pessoas.Telefone = txtTelefone.Text;

            Lista.Incluir(pessoas);
            MessageBox.Show("Telefone incluido com sucesso");

            txtNome.Text = "";
            txtTelefone.Text = "";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listTelefones.Items.Clear();
            foreach (var al in Lista.Pessoas)
            {
                listTelefones.Items.Add(al.ToString());
            }
        }
    }
}