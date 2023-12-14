using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SchoolSystem
{
    public class TeacherInterface : GeneralInterface
    {
        public Teacher Teacher;

        public void AddGrades()
        {
            string[] lines = File.ReadAllLines("Grades.txt");
            foreach (string s in lines)
                Console.WriteLine(s);

            string[] menuItems = new string[lines.Length + 1];
            for (int i = 0; i < lines.Length + 1; i++)
            {
                menuItems[i] = lines[i+1].Split(' '){0};
            }
            menuItems[lines.Length + 1] = "Выход";

            Console.WriteLine("Меню");
            Console.WriteLine();

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            while (true)
            {
                DrawMenu(menuItems, row, col, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuItems.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (index)
                        {
                            case 2:
                                Console.WriteLine("Выбран выход из пункта меню");
                                return;
                            default:
                                Console.WriteLine($"Изменяется оценка по предмету: {menuItems[index]}");
                                lines[menuItems{index}].Split(' '){1} = Console.ReadLine(); 
                                break;
                        }
                        break;
                }
            }
        }
        public void AddAttendance()
        {
            string[] lines = File.ReadAllLines("Attendance.txt");
            foreach (string s in lines)
                Console.WriteLine(s);

            string[] menuItems = new string[lines.Length + 1];
            for (int i = 0; i < lines.Length + 1; i++)
            {
                menuItems[i] = lines[i + 1].Split(' '){ 0};
            }
            menuItems[lines.Length + 1] = "Выход";

            Console.WriteLine("Меню");
            Console.WriteLine();

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            while (true)
            {
                DrawMenu(menuItems, row, col, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuItems.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (index)
                        {
                            case 2:
                                Console.WriteLine("Выбран выход из пункта меню");
                                return;
                            default:
                                Console.WriteLine($"Изменяется расписание предмета: {menuItems[index]}");
                                lines[menuItems{ index}].Split(' '){1} = Console.ReadLine();
                                break;
                        }
                        break;
                }
            }
        }
        public void AddHomework()
        {
            string[] lines = File.ReadAllLines("Homework.txt");
            foreach (string s in lines)
                Console.WriteLine(s);

            string[] menuItems = new string[lines.Length + 1];
            for (int i = 0; i < lines.Length + 1; i++)
            {
                menuItems[i] = lines[i + 1].Split(' '){ 0};
            }
            menuItems[lines.Length + 1] = "Выход";

            Console.WriteLine("Меню");
            Console.WriteLine();

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            while (true)
            {
                DrawMenu(menuItems, row, col, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuItems.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (index)
                        {
                            case 2:
                                Console.WriteLine("Выбран выход из пункта меню");
                                return;
                            default:
                                Console.WriteLine($"Изменяется домашнее задание предмета: {menuItems[index]}");
                                lines[menuItems{ index}].Split(' '){1} = Console.ReadLine();
                                break;
                        }
                        break;
                }
            }
        }

        private static void DrawMenu(string[] items, int row, int col, int index)
        {
            Console.SetCursorPosition(col, row);
            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(items[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
