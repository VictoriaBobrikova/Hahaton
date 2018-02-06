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
            db.Advertisememnts.Add(new DbAdv { Id = 0, Name = "Мебель", Date = DateTime.Now, Description = "Со стулом норм сидеть", CategoryId = 0, AuthorId = 0});
            db.Advertisememnts.Add(new DbAdv { Id = 1, Name = "Книги", Date = DateTime.Now, Description = "Со стулом норм сидеть", CategoryId = 0, AuthorId = 0 });
            db.Advertisememnts.Add(new DbAdv { Id = 3, Name = "Техника", Date = DateTime.Now, Description = "Самовывоз м.Петроградская", CategoryId = 0, AuthorId = 0 });
            db.Advertisememnts.Add(new DbAdv { Id = 4, Name = "Посуда", Date = DateTime.Now, Description = "В твоем воображении", CategoryId = 0, AuthorId = 0 });
            db.Advertisememnts.Add(new DbAdv { Id = 5, Name = "Одежда", Date = DateTime.Now, Description = "не могу собрать", CategoryId = 0, AuthorId = 0 });
            db.Advertisememnts.Add(new DbAdv { Id = 6, Name = "Химия", Date = DateTime.Now, Description = "Никогда не подведёт", CategoryId = 0, AuthorId = 0 });
            db.Advertisememnts.Add(new DbAdv { Id = 7, Name = "Запчасти", Date = DateTime.Now, Description = "Отдам за ненадобностью", CategoryId = 0, AuthorId = 0 });
            db.Advertisememnts.Add(new DbAdv { Id = 8, Name = "Игрушки", Date = DateTime.Now, Description = "С ним всегда хорошо", CategoryId = 0, AuthorId = 0 });

            base.Seed(db);
        }
    }

    public class DbItemsInitializer : DropCreateDatabaseAlways<ItemsContext>
    {
        protected override void Seed(ItemsContext db)
        {
            db.Items.Add(new DbItem { Id = 1, AdvId = 1, Description = "Со стулом норм сидеть", Name = "Стул1" });
            db.Items.Add(new DbItem { Id = 2, AdvId = 2, Description = "Со стулом норм сидеть", Name = "Стул2" });
            db.Items.Add(new DbItem { Id = 3, AdvId = 3, Description = "Со стулом норм сидеть", Name = "Стул3" });
            db.Items.Add(new DbItem { Id = 4, AdvId = 4, Description = "Со стулом норм сидеть", Name = "Стул4" });
            db.Items.Add(new DbItem { Id = 5, AdvId = 5, Description = "Со стулом норм сидеть", Name = "Стул5" });
            db.Items.Add(new DbItem { Id = 6, AdvId = 6, Description = "Со стулом норм сидеть", Name = "Стул6" });
            db.Items.Add(new DbItem { Id = 7, AdvId = 7, Description = "Со стулом норм сидеть", Name = "Стул324" });
            db.Items.Add(new DbItem { Id = 8, AdvId = 1, Description = "Со стулом норм сидеть", Name = "Стулwer" });
            db.Items.Add(new DbItem { Id = 9, AdvId = 1, Description = "Со стулом норм сидеть", Name = "Стулd" });
            db.Items.Add(new DbItem { Id = 10, AdvId = 2, Description = "Со стулом норм сидеть", Name = "Сту5л" });
            db.Items.Add(new DbItem { Id = 11, AdvId = 3, Description = "Со стулом норм сидеть", Name = "Стул5" });
            db.Items.Add(new DbItem { Id = 12, AdvId = 4, Description = "Со стулом норм сидеть", Name = "Стул4" });
            db.Items.Add(new DbItem { Id = 13, AdvId = 5, Description = "Со стулом норм сидеть", Name = "Стул3" });
            db.Items.Add(new DbItem { Id = 14, AdvId = 6, Description = "Со стулом норм сидеть", Name = "Стул4" });
            db.Items.Add(new DbItem { Id = 15, AdvId = 7, Description = "Со стулом норм сидеть", Name = "Стул6" });

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