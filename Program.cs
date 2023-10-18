using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano
{
    class Program
    {
        // Массивы с частотами нот в каждой октаве
        static int[] firstOctave = new int[] { 261, 294, 329, 349, 392, 440, 493 };
        static int[] secondOctave = new int[] { 523, 587, 659, 698, 783, 880, 987 };
        static int[] thirdOctave = new int[] { 1046, 1175, 1318, 1397, 1567, 1760, 1976 };

        static int currentOctave = 1; // Текущая октава

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в пианино!");
            Console.WriteLine("Используйте клавиши ASDFGHJ для белых клавиш и WETYU для черных клавиш");
            Console.WriteLine("Для изменения октавы используйте клавиши F1, F2, F3 и т.д.");

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Escape)
                        break;
                    else if (key.Key == ConsoleKey.F1)
                        currentOctave = 1;
                    else if (key.Key == ConsoleKey.F2)
                        currentOctave = 2;
                    else if (key.Key == ConsoleKey.F3)
                        currentOctave = 3;
                    else
                        PlaySound(key.Key);
                }
            }
        }

        static void PlaySound(ConsoleKey key)
        {
            int[] octave = GetCurrentOctave();
            switch (key)
            {
                case ConsoleKey.A:
                    Console.Beep(octave[0], 500);
                    break;
                case ConsoleKey.S:
                    Console.Beep(octave[1], 500);
                    break;
                case ConsoleKey.D:
                    Console.Beep(octave[2], 500);
                    break;
                case ConsoleKey.F:
                    Console.Beep(octave[3], 500);
                    break;
                case ConsoleKey.G:
                    Console.Beep(octave[4], 500);
                    break;
                case ConsoleKey.H:
                    Console.Beep(octave[5], 500);
                    break;
                case ConsoleKey.J:
                    Console.Beep(octave[6], 500);
                    break;
                case ConsoleKey.W:
                    Console.Beep(octave[0] * 17 / 16, 500);
                    break;
                case ConsoleKey.E:
                    Console.Beep(octave[1] * 17 / 16, 500);
                    break;
                case ConsoleKey.T:
                    Console.Beep(octave[2] * 17 / 16, 500);
                    break;
                case ConsoleKey.Y:
                    Console.Beep(octave[3] * 17 / 16, 500);
                    break;
                case ConsoleKey.U:
                    Console.Beep(octave[4] * 17 / 16, 500);
                    break;
                default:
                    break;
            }
        }

        static int[] GetCurrentOctave()
        {
            switch (currentOctave)
            {
                case 1:
                    return firstOctave;
                case 2:
                    return secondOctave;
                case 3:
                    return thirdOctave;
                default:
                    return firstOctave;
            }
        }
    }
}