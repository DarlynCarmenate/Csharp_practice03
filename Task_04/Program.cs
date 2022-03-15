// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

int number = new Random().Next(2, 30);
Console.Write(number + "-> ");

for(int i = 1; i <= number; i++){
    int cube = i*i*i;
    Console.Write(cube + " ");
}
