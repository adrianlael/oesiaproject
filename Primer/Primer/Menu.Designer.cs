namespace Primer
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Clientes = new System.Windows.Forms.Button();
            this.Articulos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Pedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clientes
            // 
            this.Clientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clientes.Image = ((System.Drawing.Image)(resources.GetObject("Clientes.Image")));
            this.Clientes.Location = new System.Drawing.Point(62, 115);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(181, 158);
            this.Clientes.TabIndex = 0;
            this.Clientes.UseVisualStyleBackColor = true;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Articulos
            // 
            this.Articulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Articulos.Image = ((System.Drawing.Image)(resources.GetObject("Articulos.Image")));
            this.Articulos.Location = new System.Drawing.Point(282, 115);
            this.Articulos.Name = "Articulos";
            this.Articulos.Size = new System.Drawing.Size(170, 158);
            this.Articulos.TabIndex = 1;
            this.Articulos.UseVisualStyleBackColor = true;
            this.Articulos.Click += new System.EventHandler(this.Articulos_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(678, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cerrar sesión";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Pedidos
            // 
            this.Pedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pedidos.Image = ((System.Drawing.Image)(resources.GetObject("Pedidos.Image")));
            this.Pedidos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pedidos.Location = new System.Drawing.Point(491, 115);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(170, 158);
            this.Pedidos.TabIndex = 3;
            this.Pedidos.UseVisualStyleBackColor = true;
            this.Pedidos.Click += new System.EventHandler(this.Pedidos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(791, 469);
            this.Controls.Add(this.Pedidos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Articulos);
            this.Controls.Add(this.Clientes);
            this.Name = "Menu";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Button Articulos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Pedidos;
    }
}