using System.ComponentModel.DataAnnotations;

namespace T2_Malasquez_Diego.Models
{
    public class Distribuidor
    {
        [Key]

        public int Id { get; set; }

        public string NombreDistribuidor { get; set; }
        public string RazonSocial { get; set; }
        public int Telefono { get; set; }
        public int AñoInicioOperacion { get; set; }

        public string Contacto { get; set; }
     }
}
