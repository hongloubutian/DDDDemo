using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Castle.MicroKernel.ModelBuilder.Descriptors;
using DDDDemo.DTO;
using DDDDemo.Entities.Menu;
using DDDDemo.Repositories;

namespace DDDDemo.Service
{
   public  class MenuService
   {
       #region Interface
       private readonly IRepository<Menus,Guid> _menuRepository;
       private readonly ICacheMenuRepository _cacheMenuRepository;
       #endregion

       #region Ctor

       public MenuService(IRepository<Menus,Guid> menuRepository,ICacheMenuRepository cacheMenuRepository)
       {
           _menuRepository = menuRepository;
           _cacheMenuRepository = cacheMenuRepository;
       }
       #endregion

       public List<Menus> MenuList()
       {
           var list = _menuRepository.GetAll().ToList();
           return list;
       }

       public Menus AddMenu(MenuModel model)
       {
           var menus = new Menus() {Id = model.ID,Level = model.Level,MenuCode = model.MenuCode,MenuName = model.MenuName,MenuUrl = model.MenuUrl,Order = model.Order,PID = model.PID};
           return  _menuRepository.Insert(menus);
       }

       public Menus Update(MenuModel model)
       {
           var oldModel = _menuRepository.Get(model.ID);
           oldModel.Level = model.Level;
           oldModel.MenuCode = model.MenuCode;
           oldModel.MenuName = model.MenuName;
           oldModel.MenuUrl = model.MenuUrl;
           oldModel.Order = model.Order;
           oldModel.PID = model.PID;

          return  _menuRepository.Update(oldModel);
       }

       public void Delete(Guid id)
       {
           _menuRepository.Delete(x=>x.Id==id);
       }

   }
}
