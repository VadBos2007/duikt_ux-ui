namespace Length_converter
{
    class Program

    {
        static void Main(string[] args)
        {
            Program app = new Program();

            app.Main_menu();
        }

        int Choice;
        string? a, b;
        double x, y;

        public int Enterdata()
        {
            string? input;
            do
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("|               Введіть число (0 - 3):                |");
                Console.WriteLine("=======================================================");
                input = Console.ReadLine();
                if (!int.TryParse(input, out Choice))
                {
                    Console.Clear();
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("|        Помилка: введіть цифру, а не літери!         |");
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    continue;
                }

            }
            while (!int.TryParse(input, out Choice));
            return Choice;
        }
        public void Description()
        {
            Console.Clear();
            Console.WriteLine("=======================================================");
            Console.WriteLine("|            ПРО ПРОГРАМУ: КОНВЕРТЕР ДОВЖИН           |");
            Console.WriteLine("=======================================================");
            Console.WriteLine("|Програма здійснює конвертацію між метричними         |");
            Console.WriteLine("|одиницями: сантиметрами (см), метрами (м) та         |");
            Console.WriteLine("|кілометрами (км).                                    |");
            Console.WriteLine("|                                                     |");
            Console.WriteLine("|Алгоритм побудований на підході «базової одиниці».   |");
            Console.WriteLine("|Щоб уникнути дублювання коду, вхідне значення        |");
            Console.WriteLine("|завжди переводиться в метри, а вже потім — у цільову |");
            Console.WriteLine("|одиницю вимірювання.                                 |");
            Console.WriteLine("|                                                     |");
            Console.WriteLine("|1. Формули приведення до базової одиниці (метрів):   |");
            Console.WriteLine("|    • см -> м  : значення / 100                      |");
            Console.WriteLine("|    • км -> м  : значення * 1000                     |");
            Console.WriteLine("|                                                     |");
            Console.WriteLine("|2. Формули фінальної конвертації з метрів:           |");
            Console.WriteLine("|   • м -> см  : значення * 100                       |");
            Console.WriteLine("|   • м -> км  : значення / 1000                      |");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("|     Натисніть будь-яку клавішу для повернення...    |");
            Console.WriteLine("=======================================================");
            Console.ReadKey();
            Console.Clear();
        }
        public void Author()
        {
            Console.Clear();
            Console.WriteLine("=======================================================");
            Console.WriteLine("|                        АВТОР                        |");
            Console.WriteLine("=======================================================");
            Console.WriteLine("|    Розробив цю програму Вінник Вадим Сергійович     |");
            Console.WriteLine("|                Студент групи ІПЗ-22                 |");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("|     Натисніть будь-яку клавішу для повернення...    |");
            Console.WriteLine("=======================================================");
            Console.ReadKey();
            Console.Clear();
        }



        public void Main_menu()
        {
            while (true)
            {
                Console.WriteLine("=======================================================");
                Console.WriteLine("|                    Головне меню                     |");
                Console.WriteLine("=======================================================");
                Console.WriteLine("| 1: Конвертувати довжину.                            |");
                Console.WriteLine("| 2: Про програму.                                    |");
                Console.WriteLine("| 3: Автор.                                           |");
                Console.WriteLine("| 0: Вихід                                            |");
                Enterdata();
                switch (Choice)
                {
                    case 1:
                        Length_Run();
                        break;

                    case 2:
                        Description();
                        break;

                    case 3:
                        Author();
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        Console.WriteLine("|       Введено неправильне число! Введіть 0 - 3       |");
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        break;
                }
            }
        }

        public string? Enter_a()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================================================");
                Console.WriteLine("|                Виберіть, що переводити              |");
                Console.WriteLine("=======================================================");
                Console.WriteLine("| 1: см                                               |");
                Console.WriteLine("| 2: м                                                |");
                Console.WriteLine("| 3: км                                               |");
                Console.WriteLine("| 0: назад                                            |");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("|                 Виберіть пункт (0-3)                |");
                Console.WriteLine("=======================================================");

                string? input = Console.ReadLine();
                int ach;

                if (!int.TryParse(input, out ach))
                {
                    Console.Clear();
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("|        Помилка: введіть цифру, а не літери!         |");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("|     Натисніть будь-яку клавішу для повернення...    |");
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.ReadKey();
                }



                switch (ach)
                {
                    case 1: a = "см"; return a;


                    case 2: a = "м"; return a;


                    case 3: a = "км"; return a;


                    case 0: return "back";

                    default:
                        Console.Clear();
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        Console.WriteLine("|       Введено неправильне число! Введіть 0 - 3       |");
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        break;

                }
            }


        }

        public string? Enter_b()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================================================");
                Console.WriteLine("|              Виберіть, у що переводити              |");
                Console.WriteLine("=======================================================");
                Console.WriteLine("| 1: см                                               |");
                Console.WriteLine("| 2: м                                                |");
                Console.WriteLine("| 3: км                                               |");
                Console.WriteLine("| 0: назад                                            |");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("|                 Виберіть пункт (0-3)                |");
                Console.WriteLine("=======================================================");

                string? input = Console.ReadLine();
                int bch;

                if (!int.TryParse(input, out bch))
                {
                    Console.Clear();
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("|        Помилка: введіть цифру, а не літери!         |");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("|     Натисніть будь-яку клавішу для повернення...    |");
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.ReadKey();
                }



                switch (bch)
                {
                    case 1: b = "см"; return b;


                    case 2: b = "м"; return b;


                    case 3: b = "км"; return b;


                    case 0: return "back";

                    default:
                        Console.Clear();
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        Console.WriteLine("|       Введено неправильне число! Введіть 0 - 3       |");
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        break;

                }
            }
        }

        public double Enter_x()
        {
            string? input;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine($"|                Введіть число ({a})                   |");
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                input = Console.ReadLine();
                input = input?.Replace('.', ',');


                if (double.TryParse(input, out x) && x > 0)
                {
                    return x;
                }
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("|       Помилка: введіть коректне додатнє число!      |");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("|     Натисніть будь-яку клавішу для повернення...    |");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.ReadKey();

            }
        }

        public double transformation_x()
        {

            if (a == "см")
            {
                return x / 100;
            }
            else if (a == "км")
            {
                return x * 1000;
            }
            else
            {
                return x;
            }
        }

        public double Run(double M)
        {

            if (b == "см")
            {
                return y = M * 100;
            }
            else if (b == "км")
            {
                return y = M / 1000;
            }
            else
            {
                return y = M;
            }
        }


        public void Length_Run()
        {
            if (Enter_a() == "back")
            {
                Console.Clear();
                return;
            }
            Enter_x();
            if (Enter_b() == "back")
            {
                Console.Clear();
                return;
            }
            double M = transformation_x();
            Run(M);
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~РЕЗУЛЬТАТ~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"|              Число {x} {a} = {y} {b}               |");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("|     Натисніть будь-яку клавішу для повернення...    |");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ReadKey();
            Console.Clear();


        }



    }
}
