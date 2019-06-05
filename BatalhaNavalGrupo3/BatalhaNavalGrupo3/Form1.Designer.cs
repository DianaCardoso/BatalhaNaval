namespace BatalhaNavalGrupo3
{
    partial class Form_batalha_naval
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
            this.painel_jogador_1 = new System.Windows.Forms.Panel();
            this.botao_definir_jogo = new System.Windows.Forms.Button();
            this.painel_botoes_jogador_1 = new System.Windows.Forms.Panel();
            this.painel_navios_disponiveis_1 = new System.Windows.Forms.Panel();
            this.painel_jogador_2 = new System.Windows.Forms.Panel();
            this.painel_navios_disponiveis_2 = new System.Windows.Forms.Panel();
            this.painel_botoes_jogador_2 = new System.Windows.Forms.Panel();
            this.botao_pronto_comecar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // painel_jogador_1
            // 
            this.painel_jogador_1.BackColor = System.Drawing.Color.Transparent;
            this.painel_jogador_1.ForeColor = System.Drawing.Color.Transparent;
            this.painel_jogador_1.Location = new System.Drawing.Point(12, 332);
            this.painel_jogador_1.Name = "painel_jogador_1";
            this.painel_jogador_1.Size = new System.Drawing.Size(538, 495);
            this.painel_jogador_1.TabIndex = 0;
            // 
            // botao_definir_jogo
            // 
            this.botao_definir_jogo.Location = new System.Drawing.Point(411, 12);
            this.botao_definir_jogo.Name = "botao_definir_jogo";
            this.botao_definir_jogo.Size = new System.Drawing.Size(261, 97);
            this.botao_definir_jogo.TabIndex = 1;
            this.botao_definir_jogo.Text = "Jogador 1 - Definir Jogo";
            this.botao_definir_jogo.UseVisualStyleBackColor = true;
            this.botao_definir_jogo.Click += new System.EventHandler(this.Botao_Start);
            // 
            // painel_botoes_jogador_1
            // 
            this.painel_botoes_jogador_1.Location = new System.Drawing.Point(12, 12);
            this.painel_botoes_jogador_1.Name = "painel_botoes_jogador_1";
            this.painel_botoes_jogador_1.Size = new System.Drawing.Size(261, 314);
            this.painel_botoes_jogador_1.TabIndex = 2;
            // 
            // painel_navios_disponiveis_1
            // 
            this.painel_navios_disponiveis_1.Location = new System.Drawing.Point(279, 12);
            this.painel_navios_disponiveis_1.Name = "painel_navios_disponiveis_1";
            this.painel_navios_disponiveis_1.Size = new System.Drawing.Size(43, 314);
            this.painel_navios_disponiveis_1.TabIndex = 3;
            // 
            // painel_jogador_2
            // 
            this.painel_jogador_2.BackColor = System.Drawing.Color.Transparent;
            this.painel_jogador_2.Location = new System.Drawing.Point(556, 332);
            this.painel_jogador_2.Name = "painel_jogador_2";
            this.painel_jogador_2.Size = new System.Drawing.Size(538, 495);
            this.painel_jogador_2.TabIndex = 5;
            // 
            // painel_navios_disponiveis_2
            // 
            this.painel_navios_disponiveis_2.Location = new System.Drawing.Point(780, 12);
            this.painel_navios_disponiveis_2.Name = "painel_navios_disponiveis_2";
            this.painel_navios_disponiveis_2.Size = new System.Drawing.Size(43, 314);
            this.painel_navios_disponiveis_2.TabIndex = 4;
            // 
            // painel_botoes_jogador_2
            // 
            this.painel_botoes_jogador_2.Location = new System.Drawing.Point(829, 12);
            this.painel_botoes_jogador_2.Name = "painel_botoes_jogador_2";
            this.painel_botoes_jogador_2.Size = new System.Drawing.Size(261, 314);
            this.painel_botoes_jogador_2.TabIndex = 3;
            // 
            // botao_pronto_comecar
            // 
            this.botao_pronto_comecar.Location = new System.Drawing.Point(411, 115);
            this.botao_pronto_comecar.Name = "botao_pronto_comecar";
            this.botao_pronto_comecar.Size = new System.Drawing.Size(261, 97);
            this.botao_pronto_comecar.TabIndex = 4;
            this.botao_pronto_comecar.Text = "Pronto";
            this.botao_pronto_comecar.UseVisualStyleBackColor = true;
            this.botao_pronto_comecar.Click += new System.EventHandler(this.Botao_Comecar_Jogo_Click);
            // 
            // Form_batalha_naval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1102, 916);
            this.Controls.Add(this.botao_definir_jogo);
            this.Controls.Add(this.painel_botoes_jogador_2);
            this.Controls.Add(this.painel_navios_disponiveis_2);
            this.Controls.Add(this.painel_jogador_2);
            this.Controls.Add(this.botao_pronto_comecar);
            this.Controls.Add(this.painel_navios_disponiveis_1);
            this.Controls.Add(this.painel_botoes_jogador_1);
            this.Controls.Add(this.painel_jogador_1);
            this.Name = "Form_batalha_naval";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        //Paineis Gerais
        private System.Windows.Forms.Button botao_pronto_comecar;
        private System.Windows.Forms.Button botao_definir_jogo;

        //Paineis e Botões do Jogador 1
        private System.Windows.Forms.Panel painel_jogador_1;
        private System.Windows.Forms.Panel painel_botoes_jogador_1;
        private System.Windows.Forms.Panel painel_navios_disponiveis_1;

        //Paineis e Botões do Jogador 2
        private System.Windows.Forms.Panel painel_jogador_2;
        private System.Windows.Forms.Panel painel_botoes_jogador_2;
        private System.Windows.Forms.Panel painel_navios_disponiveis_2;

    }
}

