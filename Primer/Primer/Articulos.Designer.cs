namespace Primer
{
    partial class Articulos
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
            this.buscar = new System.Windows.Forms.Button();
            this.idarticulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modelo = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.talla = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.TextBox();
            this.atras = new System.Windows.Forms.Button();
            this.marca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buscar
            // 
            this.buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buscar.Location = new System.Drawing.Point(318, 49);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 0;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // idarticulo
            // 
            this.idarticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idarticulo.Location = new System.Drawing.Point(147, 51);
            this.idarticulo.Name = "idarticulo";
            this.idarticulo.Size = new System.Drawing.Size(165, 20);
            this.idarticulo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stock";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Talla";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Color";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Modelo";
            // 
            // modelo
            // 
            this.modelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modelo.Location = new System.Drawing.Point(238, 195);
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Size = new System.Drawing.Size(130, 20);
            this.modelo.TabIndex = 10;
            // 
            // stock
            // 
            this.stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stock.Location = new System.Drawing.Point(238, 304);
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Size = new System.Drawing.Size(130, 20);
            this.stock.TabIndex = 12;
            // 
            // talla
            // 
            this.talla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.talla.Location = new System.Drawing.Point(238, 233);
            this.talla.Name = "talla";
            this.talla.ReadOnly = true;
            this.talla.Size = new System.Drawing.Size(130, 20);
            this.talla.TabIndex = 13;
            // 
            // color
            // 
            this.color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.color.Location = new System.Drawing.Point(238, 267);
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Size = new System.Drawing.Size(130, 20);
            this.color.TabIndex = 14;
            // 
            // atras
            // 
            this.atras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.atras.Location = new System.Drawing.Point(380, 424);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(95, 25);
            this.atras.TabIndex = 15;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // marca
            // 
            this.marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.marca.Location = new System.Drawing.Point(238, 161);
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Size = new System.Drawing.Size(130, 20);
            this.marca.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Marca";
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.color);
            this.Controls.Add(this.talla);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idarticulo);
            this.Controls.Add(this.buscar);
            this.MaximizeBox = false;
            this.Name = "Articulos";
            this.Text = "Artículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox idarticulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modelo;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.TextBox talla;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.TextBox marca;
        private System.Windows.Forms.Label label2;
    }
}