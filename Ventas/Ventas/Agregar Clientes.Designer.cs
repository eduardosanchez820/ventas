namespace Ventas
{
    partial class Agregar_Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNcuenta = new TextBox();
            btnguardar = new Button();
            dataGridViewClientes = new DataGridView();
            btneliminar = new Button();
            btnActualizar = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 22);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 62);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 22);
            label2.TabIndex = 0;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(2, 112);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 22);
            label3.TabIndex = 0;
            label3.Text = "N de cuenta";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 18);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(112, 58);
            txtApellido.Margin = new Padding(2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(212, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtNcuenta
            // 
            txtNcuenta.Location = new Point(136, 108);
            txtNcuenta.Margin = new Padding(2);
            txtNcuenta.Name = "txtNcuenta";
            txtNcuenta.Size = new Size(188, 23);
            txtNcuenta.TabIndex = 1;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.FromArgb(0, 0, 192);
            btnguardar.ForeColor = SystemColors.ControlLightLight;
            btnguardar.Location = new Point(27, 179);
            btnguardar.Margin = new Padding(2);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(78, 31);
            btnguardar.TabIndex = 2;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(365, 17);
            dataGridViewClientes.Margin = new Padding(2);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 62;
            dataGridViewClientes.RowTemplate.Height = 33;
            dataGridViewClientes.Size = new Size(366, 182);
            dataGridViewClientes.TabIndex = 3;
            dataGridViewClientes.CellContentClick += dataGridViewClientes_CellContentClick;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(0, 0, 192);
            btneliminar.ForeColor = Color.White;
            btneliminar.Location = new Point(136, 179);
            btneliminar.Margin = new Padding(2);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(78, 31);
            btneliminar.TabIndex = 4;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(0, 0, 192);
            btnActualizar.ForeColor = SystemColors.ControlLightLight;
            btnActualizar.Location = new Point(244, 179);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(78, 31);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(653, 203);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 31);
            button1.TabIndex = 6;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(532, 203);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 31);
            button2.TabIndex = 7;
            button2.Text = "SIGUIENTE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Agregar_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(755, 274);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnActualizar);
            Controls.Add(btneliminar);
            Controls.Add(dataGridViewClientes);
            Controls.Add(btnguardar);
            Controls.Add(txtNcuenta);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Agregar_Clientes";
            Text = "Agregar_Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNcuenta;
        private Button btnguardar;
        private DataGridView dataGridViewClientes;
        private Button btneliminar;
        private Button btnActualizar;
        private Button button1;
        private Button button2;
    }
}