void Main(){
    int[] myArray = CreateArray(10, 100, 999);
    int value = NumOfEven(myArray);
    ShowResult(myArray, value);
}

int[] CreateArray(int size, int leftRange, int rightRange){
    int[] array = new int[size];

    Random random = new Random();

    for(int i = 0; i < array.Length; i++){
        array[i] = random.Next(leftRange, rightRange+1);
    }
    
    return array;
}

int NumOfEven(int[] array){
    int count = 0;

    for(int i = 0; i < array.Length; i++){
        if(array[i] % 2 == 0){
            count =+1;
        }
    }

    return count;
}

void ShowResult(int[] array, int result){
    System.Console.WriteLine("[" + string.Join( ",", array) + "]");
    System.Console.Write("= " + result);
}
Main();

