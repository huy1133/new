using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        public const int BOARD_SIZE = 3;    //kích thước cố định
        public Cell[,] board;               //ma trận 2 chiều
        //Khởi tạo bảng rỗng
        public Board()
        {
            board = new Cell[BOARD_SIZE, BOARD_SIZE];
            for (int i = 0; i < BOARD_SIZE; i++) //i la dòng
            {
                for (int j = 0; j < BOARD_SIZE; j++)//j là cột
                {
                    board[i, j] = new Cell();
                }
            }
        }
        //Hiển thị bảng
        public void printBoard()
        {
            int fieldNumber = 1;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    if (board[i, j].isEmpty())
                        Console.Write(fieldNumber); //hiện số
                    else
                    {
                        if ((char)(board[i, j].getFieldState()) == 'X')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write((char)(board[i, j].getFieldState()));  //X hay
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    fieldNumber++;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    if (j < BOARD_SIZE - 1) Console.Write(" | ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
   
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------");
            Console.ForegroundColor = ConsoleColor.White;
        }
        //Xác định tạo độ
        public void putMark(Player player, int fieldNumber)
        {
            int verticalY = (fieldNumber - 1) / BOARD_SIZE;
            int horizontalX = (fieldNumber - 1) % BOARD_SIZE;
            if (fieldNumber < 1 || fieldNumber > 9)
            {
                Console.WriteLine("Invalid Input. Please enter number between 1-9!");
                putMark(player, player.takeTurn());
            }
            else if (board[verticalY, horizontalX].isEmpty())
                board[verticalY, horizontalX].markField(player);
            else
            {
                Console.WriteLine("This place is taken. Select the field again: ");
                putMark(player, player.takeTurn());
            }
        }
        //Xóa bảng
        public void clearBoard()
        {
            Console.Clear();
        }

    }
}
