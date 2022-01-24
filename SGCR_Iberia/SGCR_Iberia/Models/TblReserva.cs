using System;
using System.Collections.Generic;

#nullable disable

namespace SGCR_Iberia.Models
{
    public partial class TblReserva
    {
        public TblReserva()
        {
            TblAsignacions = new HashSet<TblAsignacion>();
        }

        public int IdReserva { get; set; }
        public string TituloEvento { get; set; }
        public string Descripcion { get; set; }
        public int IdUsuario { get; set; }
        public int IdEspacio { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int IdDocente { get; set; }

        public virtual TblDocente IdDocenteNavigation { get; set; }
        public virtual TblEspacio IdEspacioNavigation { get; set; }
        public virtual TblUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<TblAsignacion> TblAsignacions { get; set; }
    }
}
