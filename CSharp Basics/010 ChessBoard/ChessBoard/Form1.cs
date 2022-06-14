using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoard
{
    public partial class frmChessBoard : Form
    {
        public frmChessBoard()
        {
            InitializeComponent();
            this.Width = 640 + 10;
            this.Height = 640 + 10;
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            //This is a way
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        AddButton(i,j);
            //    }

            //}
            //This is another way

            Button[,] buttons = new Button[8,8];
            int top = 0;
            int left = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 79;
                    buttons[i, j].Height = 79;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    left += 75;
                    this.Controls.Add(buttons[i, j]);
                }
                left = 0;
                top += 75;

            }

        }




        private void AddButton(int i, int j )
        {
            Button button = new Button();
            button.Height = 80;
            button.Width = 80;
            button.Left = i * 79;
            button.Top = j * 79;
            if ((i+j) % 2 == 0)
            {
                button.BackColor = Color.White;
            }
            else
            {
                button.BackColor = Color.Black;
            }
            this.Controls.Add(button);
        }
    }
}
