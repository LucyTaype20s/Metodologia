using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGCR_Iberia.Entidades;
using SGCR_Iberia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGCR_Iberia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IberiaController : ControllerBase
    {
        BD_SGCIBeroContext db = new BD_SGCIBeroContext();

        [HttpGet("/ListarDocentes")]
        public IEnumerable<TblDocente> ListarDocente()
        {
            return db.TblDocentes.ToList();
        }
        [HttpGet("/ListarReservas")]
        public IEnumerable<TblReserva> ListarReserva()
        {
            return db.TblReservas.ToList();
        }
        [HttpGet("/ReservasxEspacios/id")]
        public IEnumerable<ReservaEspacio> ReservasxEspacios(int id)
        {
            List<ReservaEspacio> query = (from r in db.TblReservas
                                            join e in db.TblEspacios
                                            on r.IdEspacio equals e.IdEspacio
                                            join d in db.TblDocentes
                                            on r.IdDocente equals d.IdDocente
                                            where r.IdEspacio.Equals(id)
                                            select new ReservaEspacio
                                            {
                                                idReserva = r.IdReserva,
                                                idEspacio=r.IdEspacio,
                                                idDocente=r.IdDocente,
                                                TituloEvento=r.TituloEvento,
                                                Espacio=e.Nombre,
                                                Docente=d.Nombre,
                                                f_inicio=r.FechaInicio,
                                                f_fin=r.FechaFin
                                            }).ToList();
            return query;
        }

    }
}
