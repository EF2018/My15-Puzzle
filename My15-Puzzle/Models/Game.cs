using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My15_Puzzle.Models
{
    public class Game
    {
        public int size = 4;//размерность игрового поля
        public Position CurCell;//выбранная ячейка
        public Position[][] ArrGame;//Матрица игрового поля
        public int step = 1;
        public string UserName;

        /// <summary>
        /// Обновление игры
        /// </summary>
        public void InitGame()
        {
            ArrGame = new Position[size][];
            int number = 0;

            for (int i = 0; i < size; i++)
            {
                ArrGame[i] = new Position[size];
                for (int j = 0; j < size; j++)
                {
                    ArrGame[i][j] = new Position(i + 1, j + 1, (number + 1).ToString());
                    number++;
                }
            }
            ArrGame[size - 1][size - 1].Name = "";//инициализация пустого поля 
        }



        /// <summary>
        /// Поиск пустой ячейки в соседях от выбранной
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public void FindEmptyInNeighborCells()
        {
            //слева от выбранной
            try
            {
                if (ArrGame[CurCell.Y - 1][CurCell.X - 1 - 1].Name == "")
                {
                    ArrGame[CurCell.Y - 1][CurCell.X - 1 - 1].Name = ArrGame[CurCell.Y - 1][CurCell.X - 1].Name;
                    ArrGame[CurCell.Y - 1][CurCell.X - 1].Name = "";
                    step++;
                }
            }
            catch (Exception)
            {
            }

            //справа от выбранной
            try
            {
                if (ArrGame[CurCell.Y - 1][CurCell.X - 1 + 1].Name == "")
                {
                    ArrGame[CurCell.Y - 1][CurCell.X - 1 + 1].Name = ArrGame[CurCell.Y - 1][CurCell.X - 1].Name;
                    ArrGame[CurCell.Y - 1][CurCell.X - 1].Name = "";
                    step++;
                }
            }
            catch (Exception)
            {
            }

            //сверху
            try
            {
                if (ArrGame[CurCell.Y - 1 - 1][CurCell.X - 1].Name == "")
                {
                    ArrGame[CurCell.Y - 1 - 1][CurCell.X - 1].Name = ArrGame[CurCell.Y - 1][CurCell.X - 1].Name;
                    ArrGame[CurCell.Y - 1][CurCell.X - 1].Name = "";
                    step++;
                }
            }
            catch (Exception)
            {
            }

            //снизу
            try
            {
                if (ArrGame[CurCell.Y - 1 + 1][CurCell.X - 1].Name == "")
                {
                    ArrGame[CurCell.Y - 1 + 1][CurCell.X - 1].Name = ArrGame[CurCell.Y - 1][CurCell.X - 1].Name;
                    ArrGame[CurCell.Y - 1][CurCell.X - 1].Name = "";
                    step++;
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Поиск координат выбранной ячейки
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public void FindCoordCurCell(int number)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (ArrGame[i][j].Name == number.ToString())
                    {
                        CurCell = new Position(j + 1, i + 1, number.ToString());
                    }
                }
            }
        }
    }
}