namespace Ventas
{
    partial class Agregar_Pedidos
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
            comboBoxCliente = new ComboBox();
            txtProducto = new TextBox();
            numericUpDownCantidad = new NumericUpDown();
            label4 = new Label();
            dateTimePickerFechaPedido = new DateTimePicker();
            Pedidos = new DataGridView();
            Btnguardar = new Button();
            btnactualizar = new Button();
            btneliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pedidos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 75);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 0;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 121);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 19);
            label3.TabIndex = 0;
            label3.Text = "Cantidad";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(136, 25);
            comboBoxCliente.Margin = new Padding(2, 2, 2, 2);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(241, 23);
            comboBoxCliente.TabIndex = 1;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(136, 76);
            txtProducto.Margin = new Padding(2, 2, 2, 2);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(241, 23);
            txtProducto.TabIndex = 2;
            // 
            // numericUpDownCantidad
            // 
            numericUpDownCantidad.Location = new Point(138, 122);
            numericUpDownCantidad.Margin = new Padding(2, 2, 2, 2);
            numericUpDownCantidad.Name = "numericUpDownCantidad";
            numericUpDownCantidad.Size = new Size(239, 23);
            numericUpDownCantidad.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 166);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 19);
            label4.TabIndex = 0;
            label4.Text = "Fecha";
            // 
            // dateTimePickerFechaPedido
            // 
            dateTimePickerFechaPedido.Location = new Point(138, 164);
            dateTimePickerFechaPedido.Margin = new Padding(2, 2, 2, 2);
            dateTimePickerFechaPedido.Name = "dateTimePickerFechaPedido";
            dateTimePickerFechaPedido.Size = new Size(240, 23);
            dateTimePickerFechaPedido.TabIndex = 4;
            // 
            // Pedidos
            // 
            Pedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Pedidos.Location = new Point(410, 24);
            Pedidos.Margin = new Padding(2, 2, 2, 2);
            Pedidos.Name = "Pedidos";
            Pedidos.RowHeadersWidth = 62;
            Pedidos.RowTemplate.Height = 33;
            Pedidos.Size = new Size(405, 158);
            Pedidos.TabIndex = 5;
            // 
            // Btnguardar
            // 
            Btnguardar.Location = new Point(22, 218);
            Btnguardar.Margin = new Padding(2, 2, 2, 2);
            Btnguardar.Name = "Btnguardar";
            Btnguardar.Size = new Size(78, 20);
            Btnguardar.TabIndex = 6;
            Btnguardar.Text = "Guardar";
            Btnguardar.UseVisualStyleBackColor = true;
            Btnguardar.Click += Btnguardar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(153, 218);
            btnactualizar.Margin = new Padding(2, 2, 2, 2);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(78, 20);
            btnactualizar.TabIndex = 7;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(298, 218);
            btneliminar.Margin = new Padding(2, 2, 2, 2);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(78, 20);
            btneliminar.TabIndex = 8;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // Agregar_Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 270);
            Controls.Add(btneliminar);
            Controls.Add(btnactualizar);
            Controls.Add(Btnguardar);
            Controls.Add(Pedidos);
            Controls.Add(dateTimePickerFechaPedido);
            Controls.Add(numericUpDownCantidad);
            Controls.Add(txtProducto);
            Controls.Add(comboBoxCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Agregar_Pedidos";
            Text = "Agregar_Pedidos";
            Load += Agregar_Pedidos_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxCliente;
        private TextBox txtProducto;
        private NumericUpDown numericUpDownCantidad;
        private Label label4;
        private DateTimePicker dateTimePickerFechaPedido;
        private DataGridView Pedidos;
        private Button Btnguardar;
        private Button btnactualizar;
        private Button btneliminar;
    }
}