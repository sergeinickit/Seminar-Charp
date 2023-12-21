
//Первая задача Функций - это убрать дубляж кода(когда много строк) и вторая - чтобы читаь чужой код наглядно

// Задача 2. Задайте массив из N случайных чисел (N вводится с клавиатуры).
//           Найдите количество чисел, которые оканчиваются на 1 и делются нацело на 7.
//           Пример:
//           [1 5 11 21 81 4 0 91 2 3] => 2

//  тип возвращающего значения + Название+ () + {}

// System.Console.WriteLine("Введите число");         //Запрашиваем у пользователя число
// int num = Convert.ToInt32(Console.ReadLine());     //Сохраняем.
// //Создали переменную в которой хранится размер нашего массива.

// int[] array = new int[num];   //Создаем массив.
// // int - какие элементы в нем находятся; дальше []; название массива (array);
// // дальше = new; int - дублируем тип; и в [] размер массива.

// for (int i = 0; i < array.Length; i++)   //Заполняем массив.
// {
//     array[i] = new Random().Next(10, 101);
//     System.Console.Write(array[i]+ " ");
//     //Оращаемся к каждому элементу массива (array[i]) и заполняем его случайными числами.
//        //Выводи полученный массив.
// }

// int countNumber = 0;        //Создаем переменную для сохранения чисел, которые подходят под условие.

// for (int i = 0; i < array.Length; i++) 
// {
//     if(array[i] %10 == 1 && array[i] %7 == 0)         //Проверка, что последняя цифра = 1 (array[i] %10 == 1)
//                                                       // и элемент массива делится нацело на 7 (array[i] %7 == 0)
//     {
//         countNumber = countNumber+1;       //Если условие верно - то увеличиваем счетчик на 1 и выводим
//     }
// }
// System.Console.WriteLine();       //Чтобы не сливалось - переход с новой строки
// System.Console.WriteLine(countNumber);

    
//Теперь тоже с помщью функций
         
// System.Console.WriteLine("Введите число");        //1 Способ.Чтобы созданный массив работал на обеих функциях,  
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];                       //выносим его создание вверх (до функций)

// CreateArray();            //Чтобы функции заработали, их надо сначало вызвать
// Console.WriteLine(FindNumber());  //Чтобы 2 функция работала - создаем новую переменную(newCount), где будут храниться
// //подсчитанные числа(countNumber) - int newCount = FindNumber(); . Либо вызываем функцию внури консоли - Console.WriteLine(FindNumber()); где хранится
// //число и сразу жн его выводим.

// int[] CreateArray()      //Вводим тип массива int[] и назовем его CreateArray()
// {
//      for (int i = 0; i < array.Length; i++)   
//      {
//          array[i] = new Random().Next(10, 101);
//          System.Console.Write(array[i]+ " ");
//      }
//      return array;        //Выводим результат нашей функции CreateArray() и результат - array

// }

// int FindNumber()
// {
//     int countNumber = 0;        //Создаем переменную для сохранения чисел, которые подходят под условие.

//     for (int i = 0; i < array.Length; i++) 
//     {
//         if(array[i] %10 == 1 && array[i] %7 == 0)         //Проверка, что последняя цифра = 1 (array[i] %10 == 1) // и элемент массива делится нацело на 7 (array[i] %7 == 0)
//         {
//             countNumber = countNumber+1;       //Если условие верно - то увеличиваем счетчик на 1 и выводим
//         }
//     }
//     return countNumber;
// }



// Задача 3. Заполните массив на N (вводится с консоли, не более 8) случайных чисел от 0 до 9. Сформируйте целое число, котрое будет
//           состоять из цифр из массива. Старший разряд числа находится на 0-м индексе, младший на последнем.
//           Пример:
//           [1 3 2 4 2 3] => 132423
//           [2 3 1] => 231


// System.Console.WriteLine("Введите размер массива");        
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];                       

// CreateArray();  

//  int[] CreateArray()     
// {
//      for (int i = 0; i < array.Length; i++)   
//      {
//          array[i] = Convert.ToInt32(Console.ReadLine());  //Даем пользователю в каждый элемент массива ввести цифру в число
//          //array[i] - это int, а Console.ReadLint() - это string, значит надо конвертировать - Convert.ToInt32(Console.ReadLine());
//          //На консоль можно не выводить.
//      }
//      return array; 
// }

// string numPerson ="";        //Создаем переменную string и с помощью цикла проходимся по всем элементам

