
using System;

namespace Charity.Models
{
    public class DbAdv
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public int AuthorId { get; set; }

        public int CategoryId { get; set; }
    }
}