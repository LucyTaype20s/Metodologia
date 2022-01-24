using System;
using System.Collections.Generic;

#nullable disable

namespace SGCR_Iberia.Models
{
    public partial class TblEspacio
    {
        public TblEspacio()
        {
            TblReservas = new HashSet<TblReserva>();
        }

        public int IdEspacio { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<TblReserva> TblReservas { get; set; }
    }
}
