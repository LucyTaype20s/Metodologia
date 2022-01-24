using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGCR_Iberia.Entidades
{
    public class ReservaEspacio
    {
        public int idReserva{ get; set; }
        public int idEspacio{ get; set; }
        public int idDocente { get; set; }
        public string TituloEvento { get; set; }
        public string Espacio { get; set; }
        public DateTime? f_inicio { get; set; }
        public DateTime? f_fin { get; set; }
        public string Docente { get; set; }
    }
}
