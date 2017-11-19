using Charity.Models;
using Charity.Models.PostModels;
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
         
        public void AddNewImage(ImgPostModel model)
        {
            var imagesContext = new ImageContext();
            imagesContext.Images.Add(new DbImage
            {
                Id = imagesContext.Images.Count() + 1,
                ItemId = model.ItemId,
                Path = model.Path
            });
        }

    }
}