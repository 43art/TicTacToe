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
    public partial class GameSize : Form {
        public GameSize() {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e) {
            try {
                int gameSize = Convert.ToInt32(GameSizeTextBox.Text);
                if (gameSize < 3 || gameSize > 5) {
                    MessageBox.Show("Введите корректную размерность (3, 4, 5)");
                }
                else {
                    TicTacToe game = new TicTacToe(gameSize);
                    game.Show();
                    Visible = false;
                }
            }
            catch {
                MessageBox.Show("Введите корректную размерность (3, 4, 5)");
            }
        }
    }
}
