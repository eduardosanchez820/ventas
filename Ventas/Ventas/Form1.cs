namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregarClie_Click(object sender, EventArgs e)
        {
            Agregar_Clientes agregar_Clientes = new Agregar_Clientes();
            agregar_Clientes.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar_Pedidos agregar_Pedidos = new Agregar_Pedidos();
            agregar_Pedidos.Show(this);
        }
    }
}