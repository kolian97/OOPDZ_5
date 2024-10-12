//Доработайте программу калькулятор реализовав выбор действий и вывод результатов на экран
//в цикле так чтобы калькулятор мог работать до тех пор пока пользователь не нажмет отмена или введёт пустую строку.
namespace OOPDZ_5
{
    internal class Program
    {
        //static void Calculator_GotResult(object sendler, EventArgs eventArgs)
        //{
        //    Console.WriteLine($"{((Calculator)sendler).Result}");
        //}
        static void Calculator_GotResultTwo(object sendler, EventArgs eventArgs)
        {
            Console.WriteLine($"result = {((Calculator)sendler).Result}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Правила ввода: 1)вводится знак 2)вводится число.Напр /20 " +
                "Если пользователь первым символов введет ' ' программа завершится. " +
                "Если пользователь первым символов введет l вернется предыдущее значение");
            ICalc calc = new Calculator();

            //calc.GotResult += Calculator_GotResult;
            calc.GotResult += Calculator_GotResultTwo;

            //calc.Sum(12);
            //calc.Substruct(7);
            //calc.Multiply(13);
            //calc.CancelLast();
            //calc.Divide(14);


            char operation = ' ';

            while (true)
            {
                string? name = Console.ReadLine();
                int init;
                operation = name[0];
                if (operation.Equals('l'))
                {
                    calc.CancelLast();
                    continue;

                }
                if (operation.Equals(' '))
                    break;
                if (name.Length > 1 && Int32.TryParse(name.Substring(1), out init))
                {

                    int number = int.Parse(name.Substring(1));
                    if (operation.Equals('+'))
                    {
                        calc.Sum(number);
                        continue;
                    }
                    if (operation.Equals('-'))
                    {
                        calc.Substruct(number);
                        continue;
                    }
                    if (operation.Equals('/'))
                    {
                        calc.Divide(number);
                        continue;
                    }
                    if (operation.Equals('*'))
                    {
                        calc.Multiply(number);
                        continue;
                    }
                    else
                    { Console.WriteLine("Не корректный ввод"); }
                }


            }


        }
    }
}