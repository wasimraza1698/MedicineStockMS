using MedicineStockModule.Providers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using log4net;
using log4net.Config;


[assembly: log4net.Config.XmlConfigurator(ConfigFile = "Log4net.config", Watch = true)]
namespace MedicineStockModule.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicineStockInformationController : Controller
    {
        
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //creating provider layer interface object
        private readonly IMedicineStockProvider iMedicineStock;
        public MedicineStockInformationController(IMedicineStockProvider iMedicineStock)
        {
            this.iMedicineStock = iMedicineStock;
        }

        //hhtp get method to get all the medicine stock list 
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var res =iMedicineStock.GetMedicineStock();
                BasicConfigurator.Configure();
                if (res != null)
                { 
                    log.Info("Medicine Stock Retrived");
                    return Ok(res.ToList());
                }
                log.Info("No details retrieved");
                return Content("No such details found please try again.");
            }
            catch(Exception e)
            {
                log.Error("Excpetion:" + e.Message + " has occurred while trying to retrieve stock info.");
                return Content("The following exception has occurred while retreving the stock." + e.Message + " Please try again");
            }
        }
    }
}
