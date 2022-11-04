using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel_Inheritance_Example_Srk
{
    public class Father: GrandFather
    {        
        public string? fatherName { get; set; }
        public double amountOfFather { get; set; }       
        public double CalculateFatherAmount()
        {
            amountOfFather = amountOfGrandFather /2;
            return amountOfFather;            
        }
       
    }
}
