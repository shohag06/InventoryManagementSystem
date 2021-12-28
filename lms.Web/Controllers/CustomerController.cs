using lms.Model;
using lms.Service.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lms.Web.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Create()
        {

            //List<SelectListItem> addressDataList = new List<SelectListItem>()
            //{

            //    new SelectListItem(){Value="DHK",Text="Dhaka"},
            //    new SelectListItem(){Value="CTG",Text="Chittagong"},
            //    new SelectListItem(){Value="RAJ",Text="Rajshahi"},
            //    new SelectListItem(){Value="SYL",Text="Sylhet"},
            //    new SelectListItem(){Value="BAR",Text="Barishal"},
            //};

            //ViewBag.AddressList = addressDataList;

            return View();
        }


        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                bool isSaved = _customerService.Add(customer);

                if (isSaved)
                {
                    return RedirectToAction("Details", customer);
                }


            }

            return View();
        }



    }
}
