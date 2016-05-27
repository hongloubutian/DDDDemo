using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDDemo.DTO
{
   public  class MenuModel
    {
       public Guid ID { get; set; }
        public string MenuCode { get; set; }
        public string MenuName { get; set; }
        public string MenuUrl { get; set; }

        public string PID { get; set; }

        public int Level { get; set; }
        public int Order { get; set; }
    }
}
