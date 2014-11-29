using System;
using System.Web.Mvc;
using DotBlog.Core.Contracts;
using DotBlog.Core.Objects;
using DotBlog.Core.Repository;

namespace DotBlog.Web.Controllers
{
    public class ListTypeController : Controller
    {

        IRepository<ListType, Guid>  _repository = new Repository<ListType, Guid>(new DotBlogContext());


        //
        // GET: /ListType/

        public ActionResult Index()
        {
            return View(_repository.All());
        }

        //
        // GET: /ListType/Details/5

        public ActionResult Details(Guid id)
        {
            return View(_repository.Get(id));
        }

        //
        // GET: /ListType/Create

        public ActionResult Create()
        {
            var model = new ListType();
            return View(model);
        }

        //
        // POST: /ListType/Create

        [HttpPost]
        public ActionResult Create(ListType model)
        {
            try
            {
                // TODO: Add insert logic here

                _repository.Add(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ListType/Edit/5

        public ActionResult Edit(Guid id)
        {
            return View(_repository.Get(id));
        }

        //
        // POST: /ListType/Edit/5

        [HttpPost]
        public ActionResult Edit(ListType model)
        {
            try
            {
                // TODO: Add update logic here

                _repository.Add(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ListType/Delete/5

        public ActionResult Delete(Guid id)
        {
            return View(_repository.Get(id));
        }

        //
        // POST: /ListType/Delete/5

        [HttpPost]
        public ActionResult Delete(ListType model)
        {
            try
            {
                // TODO: Add delete logic here

                _repository.Delete(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
