using System.Security.Cryptography.X509Certificates;

namespace Vacaciones
{
        public class CadaVacacion
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public string descripcion { get; set; }
            public string empleada { get; set; }
            public DateTime fechaDesde { get; set; }
            public DateTime fechaHasta { get;set; }   
        }
}
