using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace DDDDemo.Menu
{
   public  class Menus:Entity
    {
       public Menus()
       {
           RoleMenu=new List<RoleMenu>();
       }
       public string MenuCode { get; set; }
       public string MenuName { get; set; }
       public string MenuUrl { get; set; }

       public string PID { get; set; }

       public int Level { get; set; }
       public int Order { get; set; }

       public ICollection<RoleMenu> RoleMenu { get; set; } 
    }
}
