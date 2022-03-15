// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

int Enter(string message) {
    Console.WriteLine(message);
    string numberInput = Console.ReadLine();
    int number = int.Parse(numberInput);
    return number;
}

int N = Enter("Введите пятизначное число");

if(N < 0) N = N*(-1);

int[] array = new int[5];
int i = 0;
int A = 0;

for(i = 0; i < 5; i++){
    A = N % 10;
    array[i] = A; 
    N = N / 10;
}

i = 0;
int len = 5;
string answer = "Полиндром";

while(i < len/2){
    if(array[i] != array[len - i - 1]) {
        answer = "Не полиндром";
        break;
    }
    else if(array[i] == array[len - i - 1]){
        i++;
    }
}  

Console.Write(answer);