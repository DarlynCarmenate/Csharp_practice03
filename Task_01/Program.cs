// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Решение через массив

Console.WriteLine("Введите любое число");
string numberInput = Console.ReadLine();
int len = numberInput.Length;
int N = int.Parse(numberInput);

if(N < 0) N = N*(-1);

int[] array = new int[len];
int i = 0;
int A = 0;

for(i = 0; i < len; i++){
    A = N % 10;
    array[i] = A; 
    N = N / 10;
}

i = 0;
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