using System;
using System.Collections.Generic;

#nullable disable

namespace SGCR_Iberia.Models
{
    public partial class TblAsignacion
    {
        public int IdAsignacion { get; set; }
        public string Novedades { get; set; }
        public int IdReserva { get; set; }

        public virtual TblReserva IdReservaNavigation { get; set; }
    }
}
