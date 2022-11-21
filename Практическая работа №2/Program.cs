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
            int[] matrica = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            int oper;
            for (int i = 0; i < matrica.Length; i++)
            {
                Console.WriteLine($"{matrica[i]}\t");
            }
            Console.WriteLine("\n");
            for (int j = 0; j < matrica.Length; j++)
            {
                Console.Write($" {oper = matrica[0] * matrica[j]}\t" + 
                    $"{oper = matrica[1] * matrica[j]}\t " +
                    $"{oper = matrica[2] * matrica[j]}\t " +
                    $"{oper = matrica[3] * matrica[j]}\t " +
                    $"{oper = matrica[4] * matrica[j]}\t " +
                    $"{oper = matrica[5] * matrica[j]}\t " +
                    $"{oper = matrica[6] * matrica[j]}\t " +
                    $"{oper = matrica[7] * matrica[j]}\t\n");
            }
        }
        static void Delenie()
        {

        }
    }
}