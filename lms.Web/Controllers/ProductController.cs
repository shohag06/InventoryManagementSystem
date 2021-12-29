using AutoMapper;
using lms.Model;
using lms.Service.Contracts;
using lms.Web.Models.ProductVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lms.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        ICategoryService _categoryService;
        private IMapper _mapper;
        public ProductController(IProductService productService, ICategoryService categoryService, IMapper mapper)
        {
            _productService = productService;
            _categoryService = categoryService;
            _mapper = mapper;
        }


        // GET: Product
        public ActionResult Index()
        {
            var products = _productService.GetAll();

            var productViewModelList = _mapper.Map<IEnumerable<ProductViewModel>>(products);

            return View(productViewModelList);
        }



        // GET: Product/Create
        public ActionResult Create()
        {
            List<SelectListItem> categoryListItems = _categoryService.GetAll().Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();

            var model = new ProductCreateViewModel();
            model.CategoryItemList = categoryListItems;
            model.ProductList = _productService.GetAll();
            return View(model);
        }



        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCreateViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var product = _mapper.Map<Product>(model);

                    bool isAdded = _productService.Add(product);
                    if (isAdded)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }

                return View();


            }
            catch
            {
                return View();
            }
        }


        public IActionResult Edit(int id)
        {
            List<SelectListItem> categoryListItems = _categoryService.GetAll().Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();
            

            var model = _productService.GetById(id);
            var product  = _mapper.Map<ProductEditViewModel>(model);
            product.CategoryItemList = categoryListItems;

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product model)
        {
           
            if (ModelState.IsValid)
            {
               
                bool isSaved = _productService.Update(model);

                if (isSaved)
                {
                    return RedirectToAction(nameof(Index));
                }


            }
         
            

            return View();
        }


    }
}
