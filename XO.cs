// Создайте приложение «Крестики-Нолики». Пользователь играет с компьютером.
// При старте игры случайным образом выбирается, кто ходит первым. Игроки ходят по очереди.
// Игра может закончиться победой одного из игроков или ничьей. Используйте механизмы пространств имён.
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Game
{
    class Cursor
    {
        public int x { get; set; }
        public int y { get; set; }
        public Cursor()
        {
            x = 0;
            y = 0;
        }
    }
    class Program
    {
        const int W = 33;
        const int H = 33;
        
        static char[,] x1 = new char[5, 5] { {'░', ' ',  ' ', ' ', '░' }, {' ', '░',  ' ', '░', ' ' }, { ' ', ' ', '░', ' ', ' ' }, {' ', '░',  ' ', '░', ' '}, {'░', ' ', ' ', ' ', '░' } };
        static char[,] x2 = new char[5, 5] { { '█', ' ', ' ', ' ', '█' }, { ' ', '█', ' ', '█', ' ' }, { ' ', ' ', '█', ' ', ' ' }, { ' ', '█', ' ', '█', ' ' }, { '█', ' ', ' ', ' ', '█' } };
        static char[,] o1 = new char[5, 5] { { ' ', '░', '░', '░', ' ' }, { '░', ' ', ' ', ' ', '░' }, { '░', ' ', ' ', ' ', '░' }, { '░', ' ', ' ', ' ', '░' }, { ' ', '░', '░', '░', ' ' } };
        static char[,] o2 = new char[5, 5] { { ' ', '█', '█', '█', ' ' }, { '█', ' ', ' ', ' ', '█' }, { '█', ' ', ' ', ' ', '█' }, { '█', ' ', ' ', ' ', '█' }, { ' ', '█', '█', '█', ' ' } };

        static void Start()
        {
            Console.CursorVisible = false;
            Console.Title = "Крестики-Нолики";
            Console.WindowWidth = W;
            Console.BufferWidth = W;
            Console.WindowHeight = H;
            Console.BufferHeight = H;
        }
        static void setXO(int i, int j, int p, char[,] screen)
        {
            if (p == 0)
            {
                if (i == 0)
                {
                    if (j == 0)
                    {
                        for(int m = 7; m < 7 + 5; m++)
                        {
                            for (int n = 6; n < 6 + 5; n++)
                            {
                                screen[m, n] = x2[m - 7, n - 6];
                            }
                        }
                    }
                    else if (j == 1)
                    {
                        for (int m = 7; m < 7 + 5; m++)
                        {
                            for (int n = 14; n < 14 + 5; n++)
                            {
                                screen[m, n] = x2[m - 7, n - 14];
                            }
                        }
                    }
                    else if (j == 2)
                    {
                        for (int m = 7; m < 7 + 5; m++)
                        {
                            for (int n = 22; n < 22 + 5; n++)
                            {
                                screen[m, n] = x2[m - 7, n - 22];
                            }
                        }
                    }
                }
                else if (i == 1)
                {
                    if (j == 0)
                    {
                        for (int m = 15; m < 15 + 5; m++)
                        {
                            for (int n = 6; n < 6 + 5; n++)
                            {
                                screen[m, n] = x2[m - 15, n - 6];
                            }
                        }
                    }
                    else if (j == 1)
                    {
                        for (int m = 15; m < 15 + 5; m++)
                        {
                            for (int n = 14; n < 14 + 5; n++)
                            {
                                screen[m, n] = x2[m - 15, n - 14];
                            }
                        }
                    }
                    else if (j == 2)
                    {
                        for (int m = 15; m < 15 + 5; m++)
                        {
                            for (int n = 22; n < 22 + 5; n++)
                            {
                                screen[m, n] = x2[m - 15, n - 22];
                            }
                        }
                    }
                }
                else if (i == 2)
                {
                    if (j == 0)
                    {
                        for (int m = 23; m < 23 + 5; m++)
                        {
                            for (int n = 6; n < 6 + 5; n++)
                            {
                                screen[m, n] = x2[m - 23, n - 6];
                            }
                        }
                    }
                    else if (j == 1)
                    {
                        for (int m = 23; m < 23 + 5; m++)
                        {
                            for (int n = 14; n < 14 + 5; n++)
                            {
                                screen[m, n] = x2[m - 23, n - 14];
                            }
                        }
                    }
                    else if (j == 2)
                    {
                        for (int m = 23; m < 23 + 5; m++)
                        {
                            for (int n = 22; n < 22 + 5; n++)
                            {
                                screen[m, n] = x2[m - 23, n - 22];
                            }
                        }
                    }
                }
            }
            else if (p == 1)
            {
                if (i == 0)
                {
                    if (j == 0)
                    {
                        for (int m = 7; m < 7 + 5; m++)
                        {
                            for (int n = 6; n < 6 + 5; n++)
                            {
                                screen[m, n] = o2[m - 7, n - 6];
                            }
                        }
                    }
                    else if (j == 1)
                    {
                        for (int m = 7; m < 7 + 5; m++)
                        {
                            for (int n = 14; n < 14 + 5; n++)
                            {
                                screen[m, n] = o2[m - 7, n - 14];
                            }
                        }
                    }
                    else if (j == 2)
                    {
                        for (int m = 7; m < 7 + 5; m++)
                        {
                            for (int n = 22; n < 22 + 5; n++)
                            {
                                screen[m, n] = o2[m - 7, n - 22];
                            }
                        }
                    }
                }
                else if (i == 1)
                {
                    if (j == 0)
                    {
                        for (int m = 15; m < 15 + 5; m++)
                        {
                            for (int n = 6; n < 6 + 5; n++)
                            {
                                screen[m, n] = o2[m - 15, n - 6];
                            }
                        }
                    }
                    else if (j == 1)
                    {
                        for (int m = 15; m < 15 + 5; m++)
                        {
                            for (int n = 14; n < 14 + 5; n++)
                            {
                                screen[m, n] = o2[m - 15, n - 14];
                            }
                        }
                    }
                    else if (j == 2)
                    {
                        for (int m = 15; m < 15 + 5; m++)
                        {
                            for (int n = 22; n < 22 + 5; n++)
                            {
                                screen[m, n] = o2[m - 15, n - 22];
                            }
                        }
                    }
                }
                else if (i == 2)
                {
                    if (j == 0)
                    {
                        for (int m = 23; m < 23 + 5; m++)
                        {
                            for (int n = 6; n < 6 + 5; n++)
                            {
                                screen[m, n] = o2[m - 23, n - 6];
                            }
                        }
                    }
                    else if (j == 1)
                    {
                        for (int m = 23; m < 23 + 5; m++)
                        {
                            for (int n = 14; n < 14 + 5; n++)
                            {
                                screen[m, n] = o2[m - 23, n - 14];
                            }
                        }
                    }
                    else if (j == 2)
                    {
                        for (int m = 23; m < 23 + 5; m++)
                        {
                            for (int n = 22; n < 22 + 5; n++)
                            {
                                screen[m, n] = o2[m - 23, n - 22];
                            }
                        }
                    }
                }
            }
        }
        static void Window(char[,] screen, string map, int?[,] field, Cursor cursor, int queue)
        {
            Console.Clear();
            for (int i = 0; i < W; i++)
            {
                for (int j = 0; j < H; j++)
                {
                    screen[i, j] = map[i * H + j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (field[i, j] == 0)
                    {
                        setXO(i, j, 0, screen);
                    }
                    else if (field[i, j] == 1)
                    {
                        setXO(i, j, 1, screen);
                    }
                }
            }
            for (int m = cursor.x * 8 + 7; m < (cursor.x * 8 + 7 + 5); m++)
            {
                for (int n = cursor.y * 8 + 6; n < (cursor.y * 8 + 6 + 5); n++)
                {
                    screen[m, n] = o1[m - (cursor.x * 8 + 7), n - (cursor.y * 8 + 6)];
                }
            }
            for (int i = 0; i < W; i++)
            {
                for (int j = 0; j < H; j++)
                {
                    Console.Write(screen[i, j]);
                }
            }
        }
        static void WinScreen(int win)
        {
            Console.Clear();
            if (win == 0)
            {
                Console.WriteLine("O Выйграл!");
            }
            else if (win == 1)
            {
                Console.WriteLine("X Выйграл!");
            }
            else
            {
                Console.WriteLine("Ничья!");
            }
        }
        static bool Win(int queue, int?[,] field)
        {
            bool a = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (field[i, j] == null)
                    {
                        a = true;
                        break;
                    }
                }
            }
            if (!a)
            {
                WinScreen(3);
                return true;
            }
            if (field[0, 0] == 0 & field[0, 0] == field[1, 0] & field[1, 0] == field[2, 0])
            {
                WinScreen(queue);
                return true;
            }
            else if (field[0, 1] == 0 & field[0, 1] == field[1, 1] & field[1, 1] == field[2, 1])
            {
                WinScreen(queue);
                return true;
            }
            else if (field[0, 2] == 0 & field[0, 2] == field[1, 2] & field[1, 2] == field[2, 2])
            {
                WinScreen(queue);
                return true;
            }
            else if (field[0, 0] == 0 & field[0, 0] == field[0, 1] & field[0, 1] == field[0, 2])
            {
                WinScreen(queue);
                return true;
            }
            else if (field[1, 0] == 0 & field[1, 0] == field[1, 1] & field[1, 1] == field[1, 2])
            {
                WinScreen(queue);
                return true;
            }
            else if (field[2, 0] == 0 & field[2, 0] == field[2, 1] & field[2, 1] == field[2, 2])
            {
                WinScreen(queue);
                return true;
            }
            else if (field[0, 0] == 0 & field[0, 0] == field[1, 1] & field[1, 1] == field[2, 2])
            {
                WinScreen(queue);
                return true;
            }
            else if (field[2, 0] == 0 & field[2, 0] == field[2, 1] & field[2, 1] == field[0, 2])
            {
                WinScreen(queue);
                return true;
            }
            if (field[0, 0] == 1 & field[0, 0] == field[1, 0] & field[1, 0] == field[2, 0])
            {
                WinScreen(queue);
                return true;
            }
            else if (field[0, 1] == 1 & field[0, 1] == field[1, 1] & field[1, 1] == field[2, 1])
            {
                WinScreen(queue);
                return true;
            }
            else if (field[0, 2] == 1 & field[0, 2] == field[1, 2] & field[1, 2] == field[2, 2])
            {
                WinScreen(queue);
                return true;
            }
            else if (field[0, 0] == 1 & field[0, 0] == field[0, 1] & field[0, 1] == field[0, 2])
            {
                WinScreen(queue);
                return true;
            }
            else if (field[1, 0] == 1 & field[1, 0] == field[1, 1] & field[1, 1] == field[1, 2])
            {
                WinScreen(queue);
                return true;
            }
            else if (field[2, 0] == 1 & field[2, 0] == field[2, 1] & field[2, 1] == field[2, 2])
            {
                WinScreen(queue);
                return true;
            }
            else if (field[0, 0] == 1 & field[0, 0] == field[1, 1] & field[1, 1] == field[2, 2])
            {
                WinScreen(queue);
                return true;
            }
            else if (field[2, 0] == 1 & field[2, 0] == field[2, 1] & field[2, 1] == field[0, 2])
            {
                WinScreen(queue);
                return true;
            }
            return false;
        }
        static void Main()
        {
            Random random = new Random();
            string map = null;
            map += "                                 ";
            map += " │Управление : стрелки и пробел│ ";
            map += "╔═══════════════════════════════╗";
            map += "║                               ║";
            map += "║                               ║";
            map += "║                               ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║   ────────┼───────┼────────   ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║   ────────┼───────┼────────   ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║           │       │           ║";
            map += "║                               ║";
            map += "║                               ║";
            map += "║                               ║";
            map += "╚═══════════════════════════════╝";
            char[,] screen = new char[W, H];
            int?[,] field = new int?[3, 3];
            int queue = random.Next(2);
            Cursor cursor = new Cursor();
            Start();
            while (true)
            {
                if (queue == 0)
                {
                    int xR, yR;
                    do
                    {
                        xR = random.Next(3);
                        yR = random.Next(3);
                    } while (field[xR, yR] != null);
                    field[xR, yR] = queue;
                    queue++;
                    Window(screen, map, field, cursor, queue);
                    Thread.Sleep(500);
                    continue;
                }
                else
                {
                    ConsoleKey key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.LeftArrow: if (cursor.y > 0) { cursor.y--; }; break;
                        case ConsoleKey.UpArrow: if (cursor.x > 0) { cursor.x--; }; break;
                        case ConsoleKey.RightArrow: if (cursor.y < 2) { cursor.y++; }; break;
                        case ConsoleKey.DownArrow: if (cursor.x < 2) { cursor.x++; }; break;
                        case ConsoleKey.Spacebar: if (field[cursor.x, cursor.y] == null) { field[cursor.x, cursor.y] = queue; queue--; }; break;
                        default: continue;
                    }
                }
                if (Win(queue, field))
                {
                    break;
                }
                Window(screen, map, field, cursor, queue);
            }
        }
    }
}
