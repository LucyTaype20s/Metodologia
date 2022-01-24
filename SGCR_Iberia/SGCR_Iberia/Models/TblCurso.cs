using System;
using System.Collections.Generic;

#nullable disable

namespace SGCR_Iberia.Models
{
    public partial class TblCurso
    {
        public TblCurso()
        {
            TblDocentes = new HashSet<TblDocente>();
        }

        public int IdCurso { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<TblDocente> TblDocentes { get; set; }
    }
}
