using Changal.BLL.Dto;
using Changal.DAL.Context;
using Changal.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changal.BLL.Services
{
    public class FoodService
    {
        
        DatabaeContext database = new DatabaeContext();

        public List<FoodListDto> foodList()
        { 
            var FoodList = database.Foods.Select(p => new FoodListDto 
            {
                FoodName = p.Name,
                FoodPrice = p.Price,
                FoodDescription = p.Description
            }
            ).ToList();

            return FoodList;
        }
    }
}
