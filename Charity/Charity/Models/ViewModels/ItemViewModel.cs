using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Charity.Models.ViewModels
{
    public class ItemViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<string> Images { get; set; }
    }
}