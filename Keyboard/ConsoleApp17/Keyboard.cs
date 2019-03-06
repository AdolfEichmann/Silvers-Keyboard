using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Keyboard
    {
        public static char KeySelect(Key i = Key.A)
        {
            Console.SetBufferSize(211, 91);
            ConsoleKey move = 0;
            do
            {
                move = Console.ReadKey().Key;
                switch (move)
                {
                    case ConsoleKey.UpArrow:
                        if ((int)i == 0)
                            i = (Key)1;
                        if ((int)i == 1)
                            i = (Key)0;
                        if ((int)i <= 36 && (int)i >= 27)
                            i -= 26;
                        else if ((int)i <= 26 && (int)i >= 1)
                            i += 26;
                        break;
                    case ConsoleKey.DownArrow:
                        if ((int)i <= 36 && (int)i >= 27)
                            i -= 26;
                        else if ((int)i <= 26 && (int)i >= 1)
                            i += 26;
                        else if ((int)i == 0)
                            i = (Key)1;
                        break;
                    case ConsoleKey.RightArrow:
                        if ((int)i == 36)
                            i = (Key)27;
                        else if ((int)i == 26)
                            i = (Key)1;
                        else if ((int)i == 0)
                            i = (Key)0;
                        else
                            i = (Key)(((int)i + 1));
                        break;
                    case ConsoleKey.LeftArrow:
                        if ((int)i == 27)
                            i = (Key)36;
                        else if((int)i == 1)
                            i = (Key) 26;
                        else if ((int)i == 0)
                            i = (Key)0;
                        else
                        i = (Key)(((int)i - 1));
                        break;
                    default:
                        break;
                }
                if ((int)i > 36)
                    i = (Key)36;
                DisplayMenu(i);
            }
            while (move != ConsoleKey.Enter);
            return Convert(i);
        }

        public static string print()
        {
            int i = 0;
            char printed;
            string name = "";
            do
            {
                printed = Keyboard.KeySelect();
                if (printed != '±')
                {
                    name += printed;
                    Console.SetCursorPosition(i, 10);
                    Console.Write(name[i]);
                    i++;
                }
            } while (printed != '±' || i < name.Length - 1);
            Console.CursorVisible = false;
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - name.Length - 6) / 2, Console.WindowHeight / 2);
            Console.Write($"YOUR NAME IS: {name}");
            Console.ReadKey();
            return name;
        }

        private static void DisplayMenu(Key selected)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(Console.BufferWidth / 2 - 5, 0);
            Console.Write("The game of");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 10, 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("▄▄▄ ▄▄▄▄ ▄▄ ▄▄▄   ▄▄▄");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 10, 2);
            Console.Write(" █▓▄ █▓  ▄▄  █▓█▄██▓");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 10, 3);
            Console.Write(" █▓▀██▓  █▓  █▓ ▀ █▓");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 10, 4);
            Console.Write("▄█▓▄ █▓▄ █▓ ▄█▓▄ ▄█▓▄");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 1, 6);
            Console.ResetColor();
            Console.Write("By:");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 4, 7);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Amit Nave");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 7, 8);
            Console.Write("Amit Silverman");
            Console.ResetColor();


            DisplayKeyboardButton("EXIT", selected==Key.FINISH, 10, Console.BufferHeight / 2 - 5);
            DisplayKeyboardButton("A", selected == Key.A, 10, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("B", selected == Key.B, 14, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("C", selected == Key.C, 18, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("D", selected == Key.D, 22, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("E", selected == Key.E, 26, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("F", selected == Key.F, 30, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("G", selected == Key.G, 34, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("H", selected == Key.H, 38, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("I", selected == Key.I, 42, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("J", selected == Key.J, 46, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("K", selected == Key.K, 50, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("L", selected == Key.L, 54, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("M", selected == Key.M, 58, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("N", selected == Key.N, 62, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("O", selected == Key.O, 66, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("P", selected == Key.P, 70, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("Q", selected == Key.Q, 74, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("R", selected == Key.R, 78, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("S", selected == Key.S, 82, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("T", selected == Key.T, 86, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("U", selected == Key.U, 90, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("V", selected == Key.V, 94, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("W", selected == Key.W, 98, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("X", selected == Key.X, 102, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("Y", selected == Key.Y, 106, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("Z", selected == Key.Z, 110, Console.BufferHeight / 2 - 2);
            DisplayKeyboardButton("1", selected == Key.ONE, 42, Console.BufferHeight / 2 - 3);
            DisplayKeyboardButton("2", selected == Key.TWO, 46, Console.BufferHeight / 2 - 3);
            DisplayKeyboardButton("3", selected == Key.THREE, 50, Console.BufferHeight / 2 - 3);
            DisplayKeyboardButton("4", selected == Key.FOUR, 54, Console.BufferHeight / 2 - 3);
            DisplayKeyboardButton("5", selected == Key.FIVE, 58, Console.BufferHeight / 2 - 3);
            DisplayKeyboardButton("6", selected == Key.SIX, 62, Console.BufferHeight / 2 - 3);
            DisplayKeyboardButton("7", selected == Key.SEVEN, 66, Console.BufferHeight / 2 - 3);
            DisplayKeyboardButton("8", selected == Key.EIGHT, 70, Console.BufferHeight / 2 - 3);
            DisplayKeyboardButton("9", selected == Key.NINE, 74, Console.BufferHeight / 2 - 3);
            DisplayKeyboardButton("0", selected == Key.ZERO, 78, Console.BufferHeight / 2 - 3);
        }
        private static void DisplayKeyboardButton(string name, bool selected, int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = selected ? ConsoleColor.Black : ConsoleColor.White;
            Console.BackgroundColor = selected ? ConsoleColor.Yellow : ConsoleColor.Black;
            Console.Write(name);
            Console.ResetColor();

        }


        public static char Convert(Key key)
        {
            Key i = key;
            switch (i)
            {
                case (Key)1:
                    return 'a';
                case (Key)2:
                    return 'b';
                case (Key)3:
                    return 'c';
                case (Key)4:
                    return 'd';
                case (Key)5:
                    return 'e';
                case (Key)6:
                    return 'f';
                case (Key)7:
                    return 'g';
                case (Key)8:
                    return 'h';
                case (Key)9:
                    return 'i';
                case (Key)10:
                    return 'j';
                case (Key)11:
                    return 'k';
                case (Key)12:
                    return 'l';
                case (Key)13:
                    return 'm';
                case (Key)14:
                    return 'n';
                case (Key)15:
                    return 'o';
                case (Key)16:
                    return 'p';
                case (Key)17:
                    return 'q';
                case (Key)18:
                    return 'r';
                case (Key)19:
                    return 's';
                case (Key)20:
                    return 't';
                case (Key)21:
                    return 'u';
                case (Key)22:
                    return 'v';
                case (Key)23:
                    return 'w';
                case (Key)24:
                    return 'x';
                case (Key)25:
                    return 'y';
                case (Key)26:
                    return 'z';
                case (Key) 27:
                    return '1';
                case (Key)28:
                    return '2';
                case (Key)29:
                    return '3';
                case (Key)30:
                    return '4';
                case (Key)31:
                    return '5';
                case (Key)32:
                    return '6';
                case (Key)33:
                    return '7';
                case (Key)34:
                    return '8';
                case (Key)35:
                    return '9';
                case (Key)36:
                    return '0';
                case (Key)0:
                    return '±';
                default:
                    return '—';
            }
        }
    }

    public enum Key
    {
        FINISH = 0,
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5,
        F = 6,
        G = 7,
        H = 8,
        I = 9,
        J = 10,
        K = 11,
        L = 12,
        M = 13,
        N = 14,
        O = 15,
        P = 16,
        Q = 17,
        R = 18,
        S = 19,
        T = 20,
        U = 21,
        V = 22,
        W = 23,
        X = 24,
        Y = 25,
        Z = 26,
        ONE = 27,
        TWO = 28,
        THREE = 29,
        FOUR = 30,
        FIVE = 31,
        SIX = 32,
        SEVEN = 33,
        EIGHT = 34,
        NINE = 35,
        ZERO = 36
    }
}
