using Charity.Models;
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
                id = x.Id,
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
                id = adv.Id,
                Name = adv.Name
            };
            return ViewModel;
           
        }



    }
}