using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Charity.Models.PostModels
{
    public class ItemPostModel
    {
       public string Name { get; set; }
       public string Description { get; set; }
       public ImgPostModel Images { get; set; }
    }
}