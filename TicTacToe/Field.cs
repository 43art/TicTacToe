using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class Field {
        public char[,] M;
        public int Size;

        public Field(int size) {
            this.Size = size;
            M = new char[size, size];
            for (int i = 0; i < size; ++i) {
                for (int j = 0; j < size; ++j) {
                    M[i, j] = ' ';
                }
            }
        }

        // false - все занято, true - есть место
        public bool CheckToStop() {
            bool res = false;

            for (int i = 0; i < Size; ++i) {
                for (int j = 0; j < Size; ++j) {
                    if (M[i, j] == ' ') {
                        res = true;
                        break;
                    }
                }
                if (res)
                    break;
            }

            return res;
        }

        // ' ' - нет победителя, 'X' | 'O' - победители
        public char CheckToWin() {
            char result = ' ';
            for (int i = 0; i < Size; ++i) {
                // Горизонтальные линии
                result = M[i, 0];
                for (int j = 0; j < Size; ++j) {
                    if (M[i, j] != result)
                        result = ' ';
                }
                if (result != ' ')
                    break;

                // Вертикальные линии
                result = M[0, i];
                for (int j = 0; j < Size; ++j) {
                    if (M[j, i] != result)
                        result = ' ';
                }
                if (result != ' ')
                    break;

                // Диагональная линия с ЛВ в ПН
                result = M[0, 0];
                for (int j = 0; j < Size; ++j) {
                    if (M[j, j] != result)
                        result = ' ';
                }
                if (result != ' ')
                    break;

                // Диагональняа линия с ПВ в ЛН
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

        public Field Copy() {
            Field clone = new Field(Size);
            for (int i = 0; i < Size; ++i)
                for (int j = 0; j < Size; ++j)
                    clone.M[i, j] = M[i, j];
            return clone;
        }

        public bool Raven(Field f) {
            bool res = true;
            for (int i = 0; i < Size; ++i) {
                for (int j = 0; j < Size; ++j) {
                    if (M[i, j] != f.M[i, j])
                        res = false;
                }
            }
            return res;
        }
    }
}
