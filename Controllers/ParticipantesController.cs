
using Microsoft.AspNetCore.Mvc;
using RegistroComunitarioComunidadConectada.Web.Models;
using RegistroComunitarioComunidadConectada.Web.Data;

namespace RegistroComunitarioComunidadConectada.Web.Controllers
{
    public class ParticipantesController : Controller
    {
        private readonly ParticipanteRepo _repositorio;


        public ParticipantesController(ParticipanteRepo repositorio)
        {
            _repositorio = repositorio;
        }



        public IActionResult Index()
        {
            var viewModel = new ParticipantesViewModel
            {
                ListaParticipantes = _repositorio.GetAll()

            };
            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registrar(Participante nuevoParticipante)
        {
            if (ModelState.IsValid)
            {
                _repositorio.Add(nuevoParticipante);
                return RedirectToAction(nameof(Index));
            }


            var viewModelConError = new ParticipantesViewModel
            {
                ListaParticipantes = _repositorio.GetAll(),
                NuevoParticipante = nuevoParticipante
            };

            return View("Index", viewModelConError);

        }

    }
}