void Main(){
    for(;;){
    String str = GetValue();
    if(CheckIfSym(str)||IsEven(CheckIfNum(str))){
        break;
    }
    }
}

String GetValue(){

    System.Console.Write("Введите число: ");
    String a = Console.ReadLine();
    return a;
}

bool IsEven(int number){
    if(number % 2 == 0){
        return true;
    }else{
        return false;
    }
}

int CheckIfNum(String value){
    int number = Convert.ToInt32(value); 
    int sum = 0;
    while (number > 0){
        sum = sum + number%10;
        number /= 10;
    }
    return sum;
}

bool CheckIfSym(String value){
    if(value == "q"){
        return true;
    } else {
        return false;
    }
}


Main();
