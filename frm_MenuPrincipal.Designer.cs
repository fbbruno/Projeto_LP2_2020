namespace ProjetoIF
{
    partial class frm_MenuPrincipal
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
            this.btn_Livros = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Transacoes = new System.Windows.Forms.Button();
            this.btn_Configuracoes = new System.Windows.Forms.Button();
            this.btn_Departamentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Livros
            // 
            this.btn_Livros.Location = new System.Drawing.Point(12, 41);
            this.btn_Livros.Name = "btn_Livros";
            this.btn_Livros.Size = new System.Drawing.Size(269, 134);
            this.btn_Livros.TabIndex = 0;
            this.btn_Livros.Text = "Livros";
            this.btn_Livros.UseVisualStyleBackColor = true;
            this.btn_Livros.Click += new System.EventHandler(this.btn_Livros_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Location = new System.Drawing.Point(287, 41);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(269, 134);
            this.btn_Clientes.TabIndex = 1;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_Transacoes
            // 
            this.btn_Transacoes.Location = new System.Drawing.Point(12, 181);
            this.btn_Transacoes.Name = "btn_Transacoes";
            this.btn_Transacoes.Size = new System.Drawing.Size(269, 134);
            this.btn_Transacoes.TabIndex = 2;
            this.btn_Transacoes.Text = "Transações";
            this.btn_Transacoes.UseVisualStyleBackColor = true;
            this.btn_Transacoes.Click += new System.EventHandler(this.btn_Transacoes_Click);
            // 
            // btn_Configuracoes
            // 
            this.btn_Configuracoes.Location = new System.Drawing.Point(12, 12);
            this.btn_Configuracoes.Name = "btn_Configuracoes";
            this.btn_Configuracoes.Size = new System.Drawing.Size(83, 23);
            this.btn_Configuracoes.TabIndex = 3;
            this.btn_Configuracoes.Text = "Configurações";
            this.btn_Configuracoes.UseVisualStyleBackColor = true;
            this.btn_Configuracoes.Click += new System.EventHandler(this.btn_Configuracoes_Click);
            // 
            // btn_Departamentos
            // 
            this.btn_Departamentos.Location = new System.Drawing.Point(287, 181);
            this.btn_Departamentos.Name = "btn_Departamentos";
            this.btn_Departamentos.Size = new System.Drawing.Size(269, 134);
            this.btn_Departamentos.TabIndex = 4;
            this.btn_Departamentos.Text = "Departamentos";
            this.btn_Departamentos.UseVisualStyleBackColor = true;
            this.btn_Departamentos.Click += new System.EventHandler(this.btn_Departamentos_Click);
            // 
            // frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 330);
            this.Controls.Add(this.btn_Departamentos);
            this.Controls.Add(this.btn_Configuracoes);
            this.Controls.Add(this.btn_Transacoes);
            this.Controls.Add(this.btn_Clientes);
            this.Controls.Add(this.btn_Livros);
            this.Name = "frm_MenuPrincipal";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Livros;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_Transacoes;
        private System.Windows.Forms.Button btn_Configuracoes;
        private System.Windows.Forms.Button btn_Departamentos;
    }
}