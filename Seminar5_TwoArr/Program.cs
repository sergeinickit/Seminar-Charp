

//Задание 1.Задайте двумерный массив. Найдите элементы, у которых оба 
// индекса чётные, и замените эти элементы на их квадраты.

// Примеры:
//  2 3 4 3     4 3 4 3 
//  4 3 4 1  => 4 3 4 1
//  2 9 5 4     2 9 25 4


// int[,] array = new int[5,3];        //Двухмерный массив обозначается [,] и справа ставим через запятую "1" - кол-во строчек;
//                                      // и "2" - кол-во столбцов ( new int[5,3] )
// void CreateArray()       // Вводим функцию для заполнения массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)    //Создаем массив.Проходимся по какой-то строчке. (0) размерность - это коол-во строчек (5);
   
//     {
//         for (int j = 0; j < array.GetLength(1); j++)  // Чтобы пройтись по всему массиву - создаем второй цикл.(1) - кол-во столбцов
//         {
//             array[i,j] = new Random().Next(1,10);        //Обращаемся к каждому злементу массива и заполняем его случайными числами
//             // System.Console.Write(array[i,j] + " ");       //Выводим в строчку все элементы. Ставим Write. !
//         }
//     //   System.Console.WriteLine();                   // Делаем пропуск, чтобы получилась таблица
//     }
// }                                    

//  void PrintArray()          //Вводим функцию для вывода массива
//  {
//      for (int i = 0; i < array.GetLength(0); i++) 

//     {
//         for (int j = 0; j < array.GetLength(1); j++)  // Чтобы пройтись по всему массиву - создаем второй цикл.(1) - кол-во столбцов
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//       System.Console.WriteLine();                   // Делаем пропуск, чтобы получилась таблица
//     }
//     System.Console.WriteLine();      // Чтобы избежать дубляжа - выводим изменнеый массив здесь же

//  }  // Сделали  отдельно заполнение массива и вывод массива с помощью функций

//  void ChangeArray()        // Вводим новую функцию для того, чтобы найти элементы(по условию) и их поменять
//  {
//      for (int i = 0; i < array.GetLength(0); i++) 

//     {
//         for (int j = 0; j < array.GetLength(1); j++)  // Чтобы пройтись по всему массиву - создаем второй цикл.(1) - кол-во столбцов
//         {
//             if(i %2 == 0 && j %2 == 0)
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }
//       }

//  }    // В этом блоке поменяли массив 

//  CreateArray();         //Вызываем методы и выводим. Иначе ничего не выведется.
//  PrintArray();
//  ChangeArray();
//  PrintArray();     


//  Задание 2. Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д 
// Пример:
//  2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10
//  2 9 5 4

// int[,] array = new int[6,4];        
                            
// void CreateArray()     
// {
//     for (int i = 0; i < array.GetLength(0); i++)    
   
//     {
//         for (int j = 0; j < array.GetLength(1); j++)  
//         {
//             array[i,j] = new Random().Next(1,10);        
//         }
//     }
// } 

//  void PrintArray()         
//  {
//      for (int i = 0; i < array.GetLength(0); i++) 

//     {
//         for (int j = 0; j < array.GetLength(1); j++)  
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//       System.Console.WriteLine();               
//     }
//     System.Console.WriteLine();      

//  }

//   void FindElArray()        
//  {
//      int sumEl = 0;         // Создаем переменную для хранения подсчета суммы

//      for (int i = 0; i < array.GetLength(0); i++) 

//     {
//         for (int j = 0; j < array.GetLength(1); j++)  
//         {
//             if(i == j)
//             {
//                 sumEl = sumEl + array[i, j];
//             }
//         }
//       }
//       System.Console.WriteLine("Сумма = "+ sumEl);
// }     

//  CreateArray();        
//  PrintArray();
//  FindElArray();
     
              
// Задание 3. Задайте двумерный массив из целых чисел. Сформируйте новый 
// одномерный массив, состоящий из средних арифметических 
// значений по строкам двумерного массива
// Пример:
// 2 3 4 3 
// 4 3 4 1 => [3 3 5]
// 2 9 5 4


// int[,] array = new int[6,4];                    // Создаем двухмерный массив
// double[] array2 = new double[array.GetLength(0)];       // И создаем одномерный массив.Пишем [array.GetLength(0)], чтобы если изменится один массив, 
//                                             // то изменился бы и второй.Делаем массив double т.к. средне-арим. может быть не целым                            
// void CreateArray()     
// {
//     for (int i = 0; i < array.GetLength(0); i++)    
   
//     {
//         for (int j = 0; j < array.GetLength(1); j++)  
//         {
//             array[i,j] = new Random().Next(1,10);        
//         }
//     }
// } 

//  void PrintArray()         
//  {
//      for (int i = 0; i < array.GetLength(0); i++) 

//     {
//         for (int j = 0; j < array.GetLength(1); j++)  
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//       System.Console.WriteLine();               
//     }
//     System.Console.WriteLine();      

//  }

//   void FindElArray()        
//  {
//      for (int i = 0; i < array.GetLength(0); i++) 
//     {
//         int sumEl = 0;         // Создаем переменную для хранения подсчета суммы, но располагаем её между циклами

//         for (int j = 0; j < array.GetLength(1); j++)  
//         {
//             sumEl += array[i,j];   // Тоже, что sumEl = sumEl + array[i,j]
//         }
//         array2[i] = (double)sumEl/array.GetLength(1);  // Если при создании переменной указать double sumEl = 0, то
//                                                          //здесь можно записать без (double) - sumEl/...
//         System.Console.WriteLine("Сумма = "+ sumEl);
//       }
      
// } 

// void PrintArray2()      // Создаем функцию для вывода одномерного массива
// {
//      for (int i = 0; i < array2.Length; i++)
//      {
//         System.Console.Write(array2[i] + " ");
//      } 
// }

//  CreateArray();        
//  PrintArray();
//  FindElArray();
//  PrintArray2();