
while (true)
{
    Console.WriteLine("Bienvenido al programa de calculo de area de triagunlos");
    Console.ReadKey();
    Console.WriteLine("Introdusca la altura porfavor");
    int altura = int.Parse(Console.ReadLine());
    Console.WriteLine("Introdusca la Base del triangulo porfavor");
    int Base = int.Parse(Console.ReadLine());
    int resultado = Base * altura / 2;
    Console.WriteLine("El resultado es: " + resultado);
    Console.ReadKey(); 
}
