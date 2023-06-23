using Ejercicio1;

namespace ClasesDelEjercicio
{
    //public interface IPersona
    //{
    //    string DameTuNombre();
    //    int CalcularEdad();
    //}

    //private SOLO EXISTE EN LA MISMA CLASE
    //protected SOLO EXISTE LA CLASE Y EN LOS HIJOS
    //public EXISTE EN TODOS LADOS

    class Persona
    {
        public string Nombre;
        public string Apellido;
        public DateTime FechaNacimiento;
        public int Legajo;
        protected int DNI;
        public string Sexo;

        public Persona(int dni)
        {
            DNI = dni;

            
        }

        public int DameTuDNI()
        {
            return DNI;
        }

        public int CalcularHoras()
        {
            return 0;
        }
    }

    class Alumno : Persona
    {
        public int[] Notas;
        public int HorasCursadas;

        public Alumno(int dni) 
            : base(dni)
        {
        }

        public int CalcularHoras()
        {
            return HorasCursadas;
        }
    }

    class Profesor : Persona
    {
        public int HorasTrabajadas;

        public Profesor(int dni) 
            : base(dni)
        {
        }

        public int CalcularHoras()
        {
            return HorasTrabajadas;
        }
    }

    abstract class Factura
    {
        public double[] Precios;
        public virtual double CalcularTotal()
        {
            double total = 0;
            for (int i = 0; i < Precios.Length; i++)
            {
                total = total + Precios[i];
            }
            return total;
        }
    }

    class FacturaA : Factura
    {
        public override double CalcularTotal()
        {
            double total = base.CalcularTotal();
            return total * 1.21; //total + IVA
        }
    }

    class FacturaB : Factura
    {

        public override double CalcularTotal()
        {
            double total = base.CalcularTotal();
            return total * 1.105; //total + IVA
        }
    }

    class FacturaE : Factura
    {
        public string PaisDestino;
    }
}


