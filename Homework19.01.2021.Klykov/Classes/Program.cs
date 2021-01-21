using System;
using static System.Console;
namespace Homework19._01._2021.Klykov
{
    public class Homework1
    {
        //Сосчитать количество пробелов в сообщении, введенном пользователем
        public void Zadanie1()
        {
            string message;
            do
            {
                message = Console.ReadLine();
            } while (message[message.Length - 1] != '.');
            int count = 0;
            int i = 0;
            while (message.IndexOf(' ', i) != -1)
            {
                count++;
                i += message.IndexOf(' ') + 1;
            }
            Console.WriteLine(count);
        }

        //Ввести номер трамвайного билета и проверить, является ли оно счасливым
        public void Zadanie2()
        {
            Console.WriteLine("Введите номер билета:");
            int[] count1 = new int[3];
            int[] count2 = new int[3];
            int summ = 0;
            string str;
            str = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                count1[i] = (int)str[i];
                count2[count2.Length - i - 1] = (int)str[str.Length - i - 1];
            }
            for (int i = 0; i < 3; i++)
            {
                summ += count1[i] - count2[i];
            }
            if (summ == 0)
            {
                Console.WriteLine("Билет счастливый");
            }
            else
            {
                Console.WriteLine("Самый обыкновенный билет");
            }
        }

        //Перевод символов из нижнего регистра в верхний и наоборот
        public void Zadanie3()
        {
            string str;
            str = Console.ReadLine();
            char[] strToChar = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i]) >= 'a')
                {
                    strToChar[i] -= (char)32;
                }
                else
                {
                    strToChar[i] += (char)32;
                }
            }
            str = strToChar.ToString();
            Console.WriteLine(strToChar);
        }

        //Вывести все целые числа от А до В в количестве, равное значению очередного значения. 
        //Вывод очередного значения производится на новой строчке 
        public void Zadanie4()
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.Write("\n");
            }
        }

        //Инвертировать и прочитать заданное значение.
        public void Zadanie5()
        {
            string N;
            N = Console.ReadLine();
            char[] Nreverse = new char[N.Length];
            for (int i = 0; i < N.Length; i++)
            {
                Nreverse[i] = N[N.Length - i - 1];
            }
            Console.WriteLine(Nreverse);
        }
    }

    public partial class Homework2
    {
        //7. Использование ключевого слова partial для создания частичного класса
        public partial class Car
        {
            //1. Объявление закрытых полей
            private string company;
            private string kindOfCar;
            private string number;
            private int maxSpeed;
            private double timeTo100Km;
            private double gasMileage;
            //4. Статические поля, представляющие общие характеристики данного класса
            static double discount;
            static string carType;
            static double cost = 10000000;
            //5. Перегруженные конструкторы
            public Car()
            {
                company = "BMW";
                kindOfCar = "X5";
                number = "1BBB11";
                maxSpeed = 240;
                timeTo100Km = 5.2;
                gasMileage = 6.4;
            }
            public Car(string c, string koC)
            {
                company = c;
                koC = kindOfCar;
                number = "1BBB11";
                maxSpeed = 240;
                timeTo100Km = 5.2;
                gasMileage = 6.4;
            }

            //6. Статический конструктор
            static Car()
            {
                discount = 0.1;
                carType = "Легковая";
                cost -= cost * discount;
            }
            public Car(string numb, int maxSp, double t100, double gas100)
            {
                company = "BMW";
                kindOfCar = "X5";
                number = numb;
                maxSpeed = maxSp;
                timeTo100Km = t100;
                gasMileage = gas100;
            }
            //2. Гетеры и сетеры
            public string GetCompany()
            {
                return company;
            }

            public void SetCompany(string newNum)
            {
                company = newNum;
            }
            public string GetKindOfCar()
            {
                return kindOfCar;
            }
            public void SetKindOfCar(string newNum)
            {
                kindOfCar = newNum;
            }
            public string GetNumber()
            {
                return number;
            }
            public void SetNumber(string newNum)
            {
                number = newNum;
            }
            public int GetMaxSpeed()
            {
                return maxSpeed;
            }
            public void SetMaxSpeed(int newNum)
            {
                maxSpeed = newNum;
            }
            public double GetTimeTo100Km()
            {
                return timeTo100Km;
            }
            public void SetTimeTo100Km(double newNum)
            {
                timeTo100Km = newNum;
            }

            public double GetGasMileage()
            {
                return gasMileage;
            }
            public void SetGasMileage(double newNum)
            {
                gasMileage = newNum;
            }

            //3. Метод, в котором передаются значения по ссылке
            public void resetCar(ref Car ourCar)
            {
                ourCar.SetCompany("none");
                ourCar.SetKindOfCar("none");
                ourCar.SetMaxSpeed(100);
                ourCar.SetNumber("0AAA00");
                ourCar.SetTimeTo100Km(10);
                ourCar.SetGasMileage(5);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Homework1 Hm = new Homework1();
            Hm.Zadanie1();
            Hm.Zadanie2();
            Hm.Zadanie3();
            Hm.Zadanie4();
            Hm.Zadanie5();
            ReadKey();

            Homework2.Car[] massCar = new Homework2.Car[5];
            for(int i = 0; i < 5; i++)
            {
                massCar[i] = new Homework2.Car();
                //7. Метод из другого файла
                massCar[i].coutCar();
                massCar[i].resetCar(ref massCar[i]);
                massCar[i].coutCar();
            }
            ReadKey();
        }

    }
}
