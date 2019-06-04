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

        //Labels e Botões gerados dentro dos paineis.
        Label[,] painel_de_quadrados_do_jogador = new Label[10, 10]; // Armazenei cada label gerada dentro de uma matriz.
        Label[,] painel_de_quadrados_do_computador = new Label[10, 10]; // Armazenei cada label gerada dentro de uma matriz.
        Label[] valoresBotoes = new Label[4]; // Armazenei cada label gerada dentro de uma matriz.
        Button[] BotoesNavios = new Button[5];// Botões gerados com cada Navio.

        // Numero de Colunas, linhas e tamanho dos quadrados dentro de painel.
        const int RowCount = 10;
        const int ColumnCount = 10;
        const int tamanho_quadrados = 40;

        //Booleans que determinam o estado de jogo e informações de jogadas
        Boolean definindo_jogo = false;
        Boolean jogando_jogo = false;
        bool botao_ativo_tres_contador = false;
        bool[,] quadradoMarcado = new bool[10, 10]; // Um Boolean pra salvar os quadrados marcados.



        //Valores Armazenados
        string[] QuantidadeVidasNavios = new string[4] { "5", "4", "3", "2"};//Mensagem de Texto dos Botões.
        string[] quantidade_de_navios = new string[4] { "1", "1", "2", "1" };//Mensagem de Texto dos Botões.
        int[] botao_ativo = new int[4] { 1, 1, 1, 1 };
        int[] QuantidadePosicoesNavios = new int[4] { 5, 4, 3, 2};//Valor que cada Botão gerado representa pra posições dos navios.
        int Botao_Navio_Selecionado = 0;//Recebe o valor do botão selecionado.
        int posicaoX_do_navio = 0;
        int posicaoY_do_navio = 0;

        //Botão para iniciar o jogo e gerar os botões com os navios.
        private void Botao_Start(object sender, EventArgs e)
        {
            definindo_jogo = true;
            if (definindo_jogo == true)
            {
                for (int i = 0; i < RowCount; i++)// Esses Laços for geram a tabela de labels.
                {
                    for (int j = 0; j < ColumnCount; j++)
                    {
                        if (Botao_Definir_Jogo.Text == "Redefinir/Recomeçar")
                        {
                            painel_de_quadrados_do_jogador[i, j].Name = $"({i},{j})";
                            painel_de_quadrados_do_jogador[i, j].BackColor = Color.Aqua;
                            quadradoMarcado[i, j] = false;
                            Botao_Navio_Selecionado = 0;
                            valoresBotoes[0].Text = "1";
                            valoresBotoes[1].Text = "1";
                            valoresBotoes[2].Text = "2";
                            valoresBotoes[3].Text = "1";
                            botao_ativo[0] = 1;
                            botao_ativo[1] = 1;
                            botao_ativo[2] = 1;
                            botao_ativo[3] = 1;
                            botao_ativo_tres_contador = false;
                        }
                        else
                        {
                            painel_de_quadrados_do_jogador[i, j] = new Label
                            {
                                Name = $"({i},{j})",
                                Size = new Size(tamanho_quadrados, tamanho_quadrados),
                                Location = new Point(i * tamanho_quadrados, j * tamanho_quadrados),
                                BackColor = Color.Aqua
                            };

                            painel_de_quadrados_do_computador[i, j] = new Label
                            {
                                Name = $"({i},{j})",
                                Size = new Size(tamanho_quadrados, tamanho_quadrados),
                                Location = new Point(i * tamanho_quadrados, j * tamanho_quadrados),
                                BackColor = Color.Aqua
                            };
                            painel_de_quadrados_do_jogador[i, j].Click += Selecionar_navios; // Adiciona o painel de quadrados para o jagador.
                            quadradoMarcado[i, j] = false;// Deixei como padrão para todas as Labels False, quando cliacado muda para true, identifica os quadrados marcados
                            PainelJogo.Controls.Add(painel_de_quadrados_do_jogador[i, j]); // Adiciona o segundo painel de quadrados no Form 1 onde ficaram os navios do COM.
                            computador_jogo.Controls.Add(painel_de_quadrados_do_computador[i, j]);
                        }
                    }
                }
                for (int i = 0; i < 4; i++)
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

                    valoresBotoes[i] = new Label()
                    {
                        Name = $"(label {i})",
                        Size = new Size(25, 30),
                        Location = new Point(0, 20 + (i * 60)),
                        BackColor = Color.White,
                        Text = quantidade_de_navios[i],
                        Font = new Font ("Arial", 16, FontStyle.Bold)
                    };
                    panel2.Controls.Add(valoresBotoes[i]);
                }
                Botao_Definir_Jogo.Text = "Redefinir/Recomeçar";
            }
        }

        //Para cada botão de navio eles retornam um valor x.
        private void Botao_Navios(object sender, EventArgs e)
        {
            Button clicarBotao = (Button)sender;
            Botao_Navio_Selecionado = QuantidadePosicoesNavios[clicarBotao.Location.Y / 60];
        }

        //Aqui é da onde são tirados os valores de cada quadrado da tabala do jogo. 
        private void Selecionar_navios(object sender, System.EventArgs e)
        {
            Label lbl = (Label)sender;//Ele chama a Label clicada.
            Color color = lbl.BackColor;//Pela lb clicada ele extrai os valores para Color e Local
            Point local = lbl.Location;
            //Pelo botão selecionado ele escolhe qual if seguir, falta limitar as direções possiveis.
            if (definindo_jogo == true)
            {
                if (Botao_Navio_Selecionado == 5)
                {
                    if (color == System.Drawing.Color.Aqua & botao_ativo[0] <= 5)
                    {
                        if (botao_ativo[0] == 1)
                        {
                            color = System.Drawing.Color.Black;
                            quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados] = true; // Pela localização X e Y divididos pelo tamanho do quadrado chego no i e j.
                            botao_ativo[0] += 1;
                            posicaoX_do_navio = lbl.Location.X;
                            posicaoY_do_navio = lbl.Location.Y;
                            Console.WriteLine(posicaoX_do_navio);
                        }
                        else if ((posicaoX_do_navio + tamanho_quadrados * (botao_ativo[0] - 1) == lbl.Location.X || posicaoX_do_navio - tamanho_quadrados * (botao_ativo[0] - 1) == lbl.Location.X) & posicaoY_do_navio == lbl.Location.Y)
                        {
                            color = System.Drawing.Color.Black;
                            quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados] = true; // Pela localização X e Y divididos pelo tamanho do quadrado chego no i e j.
                            botao_ativo[0] += 1;
                        }
                        else if ((posicaoY_do_navio + tamanho_quadrados * (botao_ativo[0] - 1) == lbl.Location.Y || posicaoY_do_navio - tamanho_quadrados * (botao_ativo[0] - 1) == lbl.Location.Y) & posicaoX_do_navio == lbl.Location.X)
                        {
                            color = System.Drawing.Color.Black;
                            quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados] = true; // Pela localização X e Y divididos pelo tamanho do quadrado chego no i e j.
                            botao_ativo[0] += 1;
                        }
                    }
                    if (botao_ativo[0] == 6)
                    {
                        valoresBotoes[0].Text = "0";
                        posicaoX_do_navio = 0;
                        posicaoY_do_navio = 0;
                    }
                    lbl.BackColor = color;
                    Console.WriteLine(lbl.Location);
                }
                else if (Botao_Navio_Selecionado == 4)
                {
                    if (color == System.Drawing.Color.Aqua & botao_ativo[1] <= 4)
                    {
                        if (botao_ativo[1] == 1)
                        {
                            color = System.Drawing.Color.Black;
                            quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados] = true; // Pela localização X e Y divididos pelo tamanho do quadrado chego no i e j.
                            botao_ativo[1] += 1;
                            posicaoX_do_navio = lbl.Location.X;
                            posicaoY_do_navio = lbl.Location.Y;
                            Console.WriteLine(posicaoX_do_navio);
                        }
                        else if ((posicaoX_do_navio + tamanho_quadrados * (botao_ativo[1] - 1) == lbl.Location.X || posicaoX_do_navio - tamanho_quadrados * (botao_ativo[1] - 1) == lbl.Location.X) & posicaoY_do_navio == lbl.Location.Y)
                        {
                            color = System.Drawing.Color.Black;
                            quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados] = true; // Pela localização X e Y divididos pelo tamanho do quadrado chego no i e j.
                            botao_ativo[1] += 1;
                        }
                        else if ((posicaoY_do_navio + tamanho_quadrados * (botao_ativo[1] - 1) == lbl.Location.Y || posicaoY_do_navio - tamanho_quadrados * (botao_ativo[1] - 1) == lbl.Location.Y) & posicaoX_do_navio == lbl.Location.X)
                        {
                            color = System.Drawing.Color.Black;
                            quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados] = true; // Pela localização X e Y divididos pelo tamanho do quadrado chego no i e j.
                            botao_ativo[1] += 1;
                        }
                    }
                    if (botao_ativo[1] == 5)
                    {
                        valoresBotoes[1].Text = "0";
                    }
                    lbl.BackColor = color;
                    Console.WriteLine(lbl.Location);
                }
                else if (Botao_Navio_Selecionado == 3 & botao_ativo[2] <= 3 & botao_ativo_tres_contador == false)
                {
                    if (color == System.Drawing.Color.Aqua)
                    {
                        color = System.Drawing.Color.Black;
                        quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados] = true;
                        botao_ativo[2] += 1;
                    }
                    if (botao_ativo[2] == 4)
                    {
                        botao_ativo_tres_contador = true;
                        botao_ativo[2] = 1;
                        valoresBotoes[2].Text = "1";
                    }
                    lbl.BackColor = color;
                    Console.WriteLine(lbl.Location);
                }
                else if (Botao_Navio_Selecionado == 3 & botao_ativo[2] <= 3 & botao_ativo_tres_contador == true)
                {
                    if (color == System.Drawing.Color.Aqua)
                    {
                        color = System.Drawing.Color.Black;
                        quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados] = true;
                        botao_ativo[2] += 1;
                    }
                    if (botao_ativo[2] == 4)
                    {
                        valoresBotoes[2].Text = "0";
                    }
                    lbl.BackColor = color;
                    Console.WriteLine(lbl.Location);
                }
                else if (Botao_Navio_Selecionado == 2 & botao_ativo[3] <= 2)
                {
                    if (color == System.Drawing.Color.Aqua)
                    {
                        color = System.Drawing.Color.Black;
                        quadradoMarcado[lbl.Location.X / tamanho_quadrados, lbl.Location.Y / tamanho_quadrados] = true;
                        botao_ativo[3] += 1;
                    }
                    if (botao_ativo[3] == 3)
                    {
                        valoresBotoes[3].Text = "0";
                    }
                    lbl.BackColor = color;
                    Console.WriteLine(lbl.Location);
                }
            }            
        }

        private void Botao_Comecar_Jogo_Click(object sender, EventArgs e)
        {
            if (botao_ativo[0] == 6 & botao_ativo[1] == 5 & botao_ativo[2] == 4 & botao_ativo[3] == 3 & botao_ativo_tres_contador == true)
            {
                for (int i = 0; i < RowCount; i++)// Esses Laços for geram a tabela de labels.
                {
                    for (int j = 0; j < ColumnCount; j++)
                    {
                        painel_de_quadrados_do_jogador[i, j].BackColor = Color.White;
                    }
                }
                definindo_jogo = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

