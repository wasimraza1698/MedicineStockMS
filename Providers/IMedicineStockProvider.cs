using MedicineStockModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStockModule.Providers
{
   public interface IMedicineStockProvider
    {
        public IEnumerable<MedicineStockDTO> GetMedicineStock();
    }
}
