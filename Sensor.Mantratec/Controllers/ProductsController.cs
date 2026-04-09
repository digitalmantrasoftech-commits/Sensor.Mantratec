using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sensor.Mantratec.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult MELO31()
        {
            return View("~/Views/Products/Optical-Scanners/MELO31.cshtml");
        }
        public ActionResult MFS500()
        {
            return View("~/Views/Products/Optical-Scanners/MFS500.cshtml");
        }
        public ActionResult MFS110()
        {
            return View("~/Views/Products/Optical-Scanners/MFS110.cshtml");
        }
        public ActionResult MFS210()
        {
            return View("~/Views/Products/Optical-Scanners/MFS210.cshtml");
        }
        public ActionResult MELO31Modules()
        {
            return View("~/Views/Products/Optical-Scanners/MELO31Modules.cshtml");
        }
        public ActionResult MFS500Modules()
        {
            return View("~/Views/Products/Optical-Scanners/MFS500Modules.cshtml");
        }
        public ActionResult MARC10()
        {
            return View("~/Views/Products/Capacitive-Scanners/MARC10.cshtml");
        }
        public ActionResult MARC11()
        {
            return View("~/Views/Products/Capacitive-Scanners/MARC11.cshtml");
        }
        public ActionResult MARC10Modules()
        {
            return View("~/Views/Products/Capacitive-Scanners/MARC10Modules.cshtml");
        }
        public ActionResult MARC11Modules()
        {
            return View("~/Views/Products/Capacitive-Scanners/MARC11Modules.cshtml");
        }
        public ActionResult MIS100()
        {
            return View("~/Views/Products/IRIS-Scanners/MIS100.cshtml");
        }
        public ActionResult MIS100Modules()
        {
            return View("~/Views/Products/IRIS-Scanners/MIS100Modules.cshtml");
        }
        public ActionResult MBAS50()
        {
            return View("~/Views/Products/Biometric-Terminals/MBAS50.cshtml");
        }
        public ActionResult MBAS30()
        {
            return View("~/Views/Products/Biometric-Terminals/MBAS30.cshtml");
        }
        public ActionResult MBAS40()
        {
            return View("~/Views/Products/Biometric-Terminals/MBAS40.cshtml");
        }
        public ActionResult MT100()
        {
            return View("~/Views/Products/Biometric-Terminals/MT100.cshtml");
        }

    }
}