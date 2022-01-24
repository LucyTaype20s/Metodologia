using System;
using System.Collections.Generic;

#nullable disable

namespace SGCR_Iberia.Models
{
    public partial class TblUsuario
    {
        public TblUsuario()
        {
            TblReservas = new HashSet<TblReserva>();
        }

        public int IdUsuario { get; set; }
        public string Users { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }

        public virtual ICollection<TblReserva> TblReservas { get; set; }
    }
}
