using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class Field {
        public char[,] M;
        public int Size;

        // Init field
        public Field(int size) {
            this.Size = size;
            M = new char[size, size];
            for (int i = 0; i < size; ++i) {
                for (int j = 0; j < size; ++j) {
                    M[i, j] = ' ';
                }
            }
        }

        // Check free cell
        public bool CheckToStop() {
            bool resoult = false;

            for (int i = 0; i < Size; ++i) {
                for (int j = 0; j < Size; ++j) {
                    if (M[i, j] == ' ') {
                        resoult = true;
                        break;
                    }
                }
                if (resoult)
                    break;
            }
            return resoult;
        }

        // Check winner. ' ' - draw, 'X' - X winner, 'O' - O winner
        public char CheckToWin() {
            char result = ' ';
            for (int i = 0; i < Size; ++i) {
                // Check horizontal lines
                result = M[i, 0];
                for (int j = 0; j < Size; ++j) {
                    if (M[i, j] != result)
                        result = ' ';
                }
                if (result != ' ')
                    break;

                // Check vertical lines
                result = M[0, i];
                for (int j = 0; j < Size; ++j) {
                    if (M[j, i] != result)
                        result = ' ';
                }
                if (result != ' ')
                    break;

                // Check diagonal lines left top right down
                result = M[0, 0];
                for (int j = 0; j < Size; ++j) {
                    if (M[j, j] != result)
                        result = ' ';
                }
                if (result != ' ')
                    break;

                // Check diagonal lines left down right top
                result = M[0, Size - 1];
                for (int j = 0; j < Size; ++j) {
                    if (M[j, Size - j - 1] != result)
                        result = ' ';
                }
                if (result != ' ')
                    break;
            }
            return result;
        }

        // Copy GameField
        public Field Copy() {
            Field clone = new Field(Size);
            for (int i = 0; i < Size; ++i)
                for (int j = 0; j < Size; ++j)
                    clone.M[i, j] = M[i, j];
            return clone;
        }

        // Check equal GameFields
        public bool Equal(Field f) {
            bool resoult = true;
            for (int i = 0; i < Size; ++i) {
                for (int j = 0; j < Size; ++j) {
                    if (M[i, j] != f.M[i, j])
                        resoult = false;
                }
            }
            return resoult;
        }
    }
}
