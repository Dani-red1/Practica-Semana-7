using RegistroComunitarioComunidadConectada.Web.Models;
using System.Collections.Generic;

namespace RegistroComunitarioComunidadConectada.Web.Models
{
    public class ParticipantesViewModel
    {

        public IEnumerable<Participante> ListaParticipantes { get; set; } = new List<Participante>();


        public Participante NuevoParticipante { get; set; } = new Participante();
    }
}
