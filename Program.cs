using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4popitka
{
    internal class Program
    {
        //Домашние адреса
        static string specialtyFile = @"C:\Users\Hitech\OneDrive\Рабочий стол\КУРСОВАЯ\KOD\4\4popitka\txt\Specialty.txt";
        static string departmentFile = @"C:\Users\Hitech\OneDrive\Рабочий стол\КУРСОВАЯ\KOD\4\4popitka\txt\Department.txt";
        static string disciplineFile = @"C:\Users\Hitech\OneDrive\Рабочий стол\КУРСОВАЯ\KOD\4\4popitka\txt\Discipline.txt";
        static void Main(string[] args)
        {
            Metodist metodist = new Metodist();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("============== МЕНЮ ==============");
                Console.WriteLine(" 1. Ввести специальности");
                Console.WriteLine(" 2. Показать специальности");
                Console.WriteLine(" 3. Поиск лабораторных часов");
                Console.WriteLine(" 4. Удалить специальность");
                Console.WriteLine("----------------------------------");
                Console.WriteLine(" 5. Ввести кафедры");
                Console.WriteLine(" 6. Показать кафедры");
                Console.WriteLine(" 7. Семестровая нагрузка по спец.");
                Console.WriteLine("----------------------------------");
                Console.WriteLine(" 8. Ввести дисциплины");
                Console.WriteLine(" 9. Показать дисциплины");
                Console.WriteLine("10. Поиск часов по дисциплине");
                Console.WriteLine("11. Дисциплины по кафедре");
                Console.WriteLine("12. Мин/Макс продолжительность");
                Console.WriteLine("13. Экзамены/Зачёты/Курсовые");
                Console.WriteLine("==================================");
                Console.WriteLine("14. Выход");
                Console.WriteLine("==================================");
                Console.Write("Введите номер действия: ");
                

                string choice;
                choice = Console.ReadLine();
                //{
                //    Console.WriteLine("Ошибка: введите корректное число.");
                //    Console.ReadKey();
                //    continue;
                //}

                Console.WriteLine(); // Отступ
                switch (choice)
                {
                    case "1":
                        metodist.AddSpecialty();
                        Console.Read();
                        Console.Clear();
                        break;
                    case "2":
                        metodist.PrintSpecialties();
                        Console.Read();
                        Console.Clear();
                        break;
                    case "3":
                        metodist.GetLabHoursBySpecialty();
                        Console.Read();
                        Console.Clear();
                        break;
                    case "4":
                        metodist.DeleteSpecialty();
                        Console.Read();
                        Console.Clear();
                        break;
                    case "5":
                        metodist.AddDepartment();
                        Console.Read();
                        Console.Clear();
                        break;
                    case "6":
                        metodist.PrintDepartments();
                        Console.Read();
                        Console.Clear();
                        break;
                    case "7":
                        metodist.SemNagr();
                        Console.Read();
                        Console.Clear();
                        break;
                    case "8":
                        metodist.AddDiscipline();
                        Console.Read();
                        Console.Clear();
                        break;
                    case "9":
                        metodist.PrintDisciplines();
                        Console.Read();
                        Console.Clear();
                        break;
                    case "10":
                        metodist.PokazatChasyPoDiscipline();
                        Console.Read();
                        Console.Clear();
                        break;
                    case "11":
                        metodist.GetDisciplinesByDepartment();
                        Console.Read();
                        Console.Clear();
                        break;
                    case "12":
                        metodist.GetMinMaxDisciplineHours();
                        Console.Read();
                        Console.Clear();
                        break;
                    case "13":
                        metodist.GetTotalExamsAndTestsByDepartment();
                        Console.Read();
                        Console.Clear();
                        break;
                    case "0":
                        return;
                    default: Console.WriteLine("Неверный выбор."); break;
                }
            }
            Console.ReadLine();
        }
    }
}

