using Charity.Models;
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
         


    }
}