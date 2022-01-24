using System;
using System.Collections.Generic;

#nullable disable

namespace SGCR_Iberia.Models
{
    public partial class TblDocente
    {
        public TblDocente()
        {
            TblReservas = new HashSet<TblReserva>();
        }

        public int IdDocente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Correo { get; set; }
        public int IdCurso { get; set; }

        public virtual TblCurso IdCursoNavigation { get; set; }
        public virtual ICollection<TblReserva> TblReservas { get; set; }
    }
}
