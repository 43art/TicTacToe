using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class Node {
        public static char bot = 'O';
        public static int startDeep = 2;

        public static int nextDeep = 2;
        public static int stepDeep = 2;

        public List<Node> _childs;
        private int _value;
        private char _player;
        private Field _field;
        private int _deep;
        private (int i, int j) _hod;

        public Node(Field m, char player, int deep, (int, int) hod) {
            _field = m;
            _player = player;
            _childs = new List<Node>();
            _deep = deep;
            _hod = hod;
        }

        public void ExecuteValue() {
            char ctw = _field.CheckToWin();
            if (!_field.CheckToStop()) {
                _value = 0;
            }
            else {
                if (ctw == bot) {
                    _value = 10;
                }
                else {
                    if (ctw != ' ') {
                        _value = -10;
                    }
                    else {
                        if (_deep < nextDeep) {
                            if (_childs.Count > 0) {
                                foreach (Node node in _childs) {
                                    node.MakeChilds();
                                    node.ExecuteValue();
                                }
                                if (_player == bot) {
                                    foreach (Node node in _childs) {
                                        _value = Math.Max(_value, node._value);
                                    }
                                }
                                else {
                                    foreach (Node node in _childs) {
                                        _value = Math.Min(_value, node._value);
                                    }
                                }
                            }
                            else {
                                _value = 0;
                            }
                        }
                        else {
                            _value = 0;
                        }
                    }
                }
            }
        }

        public void MakeChilds() {
            for (int i = 0; i < _field.Size; ++i) {
                for (int j = 0; j < _field.Size; ++j) {
                    if (_field.M[i, j] == ' ') {
                        Field temp = _field.Copy();
                        temp.M[i, j] = _player;
                        if (_player == 'X')
                            _childs.Add(new Node(temp, 'O', _deep + 1, (i, j)));
                        else
                            _childs.Add(new Node(temp, 'X', _deep + 1, (i, j)));
                    }
                }
            }
        }

        public (int, int, Node) NextMove() {
            (int i, int j) bestHod = (-1, -1);
            Node nextNode = null;
            if (_childs.Count > 0) {
                nextNode = _childs[0];
                bestHod = _childs[0]._hod;
                int maxValue = _childs[0]._value;
                foreach (Node node in _childs) {
                    if (node._value > maxValue) {
                        maxValue = node._value;
                        bestHod = node._hod;
                        nextNode = node;
                    }
                }
            }
            if (nextNode._deep == nextDeep - 1) {
                nextDeep += stepDeep;
                nextNode.MakeChilds();
                nextNode.ExecuteValue();
            }
            return (bestHod.i, bestHod.j, nextNode);
        }

        public Node EqualField(Field f) {
            Node res = null;
            foreach (Node node in _childs) {
                if (node._field.Equal(f))
                    res = node;
            }
            return res;
        }
    }
}
