using DocumentFormat.OpenXml.Wordprocessing;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ReservaDiscotecas_P.Models
{
    public class Reservas
    {
        [Key]
        public int IdReserva { get; set; }
        public DateTime Fecha { get; set; }

        [DisplayName("Numero de Asistentes / max 5 por reserva")]
        [Range(1,5)]
        public int asistentesNum {  get; set; }
        public TimeSpan horaLlegada { get; set; }
        public bool botella { get; set; }

    }
}
