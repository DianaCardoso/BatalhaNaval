namespace BatalhaNavalGrupo3
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
            this.PainelJogo = new System.Windows.Forms.Panel();
            this.Botao_Definir_Jogo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Botao_Comecar_Jogo = new System.Windows.Forms.Button();
            this.computador_jogo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PainelJogo
            // 
            this.PainelJogo.BackColor = System.Drawing.Color.Aqua;
            this.PainelJogo.Location = new System.Drawing.Point(408, 12);
            this.PainelJogo.Name = "PainelJogo";
            this.PainelJogo.Size = new System.Drawing.Size(531, 491);
            this.PainelJogo.TabIndex = 0;
            // 
            // Botao_Definir_Jogo
            // 
            this.Botao_Definir_Jogo.Location = new System.Drawing.Point(22, 12);
            this.Botao_Definir_Jogo.Name = "Botao_Definir_Jogo";
            this.Botao_Definir_Jogo.Size = new System.Drawing.Size(261, 68);
            this.Botao_Definir_Jogo.TabIndex = 1;
            this.Botao_Definir_Jogo.Text = "Definir Jogo";
            this.Botao_Definir_Jogo.UseVisualStyleBackColor = true;
            this.Botao_Definir_Jogo.Click += new System.EventHandler(this.Botao_Start);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(22, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 314);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(290, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 314);
            this.panel2.TabIndex = 3;
            // 
            // Botao_Comecar_Jogo
            // 
            this.Botao_Comecar_Jogo.Location = new System.Drawing.Point(22, 406);
            this.Botao_Comecar_Jogo.Name = "Botao_Comecar_Jogo";
            this.Botao_Comecar_Jogo.Size = new System.Drawing.Size(261, 97);
            this.Botao_Comecar_Jogo.TabIndex = 4;
            this.Botao_Comecar_Jogo.Text = "Começar";
            this.Botao_Comecar_Jogo.UseVisualStyleBackColor = true;
            this.Botao_Comecar_Jogo.Click += new System.EventHandler(this.Botao_Comecar_Jogo_Click);
            // 
            // computador_jogo
            // 
            this.computador_jogo.BackColor = System.Drawing.Color.Aqua;
            this.computador_jogo.Location = new System.Drawing.Point(945, 12);
            this.computador_jogo.Name = "computador_jogo";
            this.computador_jogo.Size = new System.Drawing.Size(531, 491);
            this.computador_jogo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1502, 509);
            this.Controls.Add(this.computador_jogo);
            this.Controls.Add(this.Botao_Comecar_Jogo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Botao_Definir_Jogo);
            this.Controls.Add(this.PainelJogo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PainelJogo;
        private System.Windows.Forms.Button Botao_Definir_Jogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Botao_Comecar_Jogo;
        private System.Windows.Forms.Panel computador_jogo;
    }
}

