using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace YosephExampleRepractice
{
    public class Account
    {

         float intitialAmount;
        public Account()
        {
            intitialAmount = 150;
        }
            
          
            
        
       public float IntialAmout
        {
            set
            {
                if (value < 1000) Console.WriteLine("IntitialAmount can't be < 1000");

                else intitialAmount = value;
            }
            get
            { //intitialAmount= 

                return intitialAmount;
            }

        }
                
                
    }

        
          //float amt;

          //amt =float.Parse(Console.ReadLine());
          //intitialAmount= amt;
          //return intitialAmount;  

        





    
}
