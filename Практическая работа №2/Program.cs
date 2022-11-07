namespace Практическая_работа__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int per = 9;
            do
            {
                Console.WriteLine("\"Угадай число\" - 1\n" +
                "Таблица умножения - 2\n" +
                "? - 3\n" +
                "Выйти из программы - 0");
                Console.ReadLine();
                per = Convert.ToInt32(Console.ReadLine());
                if (per == 1)
                {
                    UgadaiNumber();
                } 
                if (per == 2)
                {
                    Umnojenie();
                }
                //Umnojenie();
            } while (per != 0);
        }
        static void UgadaiNumber()
        {
            int ugadNum = 0, value = 0;
            Random rnd = new Random();
            value = rnd.Next(0, 20);
            do
            {
                Console.WriteLine("Игра\"Угадай число\"\nНапишите число от 0 до 20");
                ugadNum = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
                if (ugadNum != value)
                {
                    Console.WriteLine("Неверное число");
                }
                if (ugadNum < value)
                {
                    Console.WriteLine("Возьмите больше");
                }
                if (ugadNum > value)
                {
                    Console.WriteLine("Возьмите меньше");
                }
                if (ugadNum == value)
                {
                    Console.WriteLine("Вы угадали!");
                }
            } while (ugadNum != value);
        }
        static void Umnojenie()
        {
            Console.WriteLine("Таблица умножения");
            Console.WriteLine("2*1=2\t3*1=3\t4*1=4\t5*1=5\t6*1=6\t7*1=7\t8*1=8\t9*1=9\n" +
                "2*2=4\t3*2=6\t4*2=8\t5*2=10\t6*2=12\t7*2=14\t8*2=16\t9*2=18\n" +
                "2*3=6\t3*3=9\t4*3=12\t5*3=15\t6*3=18\t7*3=21\t8*3=24\t9*3=27\n" +
                "2*4=8\t3*4=12\t4*4=16\t5*4=20\t6*4=24\t7*4=28\t8*4=32\t9*4=36\n" +
                "2*5=10\t3*5=15\t4*5=20\t5*5=25\t6*5=30\t7*5=35\t8*5=40\t9*5=45\n" +
                "2*6=12\t3*6=18\t4*6=24\t5*6=30\t6*6=36\t7*6=42\t8*6=48\t9*6=54\n" +
                "2*7=14\t3*7=21\t4*7=28\t5*7=35\t6*7=42\t7*7=49\t8*7=56\t9*7=63\n" +
                "2*8=16\t3*8=24\t4*8=32\t5*8=40\t6*8=48\t7*8=56\t8*8=64\t9*8=72\n" +
                "2*9=18\t3*9=27\t4*9=36\t5*9=45\t6*9=54\t7*9=63\t8*9=72\t9*9=81\n" +
                "2*10=20\t3*10=30\t4*10=40\t5*10=50\t6*10=60\t7*10=70\t8*10=80\t9*10=90");
        }
        static void Delenie()
        {

        }
    }
}