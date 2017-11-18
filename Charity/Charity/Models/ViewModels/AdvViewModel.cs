using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Charity.Models.ViewModels
{
    public class AdvViewModel
    {
        public int id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public List<ItemViewModel> Items { get; set; }
    }
}