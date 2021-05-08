
namespace GUI
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblCate = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(298, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(18, 137);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 15);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            this.lblMarca.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(85, 96);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(280, 23);
            this.txtTipo.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(67, 134);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(117, 23);
            this.txtMarca.TabIndex = 4;
            this.txtMarca.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(205, 137);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(72, 15);
            this.lblQtd.TabIndex = 11;
            this.lblQtd.Text = "Quantidade:";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(283, 134);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(82, 23);
            this.txtQtd.TabIndex = 7;
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Location = new System.Drawing.Point(18, 99);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(33, 15);
            this.lblCate.TabIndex = 6;
            this.lblCate.Text = "Tipo:";
            this.lblCate.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(161, 188);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Cadastrar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 226);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.lblCate);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.Button btnEnviar;
    }
}

