using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace task1.Controllers
{
    public class Hom: Controller
    {
        
        public string Index ()
        {
            return" this is my task1 " ;
        }

        public string welcome ()
        {
            return " welcome to this app ";
        }

        public string hello()
        {
            return " hello world  ";
        }


    }
}
