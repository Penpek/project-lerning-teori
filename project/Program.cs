using System.Collections;
using System.Linq;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace project
{

class Program
{
    //    public void Main(){

        //     player alex = new player("Alex", PersonType.Player, 23, null, "heal");
        //     alex.Action();
        //     alex.GetInfo();
        //     Dictionary<string, bool> placas = new Dictionary<string, bool>();
        //     placas.Add("USA", true);
        //     placas.Add("Germany", false);
        //     enemy Bob = new enemy("Bob", PersonType.Enemy, 35, placas);
        //     Bob.Action();
        //     Bob.Age = 54;
        //     Bob.GetInfo();

        //     users.GetCount();

        //     NowDay nowDay = NowDay.Monday;
        //     if(nowDay == NowDay.Friday)
        //     System.Console.WriteLine("Go to playng");
        //     else
        //     System.Console.WriteLine("Work");
        // }

        // public static void GetInfo() {}

            // Animal cat = new Animal("Tom", "cat", 3);
            // Animal dog = new Animal("Jojo", "dog", 2);
            // Animal[] animals = {cat, dog};

            // //BinaryFormatter binary = new BinaryFormatter();

            // XmlSerializer xml = new XmlSerializer(typeof(Animal[]));

            // using(FileStream file = new FileStream("objects", FileMode.OpenOrCreate)) {
            //     xml.Serialize(file, animals);
            //     System.Console.WriteLine("ready");
            // }

            // using(FileStream file = new FileStream("objects", FileMode.OpenOrCreate)) {
            //     Animal[] NewAnimal = xml.Deserialize(file) as Animal[] ?? new Animal[0];
            //     System.Console.WriteLine("deserialize complit");
            // }






 // запрос числа от пользователя
    //     int num1, num2, text;

    //     Console.Write("Первое число:");
    //     num1 = int.Parse(Console.ReadLine());

    //     Console.Write("Второе число:");
    //     num2 = int.Parse(Console.ReadLine());

    //     text = num1;
    //     num1 = num2;
    //     num2 = text;

    // System.Console.WriteLine("Первое число: " + num1);
    // System.Console.WriteLine("Первое число: " + num2);




    // разбитие числа на состовляющие
    // Console.Write("Enter number with 4 digits: ");

    // int input = Convert.ToInt32(Console.ReadLine());

    // int n1 = input / 1000 % 10;
    // int n2 = input / 100 % 10;
    // int n3 = input / 10 % 10;
    // int n4 = input % 10;

    // Console.Write(n1 + ", " + n2 + ", " + n3 + ", " + n4);




    // ПРОСТЫЕ ПЕРЕМЕННЫЕ
    // short x = 5; // целое число
    // char y = 'F'; // только символ
    // string hello = "Привет"; // строковая переменная
    // float d = 90.2f; // число с точкой

    // const int value = 67; // создание константы




    //Работа с переменными
    // string name;
    // int age;

    // System.Console.WriteLine("Введите ваше имя: ");
    // name = Console.ReadLine();

    // System.Console.WriteLine("Введите ваш возраст: ");
    // age = int.Parse(Console.ReadLine());

    // System.Console.WriteLine("Привет " + name +"! Тебе уже " +age);




    // Работа с числами

    // int days = 2642, years, weeks;

    // years = days / 365; // количество лет
    // weeks = (days % 365) / 7; // количество недель
    // days = days - ((years*365) + (weeks*7)); // количество дней

    // Console.Write("Лет: " + years);
    // Console.Write(", Недель: " + weeks);
    // Console.Write(", Дней: " + days);




    // Нахождение числа

//     int n1 = int.Parse(Console.ReadLine()); // Получаем число от пользователя
//     int n2 = n1 * 2; // Вторая переменная содержит число от пользователя, умноженное на два

 // Выводим их вместе
 // превращаем в строки, чтобы не добавлялись
//     Console.Write(n1.ToString() + n2.ToString());




// Разные типы переменных

// sbyte num1 =-34; // Отрицательное маленькое число, поэтому sbyte
// byte num2 = 4; // маленькое число, поэтому byte
// string num3 = "Hello"; // строка
// char num4 = 'R'; // символ
// double num5 = 23.093433222f; // много символов после запятой, поэтому double
// short num6 = 30000; // Чуть больше число, поэтому short
// bool value = true; // Булевое выражение
// byte simpl = 0; // байтовое значение




// Получение данных

// string name;
// int age;
// bool hasCar;

// System.Console.WriteLine("Введите ваше имя: "); //Получение данных
// name = Console.ReadLine();

// System.Console.WriteLine("Введите ваш возраст: "); // Получаем число от пользователя
// age = Convert.ToInt32(Console.ReadLine()); // конвертируем число в строку

// System.Console.WriteLine("Есть ли у вас машина?"); // Получаем булевое значение
// hasCar = Convert.ToBoolean(Console.ReadLine());

// System.Console.WriteLine("Привет " + name + ".");
// System.Console.WriteLine("тебе уже " + age.ToString () + "лет.");
// System.Console.WriteLine("Есть ли у тебя машина? Ответ:" +hasCar);




// Преобразование данных

// short a;
// ulong b;
// char s;
// double sd;

// a = Convert.ToInt16(Console.ReadLine()); // Для конвертации в short испльзуйте ToInt16 (для int - ToInt32)
// b = Convert.ToUInt64(Console.ReadLine()); // Для конвертации в ulong испльзуйте ToUInt64
// s = Convert.ToChar(Console.ReadLine()); // Для конвертации в char испльзуйте ToChar
// sd = Convert.ToDouble(Console.ReadLine()); // Для конвертации в double испльзуйте ToDouble




//Операции над переменной

// int a = 5;
// a *=7; //сокращенная формула умножения
// a--; // Декременация

// Console.Write("Number is: " + a);




// Поле из символов

// int number;

// Console.Write("Enter a number: ");
// number = Convert.ToInt32(Console.ReadLine());

// // Выводим информацию в консоль
// // Вместо {0} будет подставлен первый параметр после запятой
// Console.WriteLine("{0}{0}{0}{0}", number);
// Console.WriteLine("{0}  {0}", number);
// Console.WriteLine("{0}  {0}", number);
// Console.WriteLine("{0}{0}{0}{0}", number);




// Доменное имя

// Console.Write("Enter website: ");
// string website = Console.ReadLine(); // Получаем веб сайт от пользователя

// // Разделяем слово по символу точка
// string[] split = website.Split('.'); // Получиться массив состоящий из двух элементов
// Console.Write("Domain name: " + split[split.Length - 1]);




// Депозитный калькулятор

// Получаем все данные от пользователя
// Console.Write("Sum: ");
// double price = Convert.ToDouble(Console.ReadLine());
// Console.Write("Years: ");
// double years = Convert.ToDouble(Console.ReadLine());
// Console.Write("Procent: ");
// double procent = Convert.ToDouble(Console.ReadLine());

// // Вычисляем проценты за каждый год
// for (int i = 1; i < years; i++) {

// // Вычисление процента за каждый год
// price *= 1 + procent / 100;
// System.Console.WriteLine("After " + i + "years " + Math.Round(price, 2));
//

// Console.WriteLine("After " + years + " year summ will be " + price);




// ПРОСТОЙ КАЛЬКУЛЯТОР

// Получаем данные от пользователя
// int a = 2, b = 6, Action;
// Console.Write("Введите первое число: ");
// a = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// b = int.Parse(Console.ReadLine());

// Console.WriteLine("1. Добавить");
// Console.WriteLine("2. Отнять");
// Console.WriteLine("0. Ничего");

// // Получаем действие
// Action = int.Parse(Console.ReadLine());

// if (Action == 1)
//     System.Console.WriteLine(a + b);
// else if (Action == 2)
//     System.Console.WriteLine(a - b);
// else if (Action == 0)
//     System.Console.WriteLine("Вы выбрали ничего не делать");
// else
//     System.Console.WriteLine("Необходимо выбрать верный вариант");

// Работа с переменными

// Console.Write("Ваше имя: ");
// string name = Console.ReadLine();
// Console.Write("Ваша фамилия: ");
// string surname = Console.ReadLine();
// Console.Write("Ваш возраст: ");
// short age = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine("Hi, " + name + " " + surname + "! You are " + age + " years old");



//Остаток от деления

// byte a, b;

// Console.Write("Введите первое число: ");
// a = Convert.ToByte(Console.ReadLine());
// Console.Write("Введите второе число: ");
// b = Convert.ToByte(Console.ReadLine());

// Console.Write("Результат: " + (a%b).ToString());



// Константы

// const sbyte number = 20;
// int user_input;

// Console.Write("Enter number: ");
// user_input = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Sum is: " + (number + user_input).ToString());
// System.Console.WriteLine("Minus is: " + (number - user_input).ToString());
// System.Console.WriteLine("Multiply is: " + (number * user_input).ToString());
// System.Console.WriteLine("Divide is: " + (number / user_input).ToString());



// Пустая строка

// string user_imput = ""; // Изначально создаем строку с пустым значением

// // Используем специальную функцию IsNullOrWhiteSpace,
// // которая проверяет является ли строка пустой или содержит лишь пробелы.
// // Цикл будет работать до тех пор, пока строка будет пустой
// // или будет состоять из пробелов
// while (string.IsNullOrWhiteSpace(user_imput)) {
//     Console.Write("Enter something: ");
//     user_imput = Console.ReadLine();
//     }

//     System.Console.WriteLine("Hooray! You done that!");



 // Ввод данных с клавиатуры

// string user_imput = ""; // Переменная с пустым значением

// // Сначала просим ввести данные, а потом проверяем
// do {
//     Console.Write("Enter tags (min.3): ");
//     user_imput = Console.ReadLine();
// // Мы результат разделяем по пробелу
// // и получаем массив данных.
// // Проверяем длину массива и
// // если в нем менее 3 элементов, то
// // цикл будет срабатывать повторно
// }
//  while (user_imput.Split(' ').Length < 3);

// // Успешное сообщение
// Console.WriteLine("Hooray! You done that!");



//Небольшой калькулятор
// int x, y;
// char math;

// // Получение всех переменных от пользователя
// Console.Write("Первое число: ");
// x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Операция: ");
// math = Convert.ToChar(Console.ReadLine());
// Console.Write("Второе число: ");
// y = Convert.ToInt32(Console.ReadLine());

// // Выполняем проверки и математические действия
// if (math == '+')
// System.Console.WriteLine("{0} + {1} = {2}", x,y, x + y);
// else if (math == '-')
// System.Console.WriteLine("{0} - {1} = {2}", x,y, x - y);
// else if (math == '*')
// System.Console.WriteLine("{0} * {1} = {2}", x,y, x * y);
// else if (math == '/')
// // Дополнительно выполняем проверку на число 0
// if (y != 0)
// System.Console.WriteLine("{0} / {1} = {2}", x,y, x / y);
// else
//     System.Console.WriteLine("Нельзя делить на ноль!");
// else
//     System.Console.WriteLine("Неверная операция");



//Проверка переменных

// int n1, n2;

// Console.Write("Введите первое число: ");
// n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// n2 = Convert.ToInt32(Console.ReadLine());

// // Сокращенная проверка на четность
// bool IsEven = ((n1 % 2 == 0) && (n2 % 2 == 0)) ? true : false;
// Console.Write(IsEven);



//Обычная бухгалтерия
// int pay =752, profit = 843, res;

// if (pay > profit) {
//     res = pay - profit;
//     Console.Write("Ваша прибыль составила: {0}", res);
// }
// else if (pay < profit) {
//     res = profit - pay;
//     Console.Write("Вашу бытки составила: {0}", res);
// }
// else
// System.Console.WriteLine("Нет ни прыбили, ни убытков");



// Условные операторы
// Console.Write("Сколько вам лет?");
// int age = Convert.ToInt32(Console.ReadLine());
// if ( age > 18)
// Console.Write("You can do everything");
// if (age == 18)
// Console.Write("Hoho, you're 18!");
// if (age < 18)
// Console.Write("You are too young");


// Определение дня недели

// string day = "";
// Console.Write("Enter number from 1 to 7: ");
// int number = Convert.ToInt32(Console.ReadLine());

// switch (number) {
//     case 1: day = "Mondey"; break;
//     case 2: day = "Tuesday"; break;
//     case 3: day = "Wednesday"; break;
//     case 4: day = "Thursday"; break;
//     case 5: day = "Friday"; break;
//     case 6: day = "Satuday"; break;
//     case 7: day = "Sunday"; break;
//     default: day = "Error"; break;
//     }
//     System.Console.WriteLine(day);



//Сравнение строк

// Изначально создаем строки
// string str1 = "", str2 = "";

// Далее добавляем значения в них
// Console.Write("Первая строка: ");
// str1 = Console.ReadLine();
// Console.Write("Вторая строка: ");
// str2 = Console.ReadLine();

// Сравниваем по количеству символов
// if (str1.Length < str2.Length)
//     System.Console.WriteLine(str1 + " меньше чем " + str2);
// else if (str1.Length == str2.Length)
//     System.Console.WriteLine(str1 + " равна строке " +str2);
// else if (str1.Length > str2.Length)
//     System.Console.WriteLine(str1 + " больше чем " + str2);



//Точка и круг
// double x = 19, y = 15, r = 5, r_xy;
// // Вычисляем все по формуле
// r_xy = Math.Sqrt(x * x + y * y);

// if (r_xy <= r){
//     Console.Write("Точка принадлежит кругу");
// } else{
//     Console.Write("Точка не принадлежит кругу");
// }


//Среднее число
// int a1, a2, a3;
// System.Console.WriteLine("Введите первое число: ");
// a1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите второе число: ");
// a2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите третье число: ");
// a3 = Convert.ToInt32(Console.ReadLine());

// if (a1 == a2 && a2 ==a3)
//     System.Console.WriteLine("Ошибка");
// else {
//     if ((a1 > a2 && a1 < a3) || (a1 > a3 && a1 < a2))
//         System.Console.WriteLine(a1);
//         else if ((a2 > a1 && a2 < a3) || (a2 > a3 && a2 < a1))
//             System.Console.WriteLine(a2);
//         else if ((a3 > a2 && a3 < a1) || (a3 > a1 && a3 < a2))
//             System.Console.WriteLine(a3);
//     }



//Четные числа
// int a, b;
// a = Convert.ToInt32(Console.ReadLine());
// b = Convert.ToInt32(Console.ReadLine());

// if (a % 2 == 0 && b % 2 == 0)
//     System.Console.WriteLine(a + "," + b + "  - четные числа");
// else if (a % 2 == 0)
//     System.Console.WriteLine(a + " Четное число");
// else if (b % 2 == 0)
//     System.Console.WriteLine(b + " Четное число");
// else
//     System.Console.WriteLine("Нет ни одного четного числа");


//Тернарный оператор       если второе введенное число равно 0, то выводиться число 1 на экран;
//                         если второе введенное число не равно 0, то выводиться результат деления чисел.
// float a, b, res;
// // Для конвертации в тип данных float используйте ToSingle
// a = Convert.ToSingle(Console.ReadLine());
// b = Convert.ToSingle(Console.ReadLine());

// // Выполняем тернарное сравнение
// res = b != 0 ? (a / b) : 1;
// System.Console.WriteLine("Result is: " + res);


// Большая проверкаБольшая проверка
// int a = 34;

// if ((a < 50 && a != 37 && a >= 32) || (a == 0 || a == 15))
//     System.Console.WriteLine("Working!");
// Console.ReadKey();


//Оператор Switch
// int a = 11;

// switch (a) { //При помощи оператора switch case проверяем переменную
//     case 10:
//         System.Console.WriteLine("Number is 10");
//         break;
//     case 15:
//         System.Console.WriteLine("Number is 15");
//         break;
//     default:
//         System.Console.WriteLine("Something else");
//         break;
// }



//Создание калькулятора c использованием оператора switch case.
// float a, b, res;
// char math_operation;

// Console.Write("First num: ");
// a = Convert.ToSingle(Console.ReadLine());
// Console.Write("Second num: ");
// b = Convert.ToSingle(Console.ReadLine());
// Console.Write("Math operation: ");
// math_operation = Convert.ToChar(Console.ReadLine());

// switch (math_operation) {
//     case '+':
//     res = a + b;
//     System.Console.WriteLine("Result: " + res);
//     break;
//     case '-':
//     res = a - b;
//     System.Console.WriteLine("Result: " + res);
//     break;
//     case '*':
//     res = a * b;
//     System.Console.WriteLine("Result: " + res);
//     break;
//     case '/':
//     res = a / b;
//     System.Console.WriteLine("Result: " + res);
//     break;
//     default:
//     System.Console.WriteLine("Something wrong!");
//     break;
// }
// Console.ReadKey();



//Создание и вывод массива
// int n;

// // Пользователь вводит количество элементов в массиве
// Console.Write("Enter numbers of array: ");
// n = Convert.ToInt32(Console.ReadLine());

// // Создаем пустой массив
// int[] A = new int[n];
// // Создаем цикл и получаем каждый элемент для массива
// for (int i = 0; i < n; i++) {
//     Console.Write("Enter A[" + i +"] = ");
//     A[i] = Convert.ToInt32(Console.ReadLine());
// }

// // Выводим массив в одну строку
// for (int i = 0; i < n; i++) {
//     Console.Write(A[i] + " ");
// }



// Двумерный массив
// int Length = 3;
// int[,] x = { { 0, 34, 2 }, { 9, 12, 18 }, { 3, 4, 5 } };
// int i = 0;

// // Перебераем первый массив
// while (i < Length) {
//     int j = 0;
//     // Перебираем второй вложенный массив (0, 34, 2) и так далее
//     while (j < Length) {
//         Console.Write(x[i, j] + " | ");
//         j++;
//     }
//     System.Console.WriteLine(" "); // Пропуск строки
//     i++;
// }



//Почти самый маленький
//Создайте массив и программу, которая будет находить второй самый маленький элемент в массиве.
// int[] arr = {24, -63, 67, -12, 88, 94, -28, 82, 0, 53};
// Console.Write("Array: "); //Выводим масив на экран
// for (int i = 0; i < arr.Length; i++){
//     Console.Write(arr[i] + " ");
// }
// // Дополнительный пропуск строки
// Console.Write(" ");
// // Ставим первые элементы из массива
//  // они могут быть неверными, но мы через цикл это проверим
// int min = arr[0], sec_min = arr[1];
// for (int i = 0; i < arr.Length; i++){ // Перебираем весь массив
// // Если данный элемент равен минимальному, то ставим его как второй минимальный
// if (arr[i] == min)
// sec_min = min;
// // Если данный элемент меньше минимального, то предыдущий минимальный
// // теперь второй минимальный, а значение нового минимального меняем
// else if (arr[i] < min){
//     sec_min = min;
//     min = arr[i];
// }else if (arr[i] <sec_min) // Если элемент меньше второго минимального, то указываем его
// sec_min = min;
// }
// Console.Write("Second minimal element: " + sec_min);



// Минимум и максимум
//Создайте массив и выведите в консоль минимальный и максимальный элементы в этом массиве.
// int[] arr = {24, -63, 67, -12, 88, 94, -28, 82, 0, 53};
// int min, max;

// // Изначально мин и макс пускай будет первый элемент
// min = arr[0];
// max = arr[0];

// for (int r = 0; r < arr.Length; r++){
//     // Если есть элемент, который больше за нынешний максимум,
//     // то делаем этот элемент новым максимумом
//     if (max < arr[r])
//     max = arr[r];
//     if (min > arr[r])
//     min = arr[r];
// }
// System.Console.WriteLine("Max: " + max);
// System.Console.WriteLine("Min: " + min);



//Сортировка массива
// Создайте программу, которая будет просить пользователя ввести размер массива,
//  а также все значения элементов для массива и отсортируйте его
// int size; // размер массива

// // Ввод количества элементов массива
// Console.Write("Размер массива: ");
// size = int.Parse(Console.ReadLine());

// int[] arr = new int[size]; // сам массив, изначально пустой

// if (size <= 0) {
//     // Размер масива должен быть положитлеьным
//     Console.Write("Неверный размер");
// } else {
//     for (int i = 0; i < size; i++) {
//         // Дополнительно переводим в числовую переменную,
// 		// чтобы можно было сравнивать как числа
//         Console.Write("Введите элемент с индексом - " + i + ": ");
//         arr[i] = int.Parse(Console.ReadLine());
//     }

//     int temp; // временная переменная для обмена элементов местами

//     // Сортировка массива пузырьком
//     for (int i = 0; i < size - 1; i++){
//         for (int j = 0; j < size - 1; j++){
//             if(arr[j] > arr[j + 1]) {
//                 temp = arr[j];
//                 arr[j] = arr[j + 1];
//                 arr[j + 1] = temp;
//             }
//         }
//     }

//     // Вывод отсортированного массива на экран
//     for (int i = 0; i < size; i++)
//     System.Console.WriteLine(arr[i]);
// }



//Среднее арифметическое
// Дан одномерный массив. Найти среднее арифметическое его элементов.
// Вывести на экран только те элементы массива, которые больше найденного среднего арифметического.
// const short Length = 10;
// int[] a = {5, 8, 18, 34, 3, 56, 43, 27, 4, 23};
// int avgr, sum =0;
// for(short i = 0; i < Length; i++)
// sum += a[i];

// avgr = sum / Length;

// // выводим массив
// for(short i = 0; i < Length; i++)
// Console.Write(a[i] + " ");
// System.Console.WriteLine();// Пропуск строки

// System.Console.WriteLine("Среднее арифметическое: " + avgr);

// //больше avgr/ числа больше среднего
// for(short i = 0; i < Length; i++){
//     if(a[i] > avgr)
//     System.Console.WriteLine(a[i] + " ");
// }



// Сортировка массива
// Создайте одномерный массив данных и выполните сортировку чисел в массиве по возрастанию.
// byte[] x = { 0, 34, 2, 9, 12, 18, 3, 4, 5 };
// byte temp;

// for (byte i = 0; i < x.Length - 1; i++) {
//     // Каждый элемент перебираем в этом же массиве
//     // Если находим элемент, который больше, то меняем местами элементы
//     for ( byte j = 0; j <x.Length - 1; j++) {
//         if(x[j] > x[j + 1]){
//             // меняем элементы местами
//             temp = x[j];
//             x[j] = x[j + 1];
//             x[j+ 1] = temp;
//         }
//     }
// }

// // Вывод отсортированного массива на экран
// for (byte h = 0; h < x.Length; h++)
// System.Console.WriteLine(x[h] + " ");



// Обратный порядок
// Отсортируйте массив таким образом, чтобы элементы поменялись местами
// int Length = 6; // Считаем количество элементов
// int[] x = {9, 25, 78, 23, -43, 4}; // Наш массив

// int[] new_arr = new int[Length]; // Пустой новый массив

// // Новая переменная для индексов в новом массиве
// int j = 0;

// // Создаем цикл и перебираем массив с конца и до 1 элемента
// for (int i = Length - 1; i >= 0; i--) {
//     // x[i] - идёт счет с последних элементов
//     // new_arr[j] - записывается в начало
//     new_arr[j] = x[i];
//     // увеличиваем индекс для нового массива
//     j++;
// }

// for (byte el = 0; el < Length; el++)
// System.Console.WriteLine(new_arr[el] + " ");




//Поиск одинаковых чисел в массивах
//Дано два массива чисел. Необходимо вывести на экран все числа,
//которые одновременно присутствуют в обеих массивах.

// int[] array_1 = {1, 2, 3, 5, 7, 9, 10};
// int[] array_2 = {1, 4, 3, 5, 8, 9, 0};
// /* объявляем строковую переменную для результатов */
// string str_res = "";

// for (int i = 0; i < array_1.Length; i++) {
//     for (int j = 0; j < array_2.Length; j++)

//     if (array_1[i] == array_2[j]) {
//         	/* если значения совпали, то помещаем данное число
// 			* в результирующую строку str_res
// 			* и после значения добавляем разделитель - '; '
// 			* точку с запятой и пробел,
// 			* чтобы наша результирующая строка красивей и
// 			* читабельней выглядела на экране
// 		*/
//         str_res += array_1[i] + "; ";
//     }
// }

// System.Console.WriteLine(str_res);



//Максимальный элемент
// List <int> digits = new List<int> ();
// digits.Add(25);
// digits.Add(102);
// digits.Add(98);
// digits.Add(67);
// digits.Add(6);
// digits.Add(13);
// digits.Add(84);
// int max_num = digits[0];

// for (byte i = 0; i < digits.Count; i++) {
//     if (digits[i] > max_num)
//     max_num = digits[i];
// }
// System.Console.WriteLine("Max number: " + max_num);
// Console.ReadKey ();



//Минимальный элемент

// Двумерный массив
// int[,] numbers = new int[2, 3] { { 0, 34, -2 }, { 3, -4, 5 } };
// // Предполагаем, что минимальный элемент - это 1 элемент массива (0 и 0 по индексу)
// int min_num = numbers [0, 0];
// // Создаем первый цикл для перебора первого массива
// for (byte i = 0; i < 2; i++) {
//     // Создаем второй цикл для перебора вложенных массивов
//     for (byte j = 0; j < 3; j++) {
//         // Сверяем текущий элемент с минимальным
//         if (numbers[i, j] < min_num)
//         min_num = numbers[i, j];
//     }
// }

// System.Console.WriteLine("min number: " + min_num);


//Простые функции

//Первая функция
// public static void welcome () {
//     System.Console.WriteLine("Всем привет!");
// }

// // Вторая функция
// public static void print(String str) {
//     System.Console.WriteLine(str);
// }

// public static void Main() {
//     //Вызов фукнции
//     welcome();
//     print("Можете звать меня робот!");



//Подсчет всех чисел
//Создайте функцию, которая будет считать сумму всех отдельных чисел числа

// public static int Summ (int number) {
//     string str_num = Convert.ToString(number);
//     int sum = 0;

// // Создаем цикл, который выполниться столько же раз,
// // сколько отдельных чисел в числе от пользователя
// for(int i =0; i < str_num.Length; i++)
// // Получаем каждое из чисел.
// // Для этого обрезаем число при помощи функции substr()
// // Преобразовываем значение в число
// // и добавляем к сумме
// sum += Convert.ToInt32(str_num.Substring(i, 1));
// return sum;
// }

// public static void Main() {
//     //получаем число и вызываем функцию
//     int num;
//     Console.Write("Введите число: ");
//     num = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Сумма всех чисел в числе {0} равна: {1}", num, Summ(num));
// }














}
}
