//Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.
Console.Clear();
Console.WriteLine("Контрольная работа");
// Для выбора варианта тестирования раскоментируйте выбранную строку с инициализацией массива.
string[] testArray = {"hello", "2", "world", ":-)"};
// string[] testArray = {"1234", "1567", "-2", "computer science"};
// string[] testArray = {"Russia", "Denmark", "Kazan", };

void printArray(string[] a) {
    int rank = a.Rank;
    int rowSize = a.GetUpperBound(0) + 1;
    Console.Write("[ ");
    bool isFirst = true;
    for (int i = 0; i < rowSize; i++) {
        string prefix = isFirst ? "" : ", ";
        if (isFirst) { isFirst = false; }
        Console.Write($"{prefix}\"{a[i]}\" ");
    }
    Console.Write(" ]");
}
printArray(testArray);
int outLength = 0;
for(int col = 0; col<testArray.Length; col++) {
    if (testArray[col].Length <=3) {
        outLength++;
    }
}
if (outLength > 0) {
    string[] outArray = new string[outLength];
    int index = 0;
    for(int col = 0; col<testArray.Length; col++) {
        if (testArray[col].Length <=3) {
            outArray[index] = String.Copy(testArray[col]);
            index++;
        }
    }
    Console.Write($" -> " );
    printArray(outArray);
} else {
    Console.Write($" -> массив не содержит строк с заданными параметрами." );
}
Console.WriteLine();
