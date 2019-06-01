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
        Boolean definindo_jogo = false;
        Boolean jogando_jogo = false;


        //Valores Armazenados
        Label[,] quadradoGlobal = new Label[10, 10]; // Armazenei cada label gerada dentro de uma matriz.
        bool[,] quadradoMarcado = new bool[10, 10]; // Um Boolean pra salvar os quadrados marcados.
        Button[] BotoesNavios = new Button[5];
        string[] QuantidadeNavios = new string[5] { "5", "4", "3", "3", "2" };

        private void Botao_Start(object sender, EventArgs e)
        {
            definindo_jogo = true;

            if (definindo_jogo == true)
            {
                for (int i = 0; i < RowCount; i++)// Esses Laços for geram a tabela de labels que mudam de cor.
                {
                    for (int j = 0; j < ColumnCount; j++)
                    {
                        quadradoGlobal[i, j] = new Label
                        {
                            Name = $"({i},{j})",
                            Size = new Size(30, 30),
                            Location = new Point(i * 30, j * 30),
                            BackColor = Color.White
                        };
                        quadradoGlobal[i, j].Click += Selecionar_navios;
                        quadradoMarcado[i, j] = false;// Deixei como padrão para todas as Labels False, quando cliacado muda para true
                        PainelJogo.Controls.Add(quadradoGlobal[i, j]);
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    BotoesNavios[i] = new Button()
                    {
                        Location = new Point(0, i * 30),
                        Name = "button1",
                        Size = new System.Drawing.Size(196, 30),
                        TabIndex = 1,
                        Text = QuantidadeNavios[i],
                        UseVisualStyleBackColor = true
                     };
                    panel1.Controls.Add(BotoesNavios[i]);
                    
                }
            }
        }



        private void Selecionar_navios(object sender, System.EventArgs e)
        {
            Label lbl = (Label)sender;//Ele chama a Label clickada, pelo menos foi o que entendi
            Color color = lbl.BackColor;//Pela lb clicada ele extrai os valores para Color e Local
            Point local = lbl.Location;

            if (color == System.Drawing.Color.White)
            {
                color = System.Drawing.Color.Black;
                quadradoMarcado[lbl.Location.X / 30, lbl.Location.Y / 30] = true;
                Console.WriteLine(quadradoMarcado[lbl.Location.X / 30, lbl.Location.Y / 30]);
            }
            else if (color == System.Drawing.Color.Black)
            {
                color = System.Drawing.Color.Red;
                Console.WriteLine(quadradoMarcado[lbl.Location.X / 30, lbl.Location.Y / 30]);
            }
            else
            {
                color = System.Drawing.Color.White;
                Console.WriteLine(quadradoMarcado[lbl.Location.X / 30, lbl.Location.Y / 30]);
            }
            lbl.BackColor = color;
            Console.WriteLine(lbl.Location);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

