using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Sucursal : Form
    {
        string connectionString = @"Data Source=LAPTOP-UKVT9NM6\SQLEXPRESS;Initial Catalog=BancoDB;Integrated Security=True;";

        public Sucursal()
        {
            InitializeComponent();
            
        }

        private void Sucursal_Load(object sender, EventArgs e)
        {
            CargarSucursal();
        }
        private void LimpiarCampos()
        {
            // Limpiar los campos de texto
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtLocalidad.Text = "";
        }
        private void CargarSucursal()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM sucursal";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    Pedidos.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string localidad = txtLocalidad.Text;


            // Inserta la información del cliente en la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO sucursal (Nombre, direccion, localidad) VALUES (@Nombre, @direccion, @localidad)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@direccion", direccion);
                command.Parameters.AddWithValue("@localidad", localidad);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Direccion agregada correctamente.");
                    CargarSucursal(); // Asegúrate de llamar a este método para recargar los datos.
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la sucursal: " + ex.Message);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Pedidos.SelectedRows.Count > 0)
            {
                // Obtener el ID del cliente seleccionado
                int IDsucursal = Convert.ToInt32(Pedidos.SelectedRows[0].Cells["IDsucursal"].Value);

                // Eliminar el cliente de la base de datos
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM sucursal WHERE IDsucursal = @IDsucursal";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@CIDsucursal", IDsucursal);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Cliente eliminado correctamente.");
                        LimpiarCampos();

                        // Volver a cargar los clientes en el DataGridView
                        CargarSucursal();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (Pedidos.SelectedRows.Count > 0)
            {
                // Obtener el ID del cliente seleccionado
                int clienteID = Convert.ToInt32(Pedidos.SelectedRows[0].Cells["IDsucursal"].Value);

                // Obtener los nuevos valores de los campos de texto
                string nuevoNombre = txtNombre.Text;
                string nuevodireccion = txtDireccion.Text;
                string nuevalocalidad = txtLocalidad.Text;

                // Actualizar los datos del cliente en la base de datos
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE sucursal SET Nombre = @NuevoNombre, direccion = @Nuevodireccion, localidad = @Nuevalocalidad WHERE IDsucursal = @IDsucursal";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ClienteID", clienteID);
                        command.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                        command.Parameters.AddWithValue("@Nuevodireccion", nuevodireccion);
                        command.Parameters.AddWithValue("@Nuevalocalidad", nuevalocalidad);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Cliente actualizado correctamente.");
                        LimpiarCampos();

                        // Volver a cargar los clientes en el DataGridView
                        CargarSucursal();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
