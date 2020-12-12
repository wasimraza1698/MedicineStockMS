using MedicineStockModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStockModule.Repository
{
   public interface IMedicineStockRepository
    { 
        public IEnumerable<MedicineStockDTO> GetAll();
    }
}
