using System;
using GeekLanches.Application.Dtos.Ingrediente;
using GeekLanches.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GeekLanches.UI.Controllers
{
    public class IngredienteController : BaseController
    {
        private readonly IIngredienteService _service;

        public IngredienteController(IIngredienteService service)
        {
            _service = service;
        }

        // GET: Ingrediente
        public ActionResult Index(string nome = null)
        {
            var ingredientes =
            _service.List(filter: nome);

            if (Request.IsAjaxRequest())
                return PartialView("_Ingredientes", ingredientes);
            return View(ingredientes);
        }

        public ActionResult Inflacao(decimal percentual)
        {
            _service.AplicaInflacao(percentual);

            var ingredientes = _service.List("");
            return PartialView("_Ingredientes", ingredientes);
        }

        // GET: Ingrediente/Details/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXXX
        public ActionResult Details(Guid id)
        {
            var receita = _service.FindById(id);
            return View(receita);
        }

        // GET: Ingrediente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ingrediente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IngredienteInsertDto dto)
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
            return Details(id);
        }

        // POST: Ingrediente/Edit/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXXX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(IngredienteDto dto)
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