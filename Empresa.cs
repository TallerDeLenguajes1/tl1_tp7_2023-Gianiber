enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
namespace EspacioEmpresa
{
    public class Empleado
    {
        string? nombre;
        string? apellido;
        string? fechaNac;
        char estadoCivil;
        char genero;
        string? fechaIng;
        double sueldoBasico;
        Cargos cargo;
        int antig;
        int anios;
        int jub;
        double salario;
        public void ObtenerCargoAleatorio()
        {
            Random random = new Random();
            Array valoresCargos = Enum.GetValues(typeof(Cargos));
            Cargos cargoAleatorio = (Cargos)valoresCargos.GetValue(random.Next(valoresCargos.Length));
            cargo = cargoAleatorio;
        }


        public void Antiguedad()
        {
            DateTime fechaIngreso = DateTime.Parse(FechaIng);
            DateTime fechaAhora = DateTime.Now;
            TimeSpan diferencia = fechaAhora.Subtract(fechaIngreso);
            antig = (int)(diferencia.TotalDays / 365.25);
        }


        public void Edad()
        {
            DateTime fechaNacimiento = DateTime.Parse(FechaNac);
            DateTime fechaAhora = DateTime.Now;
            TimeSpan diferencia = fechaAhora.Subtract(fechaNacimiento);
            anios = (int)(diferencia.TotalDays / 365.25);
            if (Genero == 'F')
            {
                jub = 60 - anios;
            }
            else
            {
                jub = 65 - anios;
            }
        }

        public void CalcularSalario()
        {
            double adicional;
            if (antig <= 20)
            {
                float ant = antig;
                adicional = sueldoBasico * (ant / 100);
            }
            else
            {
                adicional = sueldoBasico * 0.25;
            }
            if (cargo == Cargos.Especialista || cargo == Cargos.Ingeniero)
            {
                adicional = adicional * 1.5;
            }
            if (estadoCivil == 'C')
            {
                adicional = adicional + 15000;
            }
            salario = sueldoBasico + adicional;
        }

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public char Genero { get => genero; set => genero = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        internal Cargos Cargo { get => cargo; set => cargo = value; }
        public string? FechaNac { get => fechaNac; set => fechaNac = value; }
        public string? FechaIng { get => fechaIng; set => fechaIng = value; }
        public int Anios { get => anios; set => anios = value; }
        public int Jub { get => jub; set => jub = value; }
        public int Antig { get => antig; set => antig = value; }
        public double Salario { get => salario; set => salario = value; }

    }
}