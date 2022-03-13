using inventarioSystem.Context;
using inventarioSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace inventarioSystem.Controllers.Category
{
    public class CategoryController : Controller
    {
        public InventarioContext context { get; set; }
        public dynamic model { get; set; }

        public CategoryController()
        {
            context = new InventarioContext();
            model = new ExpandoObject();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var categorias = context.categoria.ToList();
            model.categorias = categorias;
            return View(model);
        }
        public JsonResult Update()
        {
            var categorias = context.categoria.ToList();
            model.categorias = categorias;
            return Json(model);
        }
        public IActionResult Index(int id)
        {
            var categoria = context.categoria.Find(id);
            model.categoria = categoria;
            return View(model);
        }

        public JsonResult JgetCategory(int id)
        {
            var categoria = context.categoria.Find(id);
            return Json( new { data = categoria });
        }
        [HttpPost]
        public JsonResult Create(Categoria category)
        {
            if(category.id > 0)
            {

                context.categoria.Update(category);
            }
            else
            {
                
                context.categoria.Add(category);
            }
            
            context.SaveChanges();
            return Json(new
            {
               data = category,
               success = true
            });


        }
        [HttpGet]
        public JsonResult Edit(int id)
        {
            var category = context.categoria.Find(id);
            return Json(category);
            //return Json(new
            //{
            //    success = true,
            //    category = category
            //});
        }

        public JsonResult Delete(int id)
        {
            var category = context.categoria.Find(id);
            context.categoria.Remove(category);
            context.SaveChanges();
            return Json(new {
                success = true 
            });
        }

        public JsonResult Buscar(int id)
        {
            var categoria =context.categoria.Find(id);
            return Json(categoria);
        }
    }
}
