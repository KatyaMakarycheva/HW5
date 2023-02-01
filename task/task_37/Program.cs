// 37. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// 1. Считывание данных от пользователя 
  int GetArray()
  {
    Console.WriteLine("Введите количество элементов массива: ");
    int amount = Convert.ToInt32(Console.ReadLine());
    return amount;
  }
  

// 2. Создать массив
   int[] CreateArray(int Size)
   {
    return new int[Size];
   }

// 3. Заполнить массив
   void FillArray(int[] Array)
   {
     int Index = 0;
     int Length = Array.Length;

    while (Index < Length-1)
    {
        Console.WriteLine($"{Array[Index]}");
        Array[Index] = new Random().Next(1, 10);
        Index++;
    }
     
   }


// 4. Найти произведения
   int[] GetProduct(int[] Numbers)
   {
    int[] GetNumbers = new int[Numbers.Length / 2];
    
    for (int i = 0; i < Numbers.Length; i++)
    {
        GetNumbers[i] = Numbers[i] * Numbers[Numbers.Length - 1 - i];
        Console.Write($"{Numbers[i]}");
    }
    return GetNumbers;
   }

// 5. Распечатать
   string Print(int[] collection)
   {
    string output = String.Empty;
    int size = collection.Length;

    for (int i = 0; i < size; i++)
    {
        output = output + $"{collection[i]}";
    }
    return output;
   }

   int size = GetArray();
   int [] result = CreateArray(size);
   FillArray(result);
   int[] arr = GetProduct(result);





