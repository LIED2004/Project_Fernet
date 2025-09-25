namespace escola_Fernet
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.lbl_numerodeacesso = new System.Windows.Forms.Label();
            this.lbl_pin = new System.Windows.Forms.Label();
            this.txt_numerodeacesso = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(71, 259);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(155, 28);
            this.btn_login.TabIndex = 11;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // txt_pin
            // 
            this.txt_pin.Location = new System.Drawing.Point(71, 221);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new System.Drawing.Size(155, 22);
            this.txt_pin.TabIndex = 10;
            // 
            // lbl_numerodeacesso
            // 
            this.lbl_numerodeacesso.AutoSize = true;
            this.lbl_numerodeacesso.Location = new System.Drawing.Point(68, 144);
            this.lbl_numerodeacesso.Name = "lbl_numerodeacesso";
            this.lbl_numerodeacesso.Size = new System.Drawing.Size(122, 16);
            this.lbl_numerodeacesso.TabIndex = 9;
            this.lbl_numerodeacesso.Text = "Número de acesso";
            // 
            // lbl_pin
            // 
            this.lbl_pin.AutoSize = true;
            this.lbl_pin.Location = new System.Drawing.Point(68, 201);
            this.lbl_pin.Name = "lbl_pin";
            this.lbl_pin.Size = new System.Drawing.Size(26, 16);
            this.lbl_pin.TabIndex = 8;
            this.lbl_pin.Text = "Pin";
            // 
            // txt_numerodeacesso
            // 
            this.txt_numerodeacesso.Location = new System.Drawing.Point(71, 164);
            this.txt_numerodeacesso.Name = "txt_numerodeacesso";
            this.txt_numerodeacesso.Size = new System.Drawing.Size(155, 22);
            this.txt_numerodeacesso.TabIndex = 7;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(85, 61);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(122, 48);
            this.lbl_login.TabIndex = 6;
            this.lbl_login.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 379);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pin);
            this.Controls.Add(this.lbl_numerodeacesso);
            this.Controls.Add(this.lbl_pin);
            this.Controls.Add(this.txt_numerodeacesso);
            this.Controls.Add(this.lbl_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_pin;
        private System.Windows.Forms.Label lbl_numerodeacesso;
        private System.Windows.Forms.Label lbl_pin;
        private System.Windows.Forms.TextBox txt_numerodeacesso;
        private System.Windows.Forms.Label lbl_login;
    }
}

