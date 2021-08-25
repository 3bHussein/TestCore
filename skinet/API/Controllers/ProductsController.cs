using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//
using API.Data;
using API.Entites;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        // [HttpGet]
        // public string gettest()
        // {
        //     return "this from here";
        // }

        // [HttpGet("{id}")]
        // public string gettest(int id)
        // {
        //     return "this from here" + id;

        // }


        public ActionResult<List<Product>> getproduct(){


            return  _context.Products.ToList();
        }

    }
}