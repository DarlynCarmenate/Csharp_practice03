// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.

int Prompt(string message){
    Console.Write(message);
    string input = Console.ReadLine();
    int value = int.Parse(input);
    return value;
}

int x1 = Prompt("Введите x1: ");
int y1 = Prompt("Введите y1: ");
int z1 = Prompt("Введите z1: ");
int x2 = Prompt("Введите x2: ");
int y2 = Prompt("Введите y2: ");
int z2 = Prompt("Введите z2: ");

int x3 = x1 - x2;
int y3 = y1 - y2;
int z3 = z1 - z2;

double result = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2) + Math.Pow(z3, 2));

Console.Write($"Расстояние между точками: {result});

