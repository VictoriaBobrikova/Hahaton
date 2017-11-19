using Charity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Charity.Repository
{
    public class DbInitializer : DropCreateDatabaseAlways<AdvContext>
    {
        protected override void Seed(AdvContext db)
        {
            db.Advertisememnts.Add(new DbAdv { Id = 0, Name = "Стул", Date = DateTime.Now, Description = "Со стулом норм сидеть", CategoryId = 0, AuthorId = 0});
            db.Advertisememnts.Add(new DbAdv { Id = 1, Name = "Zzz", Date = DateTime.Now, Description = "Со стулом норм сидеть", CategoryId = 0, AuthorId = 0 });
            db.Advertisememnts.Add(new DbAdv { Id = 2, Name = "Стул", Date = DateTime.Now, Description = "Со стулом норм сидеть", CategoryId = 0, AuthorId = 0 });

            base.Seed(db);
        }
    }

    public class DbItemsInitializer : DropCreateDatabaseAlways<ItemsContext>
    {
        protected override void Seed(ItemsContext db)
        {
            db.Items.Add(new DbItem { Id = 0, AdvId = 0, Description = "Со стулом норм сидеть", Name = "Стул" });
            db.Items.Add(new DbItem { Id = 1, AdvId = 1, Description = "Со стулом норм сидеть", Name = "Стул" });
            db.Items.Add(new DbItem { Id = 2, AdvId = 2, Description = "Со стулом норм сидеть", Name = "Стул" });

            base.Seed(db);
        }
    }

    public class DbImagesInitializer : DropCreateDatabaseAlways<ImageContext>
    {
        protected override void Seed(ImageContext db)
        {
            db.Images.Add(new DbImage {Id = 0, ItemId = 0, Path = "" });
            db.Images.Add(new DbImage { Id = 1, ItemId = 1, Path = "" });
            db.Images.Add(new DbImage { Id = 2, ItemId = 2, Path = "" });

            base.Seed(db);
        }
    }
}