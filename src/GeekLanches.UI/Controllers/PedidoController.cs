using System;
using System.Linq;
using GeekLanches.Application.Dtos.Lanche;
using GeekLanches.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GeekLanches.UI.Controllers
{
    public class PedidoController : BaseController
    {
        private readonly ILancheService _service;
        private readonly IIngredienteService _ingredienteService;

        public PedidoController(ILancheService service, IIngredienteService ingredienteService)
        {
            _service = service;
            _ingredienteService = ingredienteService;
        }

        // GET: Lanche
        public ActionResult Index(string nome = null)
        {
            var lanches =
            _service.List(filter: nome);

            if (Request.IsAjaxRequest())
                return PartialView("_Lanches", lanches);
            return View(lanches);
        }

        // GET: Lanche/Details/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXXX
        public ActionResult Save(Guid id)
        {
            var lanche = _service.FindById(id);
            return View(lanche);
        }

        // GET: Lanche/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lanche/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LancheInsertDto dto)
        {
            try
            {
                _service.Create(dto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Edit/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXXX
        public ActionResult Edit(Guid id)
        {
            var lanche = _service.FindById(id);
            return View(lanche);
        }

        public ActionResult EditIngrediente(Guid id)
        {
            var lanche = _service.FindById(id);
            return View(lanche);
        }

        // POST: Lanche/Edit/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXXX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LancheDto dto)
        {
            try
            {
                _service.Update(dto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: Lanche/Edit/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXXX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditIngrediente(LancheDto dto)
        {
            try
            {
                _service.Update(dto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult AlterarIngrediente(string key)
        {
            var keys = key.Split(";");
            Guid idIngrediente = Guid.Parse(keys[0]);
            Guid idLanche = Guid.Parse(keys[1]);
            var ingrediente = _ingredienteService.FindById(idIngrediente);
            var lanche = _service.FindById(idLanche);

            lanche.IngredienteId = ingrediente.Id;
            lanche.IngredienteNome = ingrediente.Nome;

            if (lanche.LancheIngredientes.FirstOrDefault(l => l.IdIngrediente == ingrediente.Id) != null)
                lanche.IngredienteQuantidade = lanche.LancheIngredientes.FirstOrDefault(l => l.IdIngrediente == ingrediente.Id).QtdeIngredientes;

            return EditIngrediente(lanche);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AlterarIngrediente(LancheDto dto)
        {
            try
            {
                _service.Update(dto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }        
    }
}