namespace Primer
{
    partial class Clientes
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
            this.buscarnifnie = new System.Windows.Forms.Button();
            this.nifnie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(238, 186);
            // 
            // buscarnifnie
            // 
            this.buscarnifnie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buscarnifnie.Location = new System.Drawing.Point(93, 105);
            this.buscarnifnie.Name = "buscarnifnie";
            this.buscarnifnie.Size = new System.Drawing.Size(104, 23);
            this.buscarnifnie.TabIndex = 0;
            this.buscarnifnie.Text = "Buscar NIF / NIE";
            this.buscarnifnie.UseVisualStyleBackColor = true;
            this.buscarnifnie.Click += new System.EventHandler(this.buscarnifnie_Click);
            // 
            // nifnie
            // 
            this.nifnie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nifnie.Location = new System.Drawing.Point(93, 79);
            this.nifnie.Name = "nifnie";
            this.nifnie.Size = new System.Drawing.Size(150, 20);
            this.nifnie.TabIndex = 3;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 238);
            this.Controls.Add(this.nifnie);
            this.Controls.Add(this.buscarnifnie);
            this.MaximizeBox = false;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.buscarnifnie, 0);
            this.Controls.SetChildIndex(this.nifnie, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarnifnie;
        private System.Windows.Forms.TextBox nifnie;
    }
}