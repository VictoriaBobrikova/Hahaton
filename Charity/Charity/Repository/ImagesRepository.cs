using Charity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Charity.Repository
{
    public class ImagesRepository
    {
      
        public List<string> GetImagePathByItemId(int id)
        {
            var imagesContext = new ImageContext();
            var images = imagesContext.Images.Where(x => x.ItemId == id).ToList();
            return images.Select(x => x.Path).ToList();
        }
         


    }
}