// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double [] CreateArray(int size, double minValue, double maxValue){
    double [] array = new double[size];
    for(int i=0; i<size; i++){
        array[i] = new Random().NextDouble();
    }
    return array;
}

void ShowArray(double [] array){
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Count(double [] array){
    double min = array [0];
    double max = array [0];
    for(int i=0; i<array.Length; i++){
        if (array[i]<min){
            min=array[i];
        }
        if (array[i]>max){
            max=array[i];
        }
    }
    Console.WriteLine($"Минимальное значение массива: {min} ");
    Console.WriteLine($"Максимальное значение массива: {max} ");
    Console.WriteLine($"Разница между ними: {max-min}");
}

Console.Write("Введите количество элементов массива: ");
int numb = Convert.ToInt32(Console.ReadLine());
double [] CreatedArray = CreateArray(numb, 1, 999);
ShowArray(CreatedArray);
Count(CreatedArray);