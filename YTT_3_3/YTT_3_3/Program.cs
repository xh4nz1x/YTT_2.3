/* УП Практическая работа 2.3
Задание 3. Создайте класс Calculation , в котором будет одно свойство calculationLine.
методы: SetCalculationLine который будет который будет изменять значение свойства,
SetLastSymbolCalculationLine который будет в конец строки прибавлять символ,
GetCalculationLine который будет выводить значение свойства, GetLastSymbol получение последнего символа,
DeleteLastSymbol удаление последнего символа из строки */

namespace YTT_3_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculation calculation = new Calculation("Прослушайте текст и напишите сжатое изложение");

            bool work1 = true;
            while (work1)
            {
                Console.WriteLine();
                Console.Write("| Главное меню |\n1 - Вывести строку \n2 - Редактировать строку \n3 - Последний символ строки \n4 - Выход \n\nВыберите нужное действие: ");
                int menu1 = Convert.ToInt32(Console.ReadLine());
                switch (menu1)
                {
                    case 1:
                        calculation.GetCalculationLine();
                        break;
                    case 2:
                        Console.Write($"Введите новую строку: ");
                        string newCalculationLine = Console.ReadLine();
                        calculation.SetCalculationLine(newCalculationLine);
                        break;
                    case 3:
                        bool work2 = true;
                        while (work2)
                        {
                            Console.WriteLine();
                            Console.Write("| Меню последнего символа строки |\n1 - Прибавить символ к строке \n2 - Вывести последний символ \n3 - Удалить последний символ \n4 - Назад \n\nВыберите нужное действие: ");
                            int menu2 = Convert.ToInt32(Console.ReadLine());
                            switch (menu2)
                            {
                                case 1:
                                    Console.Write("Введите символ (char): ");
                                    char newLastSymbol = Convert.ToChar(Console.ReadLine());
                                    calculation.SetLastSymbolCalculationLine(newLastSymbol);
                                    break;
                                case 2:
                                    calculation.GetLastSymbol();
                                    break;
                                case 3:
                                    calculation.DeleteLastSymbol();
                                    break;
                                case 4:
                                    work2 = false;
                                    break;
                                default:
                                    Console.WriteLine("-----\nНеизвестное действие!");
                                    break;
                            }
                        }
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

    class Calculation
    {
        public string CalculationLine { get; set; }

        public Calculation()
        {
            CalculationLine = "text";
        }

        public Calculation(string calculationLine)
        {
            CalculationLine = calculationLine;
        }

        public void SetCalculationLine(string newCalculationLine)
        {
            CalculationLine = newCalculationLine;
            Console.WriteLine("Строка успешно изменена!");
        }

        public void SetLastSymbolCalculationLine(char newLastSymbol)
        {
            CalculationLine += Convert.ToString(newLastSymbol);
            Console.WriteLine("Символ успешно добавлен!");
        }

        public void GetCalculationLine()
        {
            Console.WriteLine($"Строка: {CalculationLine}");
        }

        public void GetLastSymbol()
        {
            Console.WriteLine($"Последний символ строки: {CalculationLine[CalculationLine.Length - 1]}");
        }

        public void DeleteLastSymbol()
        {
            int index = CalculationLine.Length - 1;
            CalculationLine = CalculationLine.Remove(index);
            Console.WriteLine($"Последний символ строки успешно удален!");
        }
    }
}