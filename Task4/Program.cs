Console.Clear();

Console.WriteLine("Алгоритм формирует массив строк с длинной 3 из сгенерированного массива строк");

int arrayLength = new Random().Next(3,20);
string[] array = new string[arrayLength];

void GenerateStringValuesToArray(string[] arr){
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    for (int i=0; i<arr.Length;i++) {
     arr[i] = new string(Enumerable.Repeat(chars, new Random().Next(1,10))
        .Select(s => s[new Random().Next(0,chars.Length)]).ToArray());
    }
}

GenerateStringValuesToArray(array);

Console.WriteLine($"Длинна массива равна {arrayLength}");
Console.WriteLine($"Сгенерированный массив [{string.Join(" ,", array)}]");

int maxLengthString =3;
string[] GenerateNewArray(string[] arr){
    string needValueArray = "";

    for(int i=0;i<arr.Length;i++){
        if(arr[i].Length<=maxLengthString) {
            if(i!=0) needValueArray+=",";
            needValueArray+=arr[i];
        }
    }

    return needValueArray.Split(",");
}

string[] newArray = GenerateNewArray(array);

Console.WriteLine($"Получившийся массив [{string.Join(" ,", newArray)}]");