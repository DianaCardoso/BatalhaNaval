using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatalhaNavalGrupo3
{
    public partial class Form1 : Form
    {
        //Variáveis Iniciais

        public Form1()
        {
            InitializeComponent();
        }

        // Numero de Colunas e linhas
        const int RowCount = 10;
        const int ColumnCount = 10;
        const int tamanho_quadrados = 40;
        Boolean definindo_jogo = false;
        Boolean jogando_jogo = false;
        int botao_ativo_cinco = 0;
        int botao_ativo_quatro = 0;
        int botao_ativo_tres = 0;
        int botao_ativo_tres_contador = 0;
        int botao_ativo_dois = 0;


        //Valores Armazenados
        Label[,] quadradoGlobal = new Label[10, 10]; // Armazenei cada label gerada dentro de uma matriz.
        bool[,] quadradoMarcado = new bool[10, 10]; // Um Boolean pra salvar os quadrados marcados.
        Button[] BotoesNavios = new Button[5];// Botões gerados com cada Navio.
        string[] QuantidadeVidasNavios = new string[5] { "5", "4", "3", "3", "2" };//Mensagem de Texto dos Botões.
        int[] QuantidadePosicoesNavios = new int[5] { 5, 4, 3, 3, 2 };//Valor que cada Botão gerado representa pra posições dos navios.
        int Botao_Navio_Selecionado = 0;//Recebe o valor do botão selecionado.

        private void Botao_Start(object sender, EventArgs e)
        {
            definindo_jogo = true;
            if (definindo_jogo == true)
            {
                for (int i = 0; i < RowCount; i++)// Esses Laços for geram a tabela de labels.
                {
                    for (int j = 0; j < ColumnCount; j++)
                    {
                        if (button1.Text == "Recomeçar")
                        {
                            quadradoGlobal[i, j].Name = $"({i},{j})";
                            quadradoGlobal[i, j].BackColor = Color.White;
                            quadradoMarcado[i, j] = false;
                            Botao_Navio_Selecionado = 0;
                            botao_ativo_cinco = 0;
                            botao_ativo_quatro = 0;
                            botao_ativo_tres = 0;
                            botao_ativo_dois = 0;
                        }
                        else
                        {
                            quadradoGlobal[i, j] = new Label
                            {
                                Name = $"({i},{j})",
                                Size = new Size(tamanho_quadrados, tamanho_quadrados),
                                Location = new Point(i * tamanho_quadrados, j * tamanho_quadrados),
                                BackColor = Color.White
                            };
                            quadradoGlobal[i, j].Click += Selecionar_navios;
                            quadradoMarcado[i, j] = false;// Deixei como padrão para todas as Labels False, quando cliacado muda para true
                            PainelJogo.Controls.Add(quadradoGlobal[i, j]);
                        }
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    BotoesNavios[i] = new Button()
                    {
                        Location = new Point(0, i * 60),
                        Name = "button1",
                        Size = new System.Drawing.Size(196, 60),
                        TabIndex = 1,
                        Text = QuantidadeVidasNavios[i],
                        UseVisualStyleBackColor = true
                     };
                    panel1.Controls.Add(BotoesNavios[i]);
                    BotoesNavios[i].Click += Botao_Navios;
                }
                button1.Text = "Recomeçar";
            }
        }

        private void Botao_Navios(object sender, EventArgs e)
        {
            Button clicarBotao = (Button)sender;
            Botao_Navio_Selecionado = QuantidadePosicoesNavios[clicarBotao.Location.Y / 60];
        }

        private void Selecionar_navios(object sender, System.EventArgs e)
        {
            Label lbl = (Label)sender;//Ele chama a Label clicada.
            Color color = lbl.BackColor;//Pela lb clicada ele extrai os valores para Color e Local
            Point local = lbl.Location;
            //Pelo botão selecionado ele escolhe qual if seguir, ainda não limitei o numero de casas que são possiveis marcar
            if (definindo_jogo == true)
            {
                if (Botao_Navio_Selecionado == 5)
                {
                    if (color == System.Drawing.Color.White & botao_ativo_cinco < 5)
                    {
                        color = System.Drawing.Color.Black;
                        quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados] = true;
                        botao_ativo_cinco += 1;
                        Console.WriteLine(quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados]);
                    }
                    lbl.BackColor = color;
                    Console.WriteLine(lbl.Location);
                }
                else if (Botao_Navio_Selecionado == 4 & botao_ativo_quatro < 4)
                {
                    if (color == System.Drawing.Color.White)
                    {
                        color = System.Drawing.Color.Black;
                        quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados] = true;
                        botao_ativo_quatro += 1;
                        Console.WriteLine(quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados]);
                    }
                    lbl.BackColor = color;
                    Console.WriteLine(lbl.Location);
                }
                else if (Botao_Navio_Selecionado == 3 & botao_ativo_tres < 3)
                {
                    if (color == System.Drawing.Color.White)
                    {
                        color = System.Drawing.Color.Black;
                        quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados] = true;
                        botao_ativo_tres += 1;
                        Console.WriteLine(quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados]);
                    }
                    lbl.BackColor = color;
                    Console.WriteLine(lbl.Location);
                }
                else if (Botao_Navio_Selecionado == 2 & botao_ativo_dois < 2)
                {
                    if (color == System.Drawing.Color.White)
                    {
                        color = System.Drawing.Color.Black;
                        quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados] = true;
                        botao_ativo_dois += 1;
                        Console.WriteLine(quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados]);
                    }
                    lbl.BackColor = color;
                    Console.WriteLine(lbl.Location);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

