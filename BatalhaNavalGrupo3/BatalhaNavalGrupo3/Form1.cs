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
        public Form1()
        {
            InitializeComponent();
        }

        const int RowCount = 10;
        const int ColumnCount = 10;
        Label[,] quadradoGlobal = new Label[10, 10];
        Boolean[,] quadradoMarcado = new Boolean[10, 10];


        private void selecionar_navios(object sender, System.EventArgs e)
        {
            Label lbl = (Label)sender;
            Color color = lbl.BackColor;
            Point local = lbl.Location;

            if (color == System.Drawing.Color.White)
            {
                color = System.Drawing.Color.Black;
                quadradoMarcado[lbl.Location.X / 20, lbl.Location.Y / 20] = true;
                Console.WriteLine(quadradoMarcado[lbl.Location.X / 20, lbl.Location.Y / 20]);
            }
            else if (color == System.Drawing.Color.Black)
            {
                color = System.Drawing.Color.Red;               
                quadradoMarcado[lbl.Location.X / 20, lbl.Location.Y / 20] = true;
                Console.WriteLine(quadradoMarcado[lbl.Location.X / 20, lbl.Location.Y / 20]);
            }
            else
            {
                color = System.Drawing.Color.White;
                quadradoMarcado[lbl.Location.X / 20, lbl.Location.Y / 20] = false;
                Console.WriteLine(quadradoMarcado[lbl.Location.X / 20, lbl.Location.Y / 20]);
            }
            lbl.BackColor = color;
            Console.WriteLine(lbl.Location);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    quadradoGlobal[i, j] = new Label();
                    quadradoGlobal[i, j].Name = $"({i},{j})";
                    quadradoGlobal[i, j].Size = new Size(20, 20);
                    quadradoGlobal[i, j].Location = new Point(i * 20, j * 20);
                    quadradoGlobal[i, j].BackColor = Color.White;
                    quadradoGlobal[i, j].Click += selecionar_navios;
                    quadradoMarcado[i, j] = false;
                    panel1.Controls.Add(quadradoGlobal[i, j]);
                }
            }
        }
    }
}
