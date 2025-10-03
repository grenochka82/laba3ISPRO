namespace laba3ISPRO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for(действия до выполнения;условие;действие после выполннения цикла){
            //тело цикла
            // } 
            //for (int i = 0; i < 10; i++) {
            // Console.WriteLine( i);}
            //for (int i = 1; i < 10; i++) {
            // Console.WriteLine( i);}
            //for i = 1;
            //for (; ; )
            //{
            //        Console.Writeline($"i = {i}");
            //        i++
            //    }
            //for (int i = 1, j = 1; i < 10; i++, j++)
            //    Console.Writeline($"i={i}");
            //    i++
            //for (int i = 1, j = 1; i < 10; i++, j++)
            //      Console.Writeline($"{i*j}");
            //      i++
            //{ int sum = 0;
            //  for (int i=1; i <= 10; i++) ;
            //  {
            //sum += 1;
            //Console.WriteLine($"Сумма:{sum}");
            //int i = 10;
            //do
            //{
            //    Console.Writeline(i);
            //    i--
            //}
            //while (i > 0);
            ////int i = 10;
            //while (i > 0) { }
            //Console.WriteLine(i);
            //i--;
            //int j = 10;
            //do {
            //    Console.WriteLine(j);
            //    j--
            //}
            //while (j > 0) { }
            //Console.WriteLine(j)
            // ду вайл выполняется хотя бы 1 раз 
            // string- массив строк, букв 
            //string text = "Hello world";
            //foreach (var symbol in text) {// вместо текст можно тоже писать и в выводе будет
            //    Console.WriteLine( symbol);
            //}
            //for (int i = 0; i < 10; i++) {
            //    for (int j = 1; j < 10; j++) {
            //        Console.WriteLine( $"{i*j} \t");
            //    }
            //    Console.WriteLine( );
            //} 
            //эхо-чат
            //string? input;
            //Console.Writeline("Добро пожаловать в эхо чат! Напиши что-нибудь (или  'выход' для завершение чата");
            //while (true)
            //{
            //    Console.Write(">");
            //    input = Console.Readline();
            //    if (input == null)
            //        continue;
            //    if (inpit.ToLower()=="выход")
            //    {
            //        Console.Writeline("До встречи!");
            //        break;
            //    }
            //    Console.Writeline($"Вы сказали: {input}");
            //}
            //программа-повторялка 
            //{
            //    while (true)
            //    {
            //        Console.Writeline("Введите текст для повторения: ");
            //        string input = Console.ReadLine();

            //        if (input.ToLower() == "выход")
            //        {
            //            Console.WriteLine("Конец");
            //            break;
            //        }
            //        Console.WriteLine($"Повтор текста: {input}");
            //    }
            //} ДРУГОЙ ВАРИАНТ
            //Console.ForegroundColor = ConsoleColor.Red;
            //while (true) {
            //    string input = Console.Readline().ToLower;
            //    if (input == "выход") ; break;
            //    Console.WriteLine( input);
            //}
            //DayOfWeek day = DayOfWeek.Суббота;
            //Console.WriteLine((int)day);
            //switch (day) 
            //{
            //    case DayOfWeek.Суббота:
            //    case DayOfWeek.Воскресенье:
            //        Console.WriteLine("выходной" );
            //        break;
            //    default:
            //        Console.WriteLine( "будний день");
            //        break;
            //}
            //enum DayOfWeek { 
            //  Понедельник=1,Вторник,Среда=2,Четверг,Пятница,Суббота,Воскресенье
            //}
            // массивы
            //int[] numbers = [1, 2, 3, 4, 5, 56];//чаще спользуем??
            //int[] numbers2 = [1, 2, 3, 4, 5, 56];
            //int[] numbers3 = new int[] { 1, 2, 3, 4, 5, 56 };
            //int[] numbers4 = new int[6] { 1, 2, 3, 4, 5, 56 };
            //int[] numbers5 = new[] { 1, 2, 3, 4, 5, 56 };
            //foreach (var i in numbers) {
            //    Console.WriteLine( i);
            //}
            //numbers[0] = 345;
            //Console.WriteLine( numbers.Length);
            //// вывод последнего элемента с конца
            //Console.WriteLine( numbers[^1]);

            //var[] text = [3, 4, 5, 6];// если что-то другое кроме чисел ошибка, не таким способом без ошибки 
            //dynamic[] text2 = [3, 4, 5, 6];//вариант решения
            //object[] text3 = [3, 4, 5, 6];//вариант решения
            //DayOfWeek today = DayOfWeek.Friday;
            //Console.WriteLine(today);

            //TaskPriority priority = TaskPriority.High;
            //Console.WriteLine((int)priority);

            //DayOfWeek day = DayOfWeek.Saturday;
            //switch (day) {
            //    case DayOfWeek.Saturday:
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("Выходной!");
            //        break;
            //    default:
            //        Console.WriteLine("Будний день.");
            //        break;
            //}

            //enum DayOfWeek { 
            //    Monday,
            //    Tuesday,
            //    Wednesday,
            //    Thursday,
            //    Friday,
            //    Saturday,
            //    Sunday
            //}

            //enum TaskPriority { 
            //    Low = 1,
            //    Medium = 2,
            //    High = 3
            //}

            //Console.ForegroundColor = ConsoleColor.Yellow;

            //var times = Enum.GetValues(typeof(TimeOfDay));
            //var heroes = Enum.GetValues(typeof(Hero));
            //for (int i = 0; i < times.Length; i++) {
            //    TimeOfDay time = (TimeOfDay)times.GetValue(i);
            //    Console.WriteLine($"\nВремя сейчас: {time}");
            //    for (int j = 0; j < heroes.Length; j++) {
            //        Hero h = (Hero)heroes.GetValue(j);
            //        Console.Write($"{h} - ");

            //        switch (time) {
            //            case TimeOfDay.Утро:
            //                Console.WriteLine(h switch {
            //                    Hero.воин => "делает зарядку с мечом",
            //                    Hero.маг => "заваривает зелья",
            //                    Hero.вор => "крадётся по базару",
            //                    _ => "ничего не делает"
            //                });
            //                break;

            //            case TimeOfDay.День:
            //                Console.WriteLine(h switch {
            //                    Hero.воин => "тренеруется на арене",
            //                    Hero.маг => "изучает древние книги",
            //                    Hero.вор => "прячется в тенях",
            //                    _ => ""
            //                });
            //                break;

            //            case TimeOfDay.Вечер:
            //                Console.WriteLine(h switch {
            //                    Hero.воин => "ест мясо у костра",
            //                    Hero.маг => "создаёт магический щит",
            //                    Hero.вор => "планирует налёт",
            //                    _ => ""
            //                });
            //                break;

            //            case TimeOfDay.Ночь:
            //                Console.WriteLine(h switch {
            //                    Hero.воин => "спит в палатке",
            //                    Hero.маг => "медитирует под луной",
            //                    Hero.вор => "лезет в чужой дом",
            //                    _ => ""
            //                });
            //                break;
            //        }
            //    }
            //}

            //enum Hero { воин, маг, вор }
            //enum TimeOfDay { Утро, День, Вечер, Ночь }//DayOfWeek today = DayOfWeek.Friday;
            //Console.WriteLine(today);

            //TaskPriority priority = TaskPriority.High;
            //Console.WriteLine((int)priority);

            //DayOfWeek day = DayOfWeek.Saturday;
            //switch (day) {
            //    case DayOfWeek.Saturday:
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("Выходной!");
            //        break;
            //    default:
            //        Console.WriteLine("Будний день.");
            //        break;
            //}

            //enum DayOfWeek { 
            //    Monday,
            //    Tuesday,
            //    Wednesday,
            //    Thursday,
            //    Friday,
            //    Saturday,
            //    Sunday
            //}

            //enum TaskPriority { 
            //    Low = 1,
            //    Medium = 2,
            //    High = 3
            //}

            //Console.ForegroundColor = ConsoleColor.Yellow;

            //var times = Enum.GetValues(typeof(TimeOfDay));
            //var heroes = Enum.GetValues(typeof(Hero));
            //for (int i = 0; i < times.Length; i++) {
            //    TimeOfDay time = (TimeOfDay)times.GetValue(i);
            //    Console.WriteLine($"\nВремя сейчас: {time}");
            //    for (int j = 0; j < heroes.Length; j++) {
            //        Hero h = (Hero)heroes.GetValue(j);
            //        Console.Write($"{h} - ");

            //        switch (time) {
            //            case TimeOfDay.Утро:
            //                Console.WriteLine(h switch {
            //                    Hero.воин => "делает зарядку с мечом",
            //                    Hero.маг => "заваривает зелья",
            //                    Hero.вор => "крадётся по базару",
            //                    _ => "ничего не делает"
            //                });
            //                break;
            //DayOfWeek today = DayOfWeek.Friday;
            //Console.WriteLine(today);

            //TaskPriority priority = TaskPriority.High;
            //Console.WriteLine((int)priority);

            //DayOfWeek day = DayOfWeek.Saturday;
            //switch (day) {
            //    case DayOfWeek.Saturday:
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("Выходной!");
            //        break;
            //    default:
            //        Console.WriteLine("Будний день.");
            //        break;
            //}

            //enum DayOfWeek { 
            //    Monday,
            //    Tuesday,
            //    Wednesday,
            //    Thursday,
            //    Friday,
            //    Saturday,
            //    Sunday
            //}

            //enum TaskPriority { 
            //    Low = 1,
            //    Medium = 2,
            //    High = 3
            //}

            //Console.ForegroundColor = ConsoleColor.Yellow;

            //var times = Enum.GetValues(typeof(TimeOfDay));
            //var heroes = Enum.GetValues(typeof(Hero));
            //for (int i = 0; i < times.Length; i++) {
            //    TimeOfDay time = (TimeOfDay)times.GetValue(i);
            //    Console.WriteLine($"\nВремя сейчас: {time}");
            //    for (int j = 0; j < heroes.Length; j++) {
            //        Hero h = (Hero)heroes.GetValue(j);
            //        Console.Write($"{h} - ");

            //        switch (time) {
            //            case TimeOfDay.Утро:
            //                Console.WriteLine(h switch {
            //                    Hero.воин => "делает зарядку с мечом",
            //                    Hero.маг => "заваривает зелья",
            //                    Hero.вор => "крадётся по базару",
            //                    _ => "ничего не делает"
            //                });
            //                break;

            //            case TimeOfDay.День:
            //                Console.WriteLine(h switch {
            //                    Hero.воин => "тренеруется на арене",
            //                    Hero.маг => "изучает древние книги",
            //                    Hero.вор => "прячется в тенях",
            //                    _ => ""
            //                });
            //                break;

            //            case TimeOfDay.Вечер:
            //                Console.WriteLine(h switch {
            //                    Hero.воин => "ест мясо у костра",
            //                    Hero.маг => "создаёт магический щит",
            //                    Hero.вор => "планирует налёт",
            //                    _ => ""
            //                });
            //                break;

            //            case TimeOfDay.Ночь:
            //                Console.WriteLine(h switch {
            //                    Hero.воин => "спит в палатке",
            //                    Hero.маг => "медитирует под луной",
            //                    Hero.вор => "лезет в чужой дом",
            //                    _ => ""
            //                });
            //                break;
            //        }
            //    }
            //}

            //enum Hero { воин, маг, вор }
            //enum TimeOfDay { Утро, День, Вечер, Ночь }//DayOfWeek today = DayOfWeek.Friday;
            //Console.WriteLine(today);

            //TaskPriority priority = TaskPriority.High;
            //Console.WriteLine((int)priority);

            //DayOfWeek day = DayOfWeek.Saturday;
            //switch (day) {
            //    case DayOfWeek.Saturday:
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("Выходной!");
            //        break;
            //    default:
            //        Console.WriteLine("Будний день.");
            //        break;
            //}

            //enum DayOfWeek { 
            //    Monday,
            //    Tuesday,
            //    Wednesday,
            //    Thursday,
            //    Friday,
            //    Saturday,
            //    Sunday
            //}

            //enum TaskPriority { 
            //    Low = 1,
            //    Medium = 2,
            //    High = 3
            //}

            //Console.ForegroundColor = ConsoleColor.Yellow;

            //var times = Enum.GetValues(typeof(TimeOfDay));
            //var heroes = Enum.GetValues(typeof(Hero));
            //for (int i = 0; i < times.Length; i++) {
            //    TimeOfDay time = (TimeOfDay)times.GetValue(i);
            //    Console.WriteLine($"\nВремя сейчас: {time}");
            //    for (int j = 0; j < heroes.Length; j++) {
            //        Hero h = (Hero)heroes.GetValue(j);
            //        Console.Write($"{h} - ");

            //        switch (time) {
            //            case TimeOfDay.Утро:
            //                Console.WriteLine(h switch {
            //                    Hero.воин => "делает зарядку с мечом",
            //                    Hero.маг => "заваривает зелья",
            //                    Hero.вор => "крадётся по базару",
            //                    _ => "ничего не делает"
            //                });
            //                break;//            case TimeOfDay.День:
            //                Console.WriteLine(h switch {
            //                    Hero.воин => "тренеруется на арене",
            //                    Hero.маг => "изучает древние книги",
            //                    Hero.вор => "прячется в тенях",
            //                    _ => ""
            //                });
            //                break;

            //            case TimeOfDay.Вечер:
            //                Console.WriteLine(h switch {
            //                    Hero.воин => "ест мясо у костра",
            //                    Hero.маг => "создаёт магический щит",
            //                    Hero.вор => "планирует налёт",
            //                    _ => ""
            //                });
            //                break;

            //            case TimeOfDay.Ночь:
            //                Console.WriteLine(h switch {
            //                    Hero.воин => "спит в палатке",
            //                    Hero.маг => "медитирует под луной",
            //                    Hero.вор => "лезет в чужой дом",
            //                    _ => ""
            //                });
            //                break;
            //        }
            //    }
            //}

            //enum Hero { воин, маг, вор }
            //enum TimeOfDay { Утро, День, Вечер, Ночь }



        }

    }
    
}
