namespace Batalha_Naval_v2
{
    partial class janela_jogo
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
            this.p_botoes_barcos_j1 = new System.Windows.Forms.Panel();
            this.p_num_barcos_j1 = new System.Windows.Forms.Panel();
            this.p_num_barcos_j2 = new System.Windows.Forms.Panel();
            this.p_botoes_barcos_j2 = new System.Windows.Forms.Panel();
            this.b_pronto = new System.Windows.Forms.Button();
            this.p_campo_1 = new System.Windows.Forms.Panel();
            this.p_campo_2 = new System.Windows.Forms.Panel();
            this.status_jogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p_botoes_barcos_j1
            // 
            this.p_botoes_barcos_j1.Location = new System.Drawing.Point(1, 1);
            this.p_botoes_barcos_j1.Name = "p_botoes_barcos_j1";
            this.p_botoes_barcos_j1.Size = new System.Drawing.Size(196, 255);
            this.p_botoes_barcos_j1.TabIndex = 0;
            // 
            // p_num_barcos_j1
            // 
            this.p_num_barcos_j1.Location = new System.Drawing.Point(203, 1);
            this.p_num_barcos_j1.Name = "p_num_barcos_j1";
            this.p_num_barcos_j1.Size = new System.Drawing.Size(38, 255);
            this.p_num_barcos_j1.TabIndex = 1;
            // 
            // p_num_barcos_j2
            // 
            this.p_num_barcos_j2.Location = new System.Drawing.Point(567, 1);
            this.p_num_barcos_j2.Name = "p_num_barcos_j2";
            this.p_num_barcos_j2.Size = new System.Drawing.Size(38, 255);
            this.p_num_barcos_j2.TabIndex = 2;
            // 
            // p_botoes_barcos_j2
            // 
            this.p_botoes_barcos_j2.Location = new System.Drawing.Point(611, 1);
            this.p_botoes_barcos_j2.Name = "p_botoes_barcos_j2";
            this.p_botoes_barcos_j2.Size = new System.Drawing.Size(196, 255);
            this.p_botoes_barcos_j2.TabIndex = 3;
            // 
            // b_pronto
            // 
            this.b_pronto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pronto.Location = new System.Drawing.Point(297, 114);
            this.b_pronto.Name = "b_pronto";
            this.b_pronto.Size = new System.Drawing.Size(196, 79);
            this.b_pronto.TabIndex = 4;
            this.b_pronto.Text = "PRONTO!";
            this.b_pronto.UseVisualStyleBackColor = true;
            this.b_pronto.Click += new System.EventHandler(this.B_pronto_Click);
            // 
            // p_campo_1
            // 
            this.p_campo_1.Location = new System.Drawing.Point(1, 262);
            this.p_campo_1.Name = "p_campo_1";
            this.p_campo_1.Size = new System.Drawing.Size(400, 400);
            this.p_campo_1.TabIndex = 5;
            // 
            // p_campo_2
            // 
            this.p_campo_2.Location = new System.Drawing.Point(407, 262);
            this.p_campo_2.Name = "p_campo_2";
            this.p_campo_2.Size = new System.Drawing.Size(400, 400);
            this.p_campo_2.TabIndex = 6;
            // 
            // status_jogo
            // 
            this.status_jogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_jogo.Location = new System.Drawing.Point(317, 41);
            this.status_jogo.Name = "status_jogo";
            this.status_jogo.Size = new System.Drawing.Size(160, 57);
            this.status_jogo.TabIndex = 7;
            this.status_jogo.Text = "Definindo jogo: jogador 1";
            this.status_jogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // janela_jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 664);
            this.Controls.Add(this.status_jogo);
            this.Controls.Add(this.p_campo_2);
            this.Controls.Add(this.p_campo_1);
            this.Controls.Add(this.b_pronto);
            this.Controls.Add(this.p_botoes_barcos_j2);
            this.Controls.Add(this.p_num_barcos_j2);
            this.Controls.Add(this.p_num_barcos_j1);
            this.Controls.Add(this.p_botoes_barcos_j1);
            this.Name = "janela_jogo";
            this.Text = "janela_jogo";
            this.Load += new System.EventHandler(this.Janela_jogo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_botoes_barcos_j1;
        private System.Windows.Forms.Panel p_num_barcos_j1;
        private System.Windows.Forms.Panel p_num_barcos_j2;
        private System.Windows.Forms.Panel p_botoes_barcos_j2;
        private System.Windows.Forms.Button b_pronto;
        private System.Windows.Forms.Panel p_campo_1;
        private System.Windows.Forms.Panel p_campo_2;
        private System.Windows.Forms.Label status_jogo;
    }
}

