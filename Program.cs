/*using EspacioCalculadora;

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
}*/

using EspacioEmpresa;

Empleado Juan = new Empleado();
Juan.Apellido ="Rosales";
Juan.EstadoCivil = 'C';
Juan.FechaNac = "1996-11-02";
Juan.FechaIng = "2015-09-23";
Juan.Genero = 'M';
Juan.Nombre = "Juan";
Juan.SueldoBasico = 25000;
Juan.ObtenerCargoAleatorio();
Juan.Antiguedad();
Juan.Edad();
Juan.CalcularSalario();

Empleado Marcos = new Empleado();
Marcos.Apellido ="Perez";
Marcos.EstadoCivil = 'S';
Marcos.FechaNac = "2000-02-24";
Marcos.FechaIng = "2003-12-01";
Marcos.Genero = 'M';
Marcos.Nombre = "Marcos";
Marcos.SueldoBasico = 20000;
Marcos.Antiguedad();
Marcos.Edad();
Marcos.ObtenerCargoAleatorio();
Marcos.CalcularSalario();

Empleado Ana = new Empleado();
Ana.Apellido ="Bernachi";
Ana.EstadoCivil = 'C';
Ana.FechaNac = "1950-01-01";
Ana.FechaIng = "2000-12-01";
Ana.Genero = 'F';
Ana.Nombre = "Ana";
Ana.SueldoBasico = 22000;
Ana.Antiguedad();
Ana.Edad();
Ana.ObtenerCargoAleatorio();
Ana.CalcularSalario();

Console.WriteLine("La antiguedad de "+Juan.Nombre+" "+Juan.Apellido+" es "+ Juan.Antig);
Console.WriteLine("La edad de "+Juan.Nombre+" "+Juan.Apellido+" es "+ Juan.Anios);
Console.WriteLine("A "+Juan.Nombre+" "+Juan.Apellido+" le falta "+ Juan.Jub+" años para jubilarse");
Console.WriteLine("El cargo de "+Juan.Nombre+" "+Juan.Apellido+" es "+ Juan.Cargo);
Console.WriteLine("El salario de "+Juan.Nombre+" "+Juan.Apellido+" es "+ Juan.Salario);

Console.WriteLine("La antiguedad de "+Marcos.Nombre+" "+Marcos.Apellido+" es "+ Marcos.Antig);
Console.WriteLine("La edad de "+Marcos.Nombre+" "+Marcos.Apellido+" es "+ Marcos.Anios);
Console.WriteLine("A "+Marcos.Nombre+" "+Marcos.Apellido+" le falta "+ Marcos.Jub+" años para jubilarse");
Console.WriteLine("El cargo de "+Marcos.Nombre+" "+Marcos.Apellido+" es "+ Marcos.Cargo);
Console.WriteLine("El salario de "+Marcos.Nombre+" "+Marcos.Apellido+" es "+ Marcos.Salario);

Console.WriteLine("La antiguedad de "+Ana.Nombre+" "+Ana.Apellido+" es "+ Ana.Antig);
Console.WriteLine("La edad de "+Ana.Nombre+" "+Ana.Apellido+" es "+ Ana.Anios);
Console.WriteLine("A "+Ana.Nombre+" "+Ana.Apellido+" le falta "+ Ana.Jub+" años para jubilarse");
Console.WriteLine("El cargo de "+Ana.Nombre+" "+Ana.Apellido+" es "+ Ana.Cargo);
Console.WriteLine("El salario de "+Ana.Nombre+" "+Ana.Apellido+" es "+ Ana.Salario);