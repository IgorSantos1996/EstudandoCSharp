using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace ExercicioPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }


        public UsedProduct(string name, double price, DateTime manufacturedate) : base(name, price)
        {
            ManufactureDate = manufacturedate;
        }

        public override string priceTag()
        {
            return Name + "(used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + "(Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
        
    }
}
