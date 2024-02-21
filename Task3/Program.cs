void Main(){

    int[] myArray = GenerateArray(7, 0, 9);
    ShowArray(myArray);
    TurnArray(myArray);
    ShowArray(myArray);

}

int[] GenerateArray(int size, int leftRange, int rightRange){
    int[] array = new int[size];

    Random random = new Random();

    for(int i = 0; i < array.Length; i++){
        array[i] = random.Next(leftRange, rightRange+1);
    }
    
    return array;
}

int[] TurnArray(int[] array){

    int numToSave = array[0];

    for(int i = 0, s = array.Length - 1; i < array.Length; i++, s-- ){

        if(i == s){
            break;
        } else if (i + 1 == s){
            array[i] = array[s];
            array[s] = numToSave;
            break;
        } else {
            array[i] = array[s];
            array[s] = numToSave;
            numToSave = array[i+1];
        }
    }
    return array;
}

void ShowArray(int[] array){
    System.Console.WriteLine("[" + string.Join( ",", array) + "]");
}

Main();
