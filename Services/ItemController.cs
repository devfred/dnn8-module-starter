using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using CreativeWizardry.Modules.ModuleStarter.Components;
using CreativeWizardry.Modules.ModuleStarter.Services.ViewModels;
using DotNetNuke.Common;
using DotNetNuke.Web.Api;
using DotNetNuke.Security;
using System.Collections.Generic;

namespace CreativeWizardry.Modules.ModuleStarter.Services
{
    [SupportedModules("ModuleStarter")]
    [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.View)]
    public class ItemController : DnnApiController
    {
        private readonly IItemRepository _repository;

        public ItemController(IItemRepository repository)
        {
            Requires.NotNull(repository);

            this._repository = repository;
        }

        public ItemController() : this(ItemRepository.Instance) { }

        [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Edit)]
        public HttpResponseMessage Delete(int itemId)
        {
            var item = _repository.GetItem(itemId, ActiveModule.ModuleID);

            _repository.DeleteItem(item);

            return Request.CreateResponse(System.Net.HttpStatusCode.NoContent);
        }

        public HttpResponseMessage Get(int itemId)
        {
            var item = new ItemViewModel(_repository.GetItem(itemId, ActiveModule.ModuleID));

            return Request.CreateResponse(item);
        }


        public HttpResponseMessage GetList()
        {
            List<ItemViewModel> items;

            items = _repository.GetItems(ActiveModule.ModuleID)
                       .Select(item => new ItemViewModel(item))
                       .ToList();

            return Request.CreateResponse(items);
        }

   
        [HttpPost]
        [ValidateAntiForgeryToken]
        [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Edit)]
        public HttpResponseMessage Upsert(ItemViewModel item)
        {
            if (item.Id > 0)
            {
                var t = Update(item);
                return Request.CreateResponse(item);
            }
            else
            {
                var t = Create(item);
                return Request.CreateResponse(t.ItemId);
            }

        }

        private Item Create(ItemViewModel item)
        {
            Item t = new Item
            {
                ItemName = item.Name,
                ItemDescription = item.Description,
                AssignedUserId = item.AssignedUser,
                ModuleId = ActiveModule.ModuleID,
                CreatedByUserId = UserInfo.UserID,
                LastModifiedByUserId = UserInfo.UserID,
                CreatedOnDate = DateTime.UtcNow,
                LastModifiedOnDate = DateTime.UtcNow
            };
            _repository.AddItem(t);

            return t;
        }

        private Item Update(ItemViewModel item)
        {

            var t = _repository.GetItem(item.Id, ActiveModule.ModuleID);
            if (t != null)
            {
                t.ItemName = item.Name;
                t.ItemDescription = item.Description;
                t.AssignedUserId = item.AssignedUser;
                t.LastModifiedByUserId = UserInfo.UserID;
                t.LastModifiedOnDate = DateTime.UtcNow;
            }
            _repository.UpdateItem(t);

            return t;
        }
    }
}
