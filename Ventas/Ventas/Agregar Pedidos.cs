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
    public partial class Agregar_Pedidos : Form
    {
        private string connectionString = @"Data Source=DESKTOP-3SH92F4\SQLEXPRESS;Initial Catalog=Ventas;Integrated Security=True;";
        public Agregar_Pedidos()
        {
            InitializeComponent();
            CargarClientes();
            CargarPedidos();
        }
        private void CargarClientes()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ClienteID, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto FROM Clientes";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    comboBoxCliente.DataSource = dataTable;
                    comboBoxCliente.DisplayMember = "NombreCompleto";
                    comboBoxCliente.ValueMember = "ClienteID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void CargarPedidos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT PedidoID, Producto, Cantidad, FechaPedido FROM Pedidos";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    Pedidos.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pedidos: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtProducto.Text = "";
            numericUpDownCantidad.Value = 0;
            dateTimePickerFechaPedido.Value = DateTime.Now;
        }


        private void Btnguardar_Click(object sender, EventArgs e)
        {
            int clienteID = Convert.ToInt32(comboBoxCliente.SelectedValue);
            string producto = txtProducto.Text;
            int cantidad = Convert.ToInt32(numericUpDownCantidad.Value);
            DateTime fechaPedido = dateTimePickerFechaPedido.Value;

            // Insertar el nuevo pedido en la base de datos
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Pedidos (ClienteID, Producto, Cantidad, FechaPedido) VALUES (@ClienteID, @Producto, @Cantidad, @FechaPedido)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClienteID", clienteID);
                    command.Parameters.AddWithValue("@Producto", producto);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@FechaPedido", fechaPedido);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Pedido guardado correctamente.");
                }

                // Recargar los pedidos en el DataGridView y limpiar los campos
                CargarPedidos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pedido: " + ex.Message);
            }

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (Pedidos.SelectedRows.Count > 0)
            {
                // Obtener el ID del pedido seleccionado
                int pedidoID = Convert.ToInt32(Pedidos.SelectedRows[0].Cells["PedidoID"].Value);

                // Obtener los nuevos valores de los campos del formulario
                int clienteID = Convert.ToInt32(comboBoxCliente.SelectedValue);
                string producto = txtProducto.Text;
                int cantidad = Convert.ToInt32(numericUpDownCantidad.Value);
                DateTime fechaPedido = dateTimePickerFechaPedido.Value;

                // Actualizar el pedido en la base de datos
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Pedidos SET ClienteID = @ClienteID, Producto = @Producto, Cantidad = @Cantidad, FechaPedido = @FechaPedido WHERE PedidoID = @PedidoID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ClienteID", clienteID);
                        command.Parameters.AddWithValue("@Producto", producto);
                        command.Parameters.AddWithValue("@Cantidad", cantidad);
                        command.Parameters.AddWithValue("@FechaPedido", fechaPedido);
                        command.Parameters.AddWithValue("@PedidoID", pedidoID);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Pedido actualizado correctamente.");
                    }

                    // Recargar los pedidos en el DataGridView y limpiar los campos
                    CargarPedidos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el pedido: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un pedido para actualizar.");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (Pedidos.SelectedRows.Count > 0)
            {
                // Obtener el ID del pedido seleccionado
                int pedidoID = Convert.ToInt32(Pedidos.SelectedRows[0].Cells["PedidoID"].Value);

                // Eliminar el pedido de la base de datos
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Pedidos WHERE PedidoID = @PedidoID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@PedidoID", pedidoID);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Pedido eliminado correctamente.");
                    }

                    // Recargar los pedidos en el DataGridView
                    CargarPedidos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el pedido: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un pedido para eliminar.");
            }
        }

        private void Agregar_Pedidos_Load(object sender, EventArgs e)
        {

        }
    }
}
