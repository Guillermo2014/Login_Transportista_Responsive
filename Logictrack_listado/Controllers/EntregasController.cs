using Logictrack_listado.API;
using Logictrack_listado.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Logictrack_listado.Controllers
{
    public class EntregasController : Controller
    {

        Backend _api = new Backend();
        // GET: Entregas
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Create()
        {
            List<Entregas> entregas = new List<Entregas>();

            HttpClient client = _api.Initial();
            HttpResponseMessage response = await client.GetAsync("docEntregasTransportista");


            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                entregas = JsonConvert.DeserializeObject<List<Entregas>>(result);
            }

            return View();
        }

        [HttpPost]
        public ActionResult Create(Entregas entrega)
        {
            HttpClient client = _api.Initial();
            var postTask = client.PostAsJsonAsync<Entregas>("docEntregasTransportista", entrega);
            postTask.Wait();
            var result = postTask.Result;

            if (result.IsSuccessStatusCode)
            {
                ViewBag.Message = "El comentario se registro correctamente";
                return RedirectToAction("Index");
            }

            ViewBag.Message = "Error al registrar";
            return View();
        }
    }
}