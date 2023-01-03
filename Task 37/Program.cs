// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int [] Count(int [] array){
    int [] newarray = new int[array.Length/2];
    for(int i=0; i<array.Length/2; i++){
        newarray[i] = array[i] * array[array.Length-i-1];
        Console.Write($"{newarray[i]} ");
    }
    return newarray;
}

Console.Write("Введите количество элементов массива: ");
int numb = Convert.ToInt32(Console.ReadLine());
int [] CreatedArray = CreateArray(numb, 1, 9);
ShowArray(CreatedArray);
int [] SecondArray = Count(CreatedArray);