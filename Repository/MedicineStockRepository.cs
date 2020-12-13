using MedicineStockModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStockModule.Repository
{
    public class MedicineStockRepository:IMedicineStockRepository
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static readonly List<MedicineStockDTO> MedicineStockInformation = new List<MedicineStockDTO>() {
            new MedicineStockDTO{Name="Medicine1",
                              ChemicalComposition=new List<string>{"chemical1","chemical2"},
                              TargetAilment="Orthopedics",
                              DateOfExpiry=DateTime.Parse("10-10-2021"),
                              NumberOfTabletsInStock=50},
            new MedicineStockDTO{Name="Medicine2",
                              ChemicalComposition=new List<string>{"chemical3","chemical2"},
                              TargetAilment="General",
                              DateOfExpiry=DateTime.Parse("10-09-2021"),
                              NumberOfTabletsInStock=50},
            new MedicineStockDTO{Name="Medicine3",
                              ChemicalComposition=new List<string>{"chemical1","chemical2"},
                              TargetAilment="Gynecology",
                              DateOfExpiry=DateTime.Parse("10-10-2021"),
                              NumberOfTabletsInStock=50},
            new MedicineStockDTO{Name="Medicine4",
                              ChemicalComposition=new List<string>{"chemical1","chemical2"},
                              TargetAilment="Orthopedics",
                              DateOfExpiry=DateTime.Parse("10-01-2021"),
                              NumberOfTabletsInStock=50},
            new MedicineStockDTO{Name="Medicine5",
                              ChemicalComposition=new List<string>{"chemical6","chemical5"},
                              TargetAilment="Gynecology",
                              DateOfExpiry=DateTime.Parse("10-10-2021"),
                              NumberOfTabletsInStock=50},

        };

        public IEnumerable<MedicineStockDTO> GetAll()
        {
            
            var MedicineStocklist = from Medicine in MedicineStockInformation select Medicine;
            log.Info("Medicine Stock retrieved from go-down");
            return MedicineStocklist.ToList();
        }
    }
}
