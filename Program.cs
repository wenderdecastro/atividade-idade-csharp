Console.WriteLine($"Que ano você nasceu?");
int anoAniversario = int.Parse(Console.ReadLine());

int ano = DateTime.Today.Year - anoAniversario;

float semanas = ano * 52.1786f; 

Console.WriteLine($"Você tem {ano} anos, que corresponde à {Math.Round(semanas)} semanas");