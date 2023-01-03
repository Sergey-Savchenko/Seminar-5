// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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
        if (array[i]>9 && array[i]<100){
            sum = sum + 1;
        }
    }
    Console.Write($"Количество двузначных элементов в массиве: {sum}");
}

Console.Write("Введите количество элементов массива: ");
int numb = Convert.ToInt32(Console.ReadLine());
int [] CreatedArray = CreateArray(numb, 1, 999);
ShowArray(CreatedArray);
Count(CreatedArray);