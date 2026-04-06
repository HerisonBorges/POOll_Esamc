using BibliotecaConversao;
using BibliotecaCalculos;

var conv = new Conversores();

Console.Write("Celsius: ");
double celsius = double.Parse(Console.ReadLine()!);
Console.WriteLine($"{celsius}°C = {conv.CelsiusParaFahrenheit(celsius):F1}°F");

Console.Write("metros: ");
double metros = double.Parse(Console.ReadLine()!);
Console.WriteLine($"{metros}m = {conv.MetrosParaQuilometros(metros)}km");

Console.Write("valor em reais: ");
double valor = double.Parse(Console.ReadLine()!);
Console.Write("Digite a taxa de câmbio : ");
double taxa = double.Parse(Console.ReadLine()!);
Console.WriteLine($"R${valor} = {conv.ConverterMoeda(valor, taxa):F2} na moeda de destino");


var calcArea = new CalculadoraArea();

Console.Write("Base: ");
double baseR = double.Parse(Console.ReadLine());

Console.Write("Altura: ");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine($"Área = {calcArea.AreaRetangulo(baseR, altura)}");