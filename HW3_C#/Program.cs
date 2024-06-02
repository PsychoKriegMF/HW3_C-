namespace HW3_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Задача 1.
            Console.WriteLine("Квадрат из символов");
            Square('*', 10);
            Console.WriteLine();

            ////Задача 2.
            Console.WriteLine("Проверка на палиндром. Введите число-> ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Введенное число палиндром: {Palindrom(num)}");
            Console.WriteLine();

            //Задача 3.
            int[] arr = { 1, 2, 6, -1, 88, 7, 6 };
            int[] arr_filter = { 6, 88, 7 };
            Console.WriteLine("Исходный массив: ");
            foreach (int el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Массив с данными для фильтрации");
            foreach (int el in arr_filter)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Отфильтрованный массив: ");
            arr = Filter(arr, arr_filter);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Задача 4.
            WebSite webSite = new WebSite();
            Console.WriteLine("Введите название сайта -> ");
            webSite.Name_ = Console.ReadLine();
            Console.WriteLine("Введите адрес сайта -> ");
            webSite.Url_ = Console.ReadLine();
            Console.WriteLine("Введите IP сайта -> ");
            webSite.IP_ = Console.ReadLine();
            Console.WriteLine("Введите описание сайта -> ");
            webSite.Description_ = Console.ReadLine();
            webSite.Print();
            Console.WriteLine();

            //Задача 5.
            Journal journal = new Journal();
            Console.WriteLine("Введите название журнала");
            journal.name_ = Console.ReadLine();
            Console.WriteLine("Введите дату основания журнала");
            journal.dateTime_ = Console.ReadLine();
            Console.WriteLine("Введит телефон журнала");
            journal.phone_ = Console.ReadLine();
            Console.WriteLine("Введите email журнала");
            journal.email_ = Console.ReadLine();
            Console.WriteLine("\n");
            journal.Print();
            Console.WriteLine();

            //Задача 6.
            Shop shop = new Shop();
            Console.WriteLine("Введите название магазина");
            shop.name_ = Console.ReadLine();
            Console.WriteLine("Введите описание магазина");
            shop.descrition_ = Console.ReadLine();
            Console.WriteLine("Введит телефон магазина");
            shop.phone_ = Console.ReadLine();
            Console.WriteLine("Введите email магазина");
            shop.email_ = Console.ReadLine();
            Console.WriteLine("\n");
            shop.Print();



            // рисовалка квадрата
            static void Square(char x, int size) 
            {
                for(int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(x + " ");
                    }
                    Console.WriteLine();
                }
            }

            // проверялка палиндрома
            static bool Palindrom(int num)  
            {
                bool result = true;
                string str = Convert.ToString(num);
                for (int i = 0; i < str.Length / 2; i++)
                {
                    if (str[i] == str[str.Length -1 - i])
                    {
                        continue;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
                return result;
            }

            // фильтровашка массива         
            static int[] Filter(int[] arr, int[] arr_filt)
            {
                List<int> FilteredArr = new List<int>();
                foreach(int item in  arr)
                {
                    if(!arr_filt.Contains(item))
                        FilteredArr.Add(item);
                }
                return FilteredArr.ToArray();
            }

        }
    }
}
