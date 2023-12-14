using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SchoolSystem
{
    public class AdminInterface : GeneralInterface
    {
        public Admin Admin;

        public void AddUser()
        {
            var newUser = Console.ReadLine();
            File.WriteAllText("Users.txt", newContent);
        }
        public void CreateAttendance()
        {
            var attendance = new string[{"Дата", "День недели", "Предмет"}, 49];
            for (int i = 1; i < attendance.GetLength(1);  i++)
            {
                if (i == 2 || i == 10 || i == 18 || i == 26 || i == 34|| i == 42)
                {
                    Console.WriteLine("Введите дату");
                    attendance[0, i] = Console.ReadLine();
                }
                if (i == 2 || i == 10 || i == 18 || i == 26 || i == 34 || i == 42)
                {
                    Console.WriteLine("Введите день недели");
                    attendance[1, i] = Console.ReadLine();
                }
                Console.WriteLine("Введите предмет");
                attendance[2, i] = Console.ReadLine();
            }

            StreamWriter writer = new StreamWriter("Attendance.txt");

            for (int j = 0; j < attendance.GetLength(1); j++)
            {
                writer.WriteLine(array[0, j] + array[1, j] + array[2, j]);
            }                                                 
        }
        public void CreateAStatementOfAssessments()
        {
            var attendance = new string[{ "Дата", "Предмет", "Оценка" }, 1000];
            for (int i = 1; i < attendance.GetLength(1); i++)
            {
                Console.WriteLine("Введите дату");
                attendance[0, i] = Console.ReadLine();

                
                Console.WriteLine("Введите предмет");
                attendance[1, i] = Console.ReadLine();
                

                Console.WriteLine("Введите оценку");
                attendance[2, i] = Console.ReadLine();

                Console.WriteLine("Закончить выставление оценок? да/нет");
                if (Console.ReadLine == "да")
                    break;
            }

            StreamWriter writer = new StreamWriter("Attendance.txt");

            for (int j = 0; j < attendance.GetLength(1); j++)
            {
                writer.WriteLine(array[0, j] + array[1, j] + array[2, j]);
            }
        }
        public void CancelUser()
        {
            string[] lines = File.ReadAllLines("Users.txt");

            string[] menuItems = new string[lines.Length + 1];
            for (int i = 0; i < lines.Length + 1; i++)
            {
                menuItems[i] = lines[i + 1].Split(' '){ 0};
            }
            menuItems[lines.Length + 1] = "Выход";

            Console.WriteLine("Удаление пользователя");
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
                                Console.WriteLine("Выбран выход из пункта: Удаление пользователя");
                                return;
                            default:
                                Console.WriteLine($"Выбран пункт {menuItems[index]}");
                                for (int i = menuItems[index]; i < lines.Length - 1; i++)
                                {
                                    lines[i] = lines[i + 1];
                                }
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
