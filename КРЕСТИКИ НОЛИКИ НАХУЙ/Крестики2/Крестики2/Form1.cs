using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики2
{
    public partial class Form1 : Form
    {
        private Button[,] buttons;
        private int[,] board; // 0 - пусто, 1 - крестик, 2 - нолик
        private bool playerTurn = true; // true - ход игрока, false - ход компьютера

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            buttons = new Button[3, 3];
            board = new int[3, 3];

            // Создаем кнопки для поля
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Location = new Point(i * 100, j * 100);
                    buttons[i, j].Size = new Size(100, 100);
                    buttons[i, j].Font = new Font("Arial", 48);
                    buttons[i, j].Click += ButtonClick;
                    Controls.Add(buttons[i, j]);
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int row = (button.Location.Y / 100);
            int col = (button.Location.X / 100);

            if (playerTurn && board[row, col] == 0)
            {
                board[row, col] = 1; // Крестик
                button.Text = "X";
                button.Enabled = false;

                playerTurn = false; // Ход компьютера
                CheckWinner();
                ComputerTurn();
            }
        }

        private void ComputerTurn()
        {
            Random random = new Random();
            int row, col;
            do
            {
                row = random.Next(3);
                col = random.Next(3);
            } while (board[row, col] != 0);

            board[row, col] = 2; // Нолик
            buttons[row, col].Text = "O";
            buttons[row, col].Enabled = false;

            playerTurn = true; // Ход игрока
            CheckWinner();
        }

        private void CheckWinner()
        {
            // Проверка строк
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != 0)
                {
                    ShowResult(board[i, 0] == 1 ? "Вы победили!" : "Вы проиграли!");
                    Application.Restart();
                    return;
                }
            }

            // Проверка столбцов
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == board[1, j] && board[1, j] == board[2, j] && board[0, j] != 0)
                {
                    ShowResult(board[0, j] == 1 ? "Вы победили!" : "Вы проиграли!");
                    Application.Restart();
                    return;
                }
            }

            // Проверка диагоналей
            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0) ||
                (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != 0))
            {
                ShowResult(board[1, 1] == 1 ? "Вы победили!" : "Вы проиграли!");
                 Application.Restart();
                return;
            }

            // Проверка ничьей
            bool isDraw = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 0)
                    {
                        isDraw = false;
                        break;
                    }
                }
                if (!isDraw) break;
            }

            if (isDraw)
            {
                ShowResult("Ничья!");
            }
        }

        private void ShowResult(string message)
        {
            MessageBox.Show(message);
            foreach (Button button in buttons)
            {
                button.Enabled = false;
            }
        }
    }
}
