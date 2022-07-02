using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pawnshop.Model
{
    internal class Class1
    {
        private static PawnshopEntities ConObj;
        public static PawnshopEntities GetContext()
        {
            if (ConObj == null)
            {
                ConObj = new PawnshopEntities();
            }
            return ConObj;
        }


    }
}
