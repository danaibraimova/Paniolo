namespace Paniolo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Paniolo.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Paniolo.Models.ProductDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Paniolo.Models.ProductDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Products.AddOrUpdate(i => i.Title,
        new Product
        {
            Title = "Burger Special",
            Price= "$1",
            Description = "Double patty, lettuce, tomato, pickles, sliced onions, bacon, pepper cream cheese, wacko sauce, fries",
            Category="Burgers"

        },

           new Product
           {
               Title = "Veggie Burger",
               Price = "99&cent;",
               Description = "Lettuce, tomato, sauteed onions, grilled mushrooms, fried chili, sour cream, tomato chutney, fries",
               Category = "Burgers"

           },

          new Product
          {
              Title = "Cheesy Bacon Burger",
              Price = "$2",
              Description = "Lettuce, tomato, pickles, sliced onions, bacon, cheddar, fries",
              Category = "Burgers"

          },

       new Product
       {
           Title = "Speedy Gonzales Burger",
           Price = "$2",
           Description = "Speedy Gonzales Burger",
           Category = "Burgers"
       },

       new Product
       {
           Title = "Hotdog Special",
           Price = "99&cent;",
           Description = "Traditional hotdog with some authentic Hawaiian ingridients",
           Category = "Hotdogs"
       },

       new Product
       {
           Title = "Bacon Cheesedog",
           Price = "99&cent;",
           Description = "",
           Category = "Hotdogs"
       },
       new Product
       {
           Title = "King Size Hotdog",
           Price = "$1",
           Description = "Only for kings",
           Category = "Hotdogs"
       },
        new Product
        {
            Title = "Kiddies Hotdog",
            Price = "75&cent;",
            Description = "Only for kids",
            Category = "Hotdogs"
        },


        new Product
        {
            Title= "Chocolate Vanilla",
            Price= "95&cent;",
            Description="",
            Category="Shakes"
        },
          new Product
          {
              Title = "Strawberry Smoothie",
              Price = "80&cent;",
              Description = "",
              Category = "Shakes"
          },
          new Product
          {
              Title = "Mango Banana Medley",
              Price = "99&cent;",
              Description = "",
              Category = "Shakes"
          },
          new Product
          {
              Title = "Dark Chocolate Supreme",
              Price = "$1",
              Description = "",
              Category = "Shakes"
          },

          new Product
          {
              Title= "Strawberry Waffle",
              Price="$2",
              Description="",
              Category="Breakfast"
          },

           new Product
           {
               Title = "Bacon and Eggs",
               Price = "$3",
               Description = "",
               Category = "Breakfast"
           },

             new Product
             {
                 Title = "French Toast With Eggs",
                 Price = "$1",
                 Description = "",
                 Category = "Breakfast"
             },

             new Product
             {
                 Title = "Bacon and Pancakes",
                 Price = "$2",
                 Description = "",
                 Category = "Breakfast"
             }   
             
             );
        }
    }
}
