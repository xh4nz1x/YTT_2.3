/* УП Практическая работа 2.3
Задание 2. Модифицируйте класс Worker из предыдущей задачи,
сделайте все его свойства приватными, а для их чтения сделайте методы-геттеры */

namespace YTT_3_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Worker worker = new Worker("Anton", "Antonov", 100, 1);

            bool work1 = true;
            while (work1)
            {
                Console.WriteLine();
                Console.Write("| Главное меню |\n1 - Вывести информацию о работнике \n2 - Редактирование информации о работнике \n3 - Вывести зарплату работника \n4 - Выход \n\nВыберите нужное действие: ");
                int menu1 = Convert.ToInt32(Console.ReadLine());
                switch (menu1)
                {
                    case 1:
                        worker.OutputInfo();
                        break;
                    case 2:
                        bool work2 = true;
                        while (work2)
                        {
                            Console.WriteLine();
                            Console.Write("| Меню редактирования |\n1 - Изменить имя \n2 - Изменить фамилию \n3 - Изменить ставку \n4 - Изменить количество отработанных дней \n5 - Назад \n\nВыберите нужное действие: ");
                            int menu2 = Convert.ToInt32(Console.ReadLine());
                            switch (menu2)
                            {
                                case 1:
                                    Console.Write("Введите новое имя (string): ");
                                    string newName = Console.ReadLine();
                                    worker.ChangeInfo(newName, worker.GetSurname(), worker.GetRate(), worker.GetDays());
                                    break;
                                case 2:
                                    Console.Write("Введите новую фамилию (string): ");
                                    string newSurname = Console.ReadLine();
                                    worker.ChangeInfo(worker.GetName(), newSurname, worker.GetRate(), worker.GetDays());
                                    break;
                                case 3:
                                    Console.Write("Введите новую ставку (int): ");
                                    int newRate = Convert.ToInt32(Console.ReadLine());
                                    worker.ChangeInfo(worker.GetName(), worker.GetSurname(), newRate, worker.GetDays());
                                    break;
                                case 4:
                                    Console.Write("Введите новое количество отработанных дней (int): ");
                                    int newDays = Convert.ToInt32(Console.ReadLine());
                                    worker.ChangeInfo(worker.GetName(), worker.GetSurname(), worker.GetRate(), newDays);
                                    break;
                                case 5:
                                    work2 = false;
                                    break;
                                default:
                                    Console.WriteLine("-----\nНеизвестное действие!");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        worker.GetSalary();
                        break;
                    case 4:
                        work1 = false;
                        break;
                    default:
                        Console.WriteLine("-----\nНеизвестное действие!");
                        break;
                }
            }
        }
    }

    class Worker
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private int Rate { get; set; }
        private int Days { get; set; }

        public Worker()
        {
            Name = "Ivan";
            Surname = "Ivanov";
            Rate = 3000;
            Days = 20;
        }

        public Worker(string name, string surname, int rate, int days)
        {
            Name = name;
            Surname = surname;
            Rate = rate;
            Days = days;
        }

        public void ChangeInfo(string newName, string newSurname, int newRate, int newDays)
        {
            Name = newName;
            Surname = newSurname;
            Rate = newRate;
            Days = newDays;
            
            Console.WriteLine("Информация об работнике успешна изменена!");
        }

        public void GetSalary()
        {
            int salary = Days * Rate;
            Console.WriteLine($"Зарплата работника: {salary} руб.");
        }

        public void OutputInfo()
        {
            Console.WriteLine($"\nИмя работника: {Name}");
            Console.WriteLine($"Фамилия работника: {Surname}");
            Console.WriteLine($"Ставка за день работы: {Rate} руб.");
            Console.WriteLine($"Количество отработанных дней: {Days}");
        }

        public string GetName()
        {
            return Name;
        }
        public string GetSurname()
        {
            return Surname;
        }
        public int GetRate()
        {
            return Rate;
        }
        public int GetDays()
        {
            return Days;
        }
    }
}