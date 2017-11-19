using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Charity.Models.PostModels
{
    public class AdvPostModel { 
       public string Name { get; set; }

       public string Description { get; set; }

       public List<ItemPostModel> items { get; set; }
    }
}