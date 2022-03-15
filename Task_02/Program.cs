// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Решение через строку.

Console.WriteLine("Введите любое число");
string number = Console.ReadLine();
int len = number.Length;

if(number < 0) number = number*(-1);

i = 0;
string answer = "Полиндром";

while(i < len/2){
    if(number[i] != number[len - i - 1]) {
        answer = "Не полиндром";
        break;
    }
    else if(number[i] == number[len - i - 1]){
        i++;
    }
}  

Console.Write(answer);