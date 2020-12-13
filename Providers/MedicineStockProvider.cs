using MedicineStockModule.Models;
using MedicineStockModule.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStockModule.Providers
{
    public class MedicineStockProvider : IMedicineStockProvider
    {
        private readonly IMedicineStockRepository _medicineStock;
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MedicineStockProvider(IMedicineStockRepository medicineStock)
        {
            _medicineStock = medicineStock;
        }
        public IEnumerable<MedicineStockDTO> GetMedicineStock()
        {
            log.Info("Medicine Stock requested");
            var medicineStockList = _medicineStock.GetAll();
            log.Info("Medicine Stock Retrieved");
            return medicineStockList.ToList();
           
        }
    }
}
