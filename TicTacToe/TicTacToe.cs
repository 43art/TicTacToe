using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe {
    public partial class TicTacToe : Form {
        public TicTacToe() {
            InitializeComponent();
        }

        bool firstShag = true;

        int R = 0;
        Field field;

        char curPlayer = 'X';
        Node bot;

        Button[,] B;
        int sb = 50;
        int sl = 5;
        public TicTacToe(int size) {
            R = size;
            B = new Button[R, R];
            field = new Field(R);
            AddNewButtons();
            InitializeComponent();
        }


        private void Game_Click(object sender, EventArgs e) {
            Button temp = (Button)sender;
            (int i, int j) pair = ((int, int))temp.Tag;

            if (field.M[pair.i, pair.j] == ' ') {
                field.M[pair.i, pair.j] = curPlayer;
                temp.Text = curPlayer.ToString();

                if (curPlayer == 'X')
                    curPlayer = 'O';
                else
                    curPlayer = 'X';

                TurnLabel.Text = "Ход игрока: " + curPlayer;

                if (field.CheckToWin() != ' ') {
                    TurnLabel.Text = "Победитель: " + field.CheckToWin();
                    for (int i = 0; i < R; ++i)
                        for (int j = 0; j < R; ++j)
                            B[i, j].Enabled = false;
                }
                else if (!field.CheckToStop()) {
                    TurnLabel.Text = "Ничья!";
                }
                else {
                    // BOT
                    if (firstShag) {
                        firstShag = false;
                        NewGameButton.Enabled = true;
                        bot = new Node(field.Copy(), 'O', 0, (pair.i, pair.j));
                        bot.MakeChilds();
                        bot.ExecuteValue();
                    }
                    else {
                        bot = bot.EqualField(field);
                    }
                    (int i, int j, Node nextNode) p = bot.NextHod();
                    bot = p.nextNode;
                    field.M[p.i, p.j] = curPlayer;
                    B[p.i, p.j].Text = curPlayer.ToString();

                    // ENDBOT

                    if (curPlayer == 'X')
                        curPlayer = 'O';
                    else
                        curPlayer = 'X';
                    TurnLabel.Text = "Ход игрока: " + curPlayer;

                    if (field.CheckToWin() != ' ') {
                        TurnLabel.Text = "Победитель: " + field.CheckToWin();
                        for (int i = 0; i < R; ++i)
                            for (int j = 0; j < R; ++j)
                                B[i, j].Enabled = false;
                    }
                    else if (!field.CheckToStop()) {
                        TurnLabel.Text = "Ничья!";
                    }
                }
            }

        }

        // Create field with new buttons for game
        private void AddNewButtons() {
            for (int i = 0; i < R; ++i) {
                for (int j = 0; j < R; ++j) {
                    B[i, j] = new Button {
                        BackColor = Color.LightGray,
                        ForeColor = Color.Black,
                        Text = " ",
                        Width = sb,
                        Height = sb,
                        Left = i * sb + (i + 1) * sl,
                        Top = j * sb + (j + 1) * sl,
                        Tag = (i, j),

                    };
                    B[i, j].Click += Game_Click;
                    this.Controls.Add(B[i, j]);
                }
            }
        }

        // Start new game
        private void NewGame() {
            for (int i = 0; i < R; ++i) {
                for (int j = 0; j < R; ++j) {
                    field.M[i, j] = ' ';
                    B[i, j].Text = " ";
                    B[i, j].Enabled = true;
                }
            }
            NewGameButton.Enabled = false;
            curPlayer = 'X';
            TurnLabel.Text = "Ход игрока: " + curPlayer;
            firstShag = true;
            Node.nextDeep = Node.startDeep;
            bot = null;
        }

        private void NewGameButton_Click(object sender, EventArgs e) {
            NewGame();
        }

        private void ChangeSizeGameButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
