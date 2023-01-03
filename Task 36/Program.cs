// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        if ((i+1) % 2 == 1){
            sum = sum + array[i];
        }
    }
    Console.Write($"Сумма элементов на нечетных позициях: {sum}");
}

Console.Write("Введите количество элементов массива: ");
int numb = Convert.ToInt32(Console.ReadLine());
int [] CreatedArray = CreateArray(numb, 1, 99);
ShowArray(CreatedArray);
Count(CreatedArray);