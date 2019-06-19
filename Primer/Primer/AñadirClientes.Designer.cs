namespace Primer
{
    partial class AñadirClientes
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
            this.textBoxNifnie = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxPrimerapellido = new System.Windows.Forms.TextBox();
            this.textBoxSegundoapellido = new System.Windows.Forms.TextBox();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.textBoxProvincia = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.errorTextBox1 = new LibreriaBD.ErrorTextBox();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(549, 194);
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // textBoxNifnie
            // 
            this.textBoxNifnie.Location = new System.Drawing.Point(106, 29);
            this.textBoxNifnie.Name = "textBoxNifnie";
            this.textBoxNifnie.Size = new System.Drawing.Size(100, 20);
            this.textBoxNifnie.TabIndex = 1;
            this.textBoxNifnie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(106, 63);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxPrimerapellido
            // 
            this.textBoxPrimerapellido.Location = new System.Drawing.Point(106, 93);
            this.textBoxPrimerapellido.Name = "textBoxPrimerapellido";
            this.textBoxPrimerapellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrimerapellido.TabIndex = 3;
            // 
            // textBoxSegundoapellido
            // 
            this.textBoxSegundoapellido.Location = new System.Drawing.Point(106, 128);
            this.textBoxSegundoapellido.Name = "textBoxSegundoapellido";
            this.textBoxSegundoapellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxSegundoapellido.TabIndex = 4;
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Location = new System.Drawing.Point(324, 29);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(100, 20);
            this.textBoxCalle.TabIndex = 5;
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(324, 63);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(100, 20);
            this.textBoxPais.TabIndex = 6;
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(324, 93);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCiudad.TabIndex = 7;
            // 
            // textBoxProvincia
            // 
            this.textBoxProvincia.Location = new System.Drawing.Point(324, 125);
            this.textBoxProvincia.Name = "textBoxProvincia";
            this.textBoxProvincia.Size = new System.Drawing.Size(100, 20);
            this.textBoxProvincia.TabIndex = 8;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(482, 48);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "NIF / NIE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "1º apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "2º apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Calle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "País";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ciudad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Provincia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Teléfono";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(243, 194);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(134, 23);
            this.btnAñadir.TabIndex = 19;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // errorTextBox1
            // 
            this.errorTextBox1.Location = new System.Drawing.Point(106, 171);
            this.errorTextBox1.Name = "errorTextBox1";
            this.errorTextBox1.Size = new System.Drawing.Size(100, 20);
            this.errorTextBox1.TabIndex = 20;
            this.errorTextBox1.Validar = false;
            // 
            // AñadirClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 248);
            this.Controls.Add(this.errorTextBox1);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxProvincia);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.textBoxCalle);
            this.Controls.Add(this.textBoxSegundoapellido);
            this.Controls.Add(this.textBoxPrimerapellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxNifnie);
            this.MaximizeBox = false;
            this.Name = "AñadirClientes";
            this.Text = "Añadir clientes";
            this.Load += new System.EventHandler(this.AñadirClientes_Load);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.textBoxNifnie, 0);
            this.Controls.SetChildIndex(this.textBoxNombre, 0);
            this.Controls.SetChildIndex(this.textBoxPrimerapellido, 0);
            this.Controls.SetChildIndex(this.textBoxSegundoapellido, 0);
            this.Controls.SetChildIndex(this.textBoxCalle, 0);
            this.Controls.SetChildIndex(this.textBoxPais, 0);
            this.Controls.SetChildIndex(this.textBoxCiudad, 0);
            this.Controls.SetChildIndex(this.textBoxProvincia, 0);
            this.Controls.SetChildIndex(this.textBoxTelefono, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.btnAñadir, 0);
            this.Controls.SetChildIndex(this.errorTextBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNifnie;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxPrimerapellido;
        private System.Windows.Forms.TextBox textBoxSegundoapellido;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.TextBox textBoxProvincia;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAñadir;
        private LibreriaBD.ErrorTextBox errorTextBox1;
    }
}