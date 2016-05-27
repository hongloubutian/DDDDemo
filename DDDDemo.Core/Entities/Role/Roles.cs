using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using DDDDemo.Entities.Menu;

namespace DDDDemo.Entities.Role
{
   public class Roles:Entity<Guid>
    {
       public Roles()
       {
           RoleMenu=new List<RoleMenu>();
           UserRole=new List<UserRole>();
       }
       public string RoleName { get; set; }
       public ICollection<RoleMenu> RoleMenu { get; set; }
       public ICollection<UserRole> UserRole { get; set; } 
    }
}
