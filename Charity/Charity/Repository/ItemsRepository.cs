using Charity.Models;
using Charity.Models.PostModels;
using Charity.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Charity.Repository
{
    public class ItemsRepository
    {
      
        public List<ItemViewModel> GetItemsByAdvId(int id)
        {
            var itemsContext = new ItemsContext();
            var imagesRep = new ImagesRepository();
            var items = itemsContext.Items.Where(x => x.AdvId == id).ToList();
            var viewModels = items.Select(x => new ItemViewModel
            {
                Id = x.Id,
                Images = imagesRep.GetImagePathByItemId(x.Id),
                Description = x.Description,
                Name = x.Name
            }).ToList();

            return viewModels;
        }
         
        public void AddNewItem (ItemPostModel model)
        {
            var itemsContext = new ItemsContext();
            var imagesRep = new ImagesRepository();

            var id = itemsContext.Items.Count() + 1;

            model.Images.ForEach(x =>
            {
                imagesRep.AddNewImage(new ImgPostModel { ItemId = id, Path = x.Path });
            });

            itemsContext.Items.Add(new DbItem
            {
                AdvId = model.AdvId,
                Description = model.Description,
                Name = model.Name,
                Id = id
            });
        }
    }
}