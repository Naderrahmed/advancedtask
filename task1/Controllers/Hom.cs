using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace task1.Controllers
{
    public class Hom: Controller
    {
        // GET: /<controller>/
        public string Index ()
        {
            return" this is my task1 " ;
        }
    }
}
