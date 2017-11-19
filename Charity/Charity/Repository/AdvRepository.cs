using Charity.Models;
using Charity.Models.PostModels;
using Charity.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Charity.Repository
{
    public class AdvRepository
    {
        public List<AdvViewModel> GetAll()
        {
            var advContext = new AdvContext();
            var ItemsRep = new ItemsRepository();
            var advList = advContext.Advertisememnts.ToList();
            var ViewModels = advList.Select(x => new AdvViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Items = ItemsRep.GetItemsByAdvId(x.Id),
                Date = x.Date


             }).ToList();

            return ViewModels;

        }

        public AdvViewModel GetAdvById(int id)
        {
            var advContext = new AdvContext();
            var itemsRep = new ItemsRepository();
            var adv = advContext.Advertisememnts.Where(x => x.Id == id).FirstOrDefault();
            var ViewModel = new AdvViewModel
            {
                Items = itemsRep.GetItemsByAdvId(adv.Id),
                Description = adv.Description,
                Date = adv.Date,
                Id = adv.Id,
                Name = adv.Name
            };
            return ViewModel;
           
        }

        public int AddNewAdv(AdvPostModel model)
        {
            var advContext = new AdvContext();
            var itemsRep = new ItemsRepository();

            var id = advContext.Advertisememnts.Count() + 1;

            model.items.ForEach(x =>
            {
                itemsRep.AddNewItem(new ItemPostModel { AdvId = id, Description = x.Description, Images = x.Images, Name = x.Name });
            });

            advContext.Advertisememnts.Add(new DbAdv
            {
                Id = id,
                Name = model.Name,
                Description = model.Description,
                Date = DateTime.Now,
                CategoryId = 0,
                AuthorId = 0
            });

            advContext.SaveChanges();
            return id;
        }

        public List<AdvViewModel> SearchByString(string searchString)
        {
            var advContext = new AdvContext();
            var result = advContext.Advertisememnts.Where(x => x.Name.Contains(searchString)).ToList();
            var ViewModels = result.Select(x => GetAdvById(x.Id)).ToList();

            return ViewModels;
        }

        public void RemoveById(int id)
        {
            var advContext = new AdvContext();

            var adv = advContext.Advertisememnts.Where(x => x.Id == id).FirstOrDefault();
            advContext.Advertisememnts.Remove(adv);
            advContext.SaveChanges();

        }
    }
}