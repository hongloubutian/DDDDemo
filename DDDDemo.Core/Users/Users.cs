using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using DDDDemo.Menu;
using DDDDemo.Role;

namespace DDDDemo.Users
{
    public class Users : Entity
    {
        public Users()
        {
            CreateDate=DateTime.Now;
            LastLoginDate=DateTime.Now;
            UserRole=new List<UserRole>();
        }
        public string UserName { get; set; }

        public string UserPwd { get; set; }
        public int Sex { get; set; }

        public string Email { get; set; }

        public string IsEmailConfirmed { get; set; }

        public DateTime LastLoginDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<UserRole> UserRole { get; set; }

    }
}
