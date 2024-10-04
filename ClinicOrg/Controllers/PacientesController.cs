using Microsoft.AspNetCore.Mvc;
using ClinicOrg.Models;
using ClinicOrg.Data;


namespace ClinicOrg.Controllers
{
    public class PacientesController : Controller
    {
        Paciente _paciente = new Paciente();
        public IActionResult Listar()
        {
            //mostrara la lista de pacientes
            var oLista = _paciente.
            return View(oLista);
        }


        public IActionResult Guardar()
        {
            //metodo que solo devuelve la vista
            return View();
        }

        public IActionResult Guardar()
        {

            
            //metodo recibe el objeto para guardarlo en db
            return View();
        }
    }
}
