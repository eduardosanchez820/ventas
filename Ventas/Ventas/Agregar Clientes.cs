using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Ventas
{
    public partial class Agregar_Clientes : Form
    {
        string connectionString = @"Data Source=LAPTOP-UKVT9NM6\SQLEXPRESS;Initial Catalog=BancoDB;Integrated Security=True;";

        public Agregar_Clientes()
        {
            InitializeComponent();
            this.Load += FormularioClientes_Load;
        }
        // metodos
        private void FormularioClientes_Load(object? sender, EventArgs e)
        {
            CargarClientes();
        }
        private void LimpiarCampos()
        {
            // Limpiar los campos de texto
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNcuenta.Text = "";
        }

        private void CargarClientes()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Clientes";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewClientes.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Obtén la información ingresada por el usuario
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int Ncuenta = Convert.ToInt32(txtNcuenta.Text);

            // Inserta la información del cliente en la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Clientes (Nombre, Apellido, Ncuenta) VALUES (@Nombre, @Apellido, @Ncuenta)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Ncuenta", Ncuenta);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cliente agregado correctamente.");
                    CargarClientes(); // Asegúrate de llamar a este método para recargar los datos.
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el cliente: " + ex.Message);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                // Obtener el ID del cliente seleccionado
                int clienteID = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["ClienteID"].Value);

                // Eliminar el cliente de la base de datos
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Clientes WHERE ClienteID = @ClienteID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ClienteID", clienteID);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Cliente eliminado correctamente.");
                        LimpiarCampos();

                        // Volver a cargar los clientes en el DataGridView
                        CargarClientes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.");
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                // Obtener el ID del cliente seleccionado
                int clienteID = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["ClienteID"].Value);

                // Obtener los nuevos valores de los campos de texto
                string nuevoNombre = txtNombre.Text;
                string nuevoApellido = txtApellido.Text;
                int nuevaNcuenta = Convert.ToInt32(txtNcuenta.Text);

                // Actualizar los datos del cliente en la base de datos
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Clientes SET Nombre = @NuevoNombre, Apellido = @NuevoApellido, Ncuenta = @NuevaNcuenta WHERE ClienteID = @ClienteID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ClienteID", clienteID);
                        command.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                        command.Parameters.AddWithValue("@NuevoApellido", nuevoApellido);
                        command.Parameters.AddWithValue("@NuevaEdad", nuevaNcuenta);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Cliente actualizado correctamente.");
                        LimpiarCampos();

                        // Volver a cargar los clientes en el DataGridView
                        CargarClientes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para actualizar.");
            }

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = new Sucursal();
            sucursal.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}