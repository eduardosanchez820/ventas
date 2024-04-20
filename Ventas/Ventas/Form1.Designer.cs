namespace Ventas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnagregarClie = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btnagregarClie
            // 
            btnagregarClie.BackColor = Color.FromArgb(0, 0, 192);
            btnagregarClie.Font = new Font("SimSun", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnagregarClie.ForeColor = SystemColors.ControlLightLight;
            btnagregarClie.Location = new Point(302, 147);
            btnagregarClie.Margin = new Padding(2);
            btnagregarClie.Name = "btnagregarClie";
            btnagregarClie.Size = new Size(249, 28);
            btnagregarClie.TabIndex = 0;
            btnagregarClie.Text = "Agregar Clientes";
            btnagregarClie.UseVisualStyleBackColor = false;
            btnagregarClie.Click += btnagregarClie_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 266);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(649, 266);
            Controls.Add(panel1);
            Controls.Add(btnagregarClie);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnagregarClie;
        private Panel panel1;
    }
}