using EspacioCalculadora;

Calculadora dato = new Calculadora();
Console.WriteLine("¿Que operación desea realizar?");
Console.WriteLine("0-Sumar \n1-Restar \n2-Multiplicar \n3-Dividir \n4-Limpiar \n5-Salir");
int opc = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un número");
double valor = double.Parse(Console.ReadLine());
while (opc != 5)
{
    switch (opc)
    {
        case 0:
            dato.Sumar(valor);
            break;
        case 1:
            dato.Restar(valor);
            break;
        case 2:
            dato.Multiplicar(valor);
            break;
        case 3:
            dato.Dividir(valor);
            break;
        case 4:
            dato.Limpiar();
            break;
        default:
            break;
    }
    Console.WriteLine("El resultado es: " + dato.Resultado);
    Console.WriteLine("¿Que operación desea realizar?\n");
    Console.WriteLine("0-Sumar \n1-Restar \n2-Multiplicar \n3-Dividir \n4-Limpiar \n5-Salir");
    opc = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese un número");
    valor = double.Parse(Console.ReadLine());
}