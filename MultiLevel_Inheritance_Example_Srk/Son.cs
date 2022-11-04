using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel_Inheritance_Example_Srk
{
    public class Son: Father
    {     
        public string? sonName { get; set; }
        public double amountOfSon { get; set; }
        public double fatherAmount { get; set; }      

        public double CalculateSonAmount()
        {
            fatherAmount= CalculateFatherAmount();             
            amountOfSon = fatherAmount / 2;
            return amountOfSon;
        }
    }
}
