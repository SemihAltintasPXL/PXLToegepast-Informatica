using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace DominationGame
{
    public class Board
    {
        private Block[,] _blocks;

        public Board(double sizeBlock)
        {
            _blocks = new Block[8, 8]; // grootte van het block moet je kunnen wijzigen op 1 plaars
            for (int i = 0; i < _blocks.GetLength(0); i++)
            {
                for (int j = 0; j < _blocks.GetLength(1); j++)
                {
                    _blocks[i, j] = new Block(i, j, sizeBlock);
                }
            }
        }

        public void ClaimBlocks(int row, int col, Player player)
        {
            if (!_blocks[row, col].IsEmpty())
            {
                throw new DominationException("semih mag niet block zetten");
            }
            else
            { // onderstaande code kan nog korter(juiste hulpvariabelen gebruiken) 2 keer bijna identieke code 
                if (player == Player.red)
                {
                    if (_blocks[row + 1, col].IsEmpty()) // eerst controleren of een onderliggend blockje wel bestaat
                        // als je op de onderste rij klikt is er bvb geen onderliggend blockje

                    {
                        _blocks[row, col].Owner = player;
                        _blocks[row + 1, col].Owner = player;
                    } // als block niet leeg is DomintationException opgooien
                }
                else
                {
                    if (_blocks[row, col].IsEmpty())
                    {
                        _blocks[row, col].Owner = player;
                        _blocks[row, col + 1].Owner = player;
                    }// als block niet leeg is DominationException opgooien
                }
            }
        }

        public void DisplayOn(Canvas canvas)
        {
            foreach (var block in _blocks)
            {
                block.DisplayOn(canvas);
            }
        }

        public bool HasMoveLeftFor(Player player)
        {
            //bool moveLeft = false;
            // voor de rode speler => blauw controleren maar je moet wel alle rijen doen maar laatste kolom niet
            // voor de blauwe speler => rood controleren maar hier oet je alle kolommen doen buiten de laatte


            if (player == Player.red)
            {
                for (int rij = 0; rij < _blocks.GetLength(0); rij++)
                {
                    for (int kol = 0; kol < _blocks.GetLength(1) - 1; kol++)
                    {
                        if (_blocks[rij, kol].IsEmpty() && _blocks[rij, kol + 1].IsEmpty())
                        {
                            return true; // methode wordt gestopt bij jou gaat men nog verder controleren maar dit is  niet nodig
                        }
                    }
                }
            }
            else
            {
                for (int rij = 0; rij < _blocks.GetLength(0) - 1; rij++)
                {
                    for (int kol = 0; kol < _blocks.GetLength(1) - 1; kol++)
                    {
                        if (_blocks[rij, kol].IsEmpty() && _blocks[rij + 1, kol].IsEmpty())
                        {
                            return true;
                        }
                    }

                }
            }
            return false;
        }
    }
}
