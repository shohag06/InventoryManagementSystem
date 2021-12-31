using AutoMapper;
using lms.Model;
using lms.Service.Contracts;
using lms.Web.Models.OrderVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lms.Web.Controllers
{
    public class OrderController : Controller
    {
        private IProductService _productService;
        private IOrderService _orderService;
        private IMapper _mapper;
        private ICustomerService _customerService;
        private IOrderDetailService _detailService;


        public OrderController(IProductService productService,
          IOrderService orderService,
          IMapper mapper,
          ICustomerService customerService,
          IOrderDetailService detailService)
        {
            _mapper = mapper;
            _productService = productService;
            _orderService = orderService;
            _customerService = customerService;
            _detailService = detailService;
        }


        public IActionResult Create()
        {
            var products = _productService.GetAll().Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();
            var customer = _customerService.GetAll().Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.CustomerName
            }).ToList();

            var model = new OrderViewModel()
            {
                ProductSelectItems = products,
                Customers = customer
            };

            return View(model);
        }


        [HttpPost]
        public IActionResult Create(OrderViewModel model)
        {
            var order = _mapper.Map<Order>(model);

            bool isAdded = _orderService.Add(order);

            if (isAdded)
            {
                return RedirectToAction("Index");
            }

            var products = _productService.GetAll().Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();

            model.ProductSelectItems = products;

            return RedirectToAction("Index");
        }
    }
}