// for (int i = 0; i < array.Length; i++)   
//     {
//         numPerson = numPerson + array[i];    //numPerson - это string, а array[] - это int.Чтобы решить конфликт - запишем 
//         // их в строчку - numPerson + array[i]
//        //Когда мы складываем строчку с числом, программа сама конвертирует число в строчку
//     }

//     int rusult = Convert.ToInt32(numPerson);    //Создаем переменную rusult и в конверт для преобразования string в int.
//     System.Console.WriteLine(rusult);           //И выводим


//Тоже с помщью дополнительной функции:
// System.Console.WriteLine("Введите размер массива");        
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];                       

// CreateArray();  

//  int[] CreateArray()     
// {
//      for (int i = 0; i < array.Length; i++)   
//      {
//          array[i] = Convert.ToInt32(Console.ReadLine());  //Даем пользователю в каждый элемент массива ввести цифру в число
//          //array[i] - это int, а Console.ReadLint() - это string, значит надо конвертировать - Convert.ToInt32(Console.ReadLine());
//          //На консоль можно не выводить.
//      }
//      return array; 
// }

// GetNum();         //Вызываем функцию

//   void GetNum()
//   {
//     string numPerson ="";        //Создаем переменную string и с помощью цикла проходимся по всем элементам

//     for (int i = 0; i < array.Length; i++)   
//      {
//          numPerson = numPerson + array[i];    
//      }

//     int result = Convert.ToInt32(numPerson);      
//     System.Console.WriteLine(result);            //Здесь return нет, потму что нам возвращать ничего ен надо, а потому стоит void (пробка).
//   }  
          
// Название функции всегда пишется с большой буквы, а название переменной с маленнькой!


// Задача 1. Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом массиве.
//   Пример:
//   [1 3 4 19 3] => 3       
//   [4 3 4 1 9 5 21 13] => 3

//  Простые числа - это числа, которые делятся на "самих себя" и на "1" без остатка, и больше ни на что!
//  Для их определения: нужно число поделить на 2,3,4,5... до самого числа(чтоб не было остатка)!




// System.Console.WriteLine("Введите размер массива");        
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];                       

// CreateArray();  

//  int[] CreateArray()     
// {
//    for (int i = 0; i < array.Length; i++)    
//      {
//          array[i] = new Random().Next(10, 101);
//          System.Console.WriteLine(array[i] + " ");     
//      }
//      return array; 
// }

//      int countNumber = 0;           //Создаем переменную для хранения числа после проверки if(isFind == false)

//    for (int i = 0; i < array.Length; i++)
//    {
//     bool isFind = false;           //Создаем bool переменную, которая будет служить индикаторм - подходит нам число в проверке или нет

//     for (int j = 2; j < array[i]; j++)      //Начинаем деление с "2", поэтому "2" вместо "0". Делим до тех пор, пока не дойдем до "самого себя"(array[])
//     {
//         if(array[i] % j == 0)
//         {
//             isFind = true;           //Если какое-то число делится без остатка - значит оно нам не подходит, и переменную меняем на true
//         }
//     }
    
//     if(isFind == false)            //Делаем проверку - если bool число не изменилось
//     {
//         countNumber = countNumber + 1;     //Если число подходит, увеличиваем счетчик на "1"
//     }
//    }
//    System.Console.WriteLine();
//    System.Console.WriteLine(countNumber);


// Тоже спомощью функции:


 System.Console.WriteLine("Введите размер массива");        
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];                       

CreateArray();  

 int[] CreateArray()     
{
   for (int i = 0; i < array.Length; i++)    
     {
         array[i] = new Random().Next(10, 101);
         System.Console.WriteLine(array[i] + " ");     
     }
     return array; 
}

FindPrimeNumbers();       // Перводится как - "найти прстое число"
void FindPrimeNumbers()
{
  int countNumber = 0;           

   for (int i = 0; i < array.Length; i++)
   {
    bool isFind = false;           //Создаем bool переменную, которая будет служить индикаторм - подходит нам число в проверке или нет

    for (int j = 2; j < array[i]; j++)      //Начинаем деление с "2", поэтому "2" вместо "0". Делим до тех пор, пока не дойдем до "самого себя"(array[])
    {
        if(array[i] % j == 0)
        {
            isFind = true;           //Если какое-то число делится без остатка - значит оно нам не подходит, и переменную меняем на true
        }
    }
    
    if(isFind == false)            //Делаем проверку - если bool число не изменилось
    {
        countNumber = countNumber + 1;     //Если число подходит, увеличиваем счетчик на "1"
    }
   }
   System.Console.WriteLine();
   System.Console.WriteLine(countNumber);
}

