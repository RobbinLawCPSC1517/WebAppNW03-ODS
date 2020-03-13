using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NWSystem.DAL;
using NWSystem.ENTITIES;
using System.ComponentModel; //needed to expose class and methods to ODS wizard

namespace NWSystem.BLL
{
    //expose the class to the ObjectDataSource wizard
    [DataObject]
    public class CategoryController
    {
        //expose a method to ODS
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Category> Categories_List()
        {
            using (var context = new NWContext())
            {
                return context.Categories.ToList();
            }
        }
    }
}
