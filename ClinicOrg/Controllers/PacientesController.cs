using Microsoft.AspNetCore.Mvc;
using ClinicOrg.Models;
using ClinicOrg.Data;


namespace ClinicOrg.Controllers
{
    public class PacientesController : Controller
    {
        PacienteDatos _pacienteDatos = new PacienteDatos();
        public IActionResult Listar()
        {
            //mostrara la lista de pacientes
            var oLista = _pacienteDatos.Listar();
            return View(oLista);
        }


        public IActionResult Guardar()
        {
            //metodo que solo devuelve la vista
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(Paciente oPaciente)
        {
            //metodo que solo devuelve la vista
            var respuesta = _pacienteDatos.Guardar(oPaciente);
            if (respuesta)
                return RedirectToAction("Listar");
            else
            return View();
        }
    }
}
