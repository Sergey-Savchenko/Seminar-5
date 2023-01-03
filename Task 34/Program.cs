// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] CreateArray(int size, int minValue, int maxValue){
    int [] array = new int[size];
    for(int i=0; i<size; i++){
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void ShowArray(int [] array){
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Count(int [] array){
    int sum = 0;
    for(int i=0; i<array.Length; i++){
        if (array[i] % 2 == 0){
            sum = sum + 1;
        }
    }
    Console.Write($"Количество чётных элементов в массиве: {sum}");
}

Console.Write("Введите количество элементов массива: ");
int numb = Convert.ToInt32(Console.ReadLine());
int [] CreatedArray = CreateArray(numb, 100, 999);
ShowArray(CreatedArray);
Count(CreatedArray);