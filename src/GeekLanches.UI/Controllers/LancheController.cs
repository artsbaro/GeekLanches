using System;
using GeekLanches.Application.Dtos.Lanche;
using GeekLanches.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GeekLanches.UI.Controllers
{
    public class LancheController : BaseController
    {
        private readonly ILancheService _service;

        public LancheController(ILancheService service)
        {
            _service = service;
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
        public ActionResult Details(Guid id)
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
            return Details(id);
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
    }
}