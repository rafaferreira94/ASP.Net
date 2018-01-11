using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeiroSite.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "Hello World";
        }

        // GET: HelloWorld/FalaGalera
        public string FalaGalera()
        {
            return "Fala Galera!!!";
        }

        // GET: HelloWorld/Somar
        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}