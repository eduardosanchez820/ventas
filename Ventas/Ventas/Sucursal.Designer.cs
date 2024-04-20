namespace Ventas
{
    partial class Sucursal
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
            txtNombre = new TextBox();
            label1 = new Label();
            Pedidos = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txtDireccion = new TextBox();
            txtLocalidad = new TextBox();
            btnguardar = new Button();
            btneliminar = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)Pedidos).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(126, 13);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 22);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // Pedidos
            // 
            Pedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Pedidos.Location = new Point(403, 11);
            Pedidos.Margin = new Padding(2);
            Pedidos.Name = "Pedidos";
            Pedidos.RowHeadersWidth = 62;
            Pedidos.RowTemplate.Height = 33;
            Pedidos.Size = new Size(405, 158);
            Pedidos.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 63);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 22);
            label2.TabIndex = 7;
            label2.Text = "Direccion ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 112);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 22);
            label3.TabIndex = 8;
            label3.Text = "Localidad";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(126, 62);
            txtDireccion.Margin = new Padding(2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(210, 23);
            txtDireccion.TabIndex = 9;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(126, 114);
            txtLocalidad.Margin = new Padding(2);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(210, 23);
            txtLocalidad.TabIndex = 10;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.FromArgb(0, 0, 192);
            btnguardar.ForeColor = SystemColors.ControlLightLight;
            btnguardar.Location = new Point(33, 175);
            btnguardar.Margin = new Padding(2);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(78, 31);
            btnguardar.TabIndex = 11;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(0, 0, 192);
            btneliminar.ForeColor = SystemColors.ControlLightLight;
            btneliminar.Location = new Point(126, 175);
            btneliminar.Margin = new Padding(2);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(78, 31);
            btneliminar.TabIndex = 12;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 192);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(231, 175);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 31);
            button2.TabIndex = 13;
            button2.Text = "Actulizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGreen;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(622, 193);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(78, 31);
            button3.TabIndex = 14;
            button3.Text = "SIGUIENTE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 0, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(730, 193);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(78, 31);
            button4.TabIndex = 15;
            button4.Text = "SALIR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Sucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(819, 267);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btneliminar);
            Controls.Add(btnguardar);
            Controls.Add(txtLocalidad);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Pedidos);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "Sucursal";
            Text = "Sucursal";
            Load += Sucursal_Load;
            ((System.ComponentModel.ISupportInitialize)Pedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private DataGridView Pedidos;
        private Label label2;
        private Label label3;
        private TextBox txtDireccion;
        private TextBox txtLocalidad;
        private Button btnguardar;
        private Button btneliminar;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}