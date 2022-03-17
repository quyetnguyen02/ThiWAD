namespace ThiWAD.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ThiWAD.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ThiWAD.Data.MyDbConText>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ThiWAD.Data.MyDbConText context)
        {
            var categories = new List<Category>
            {
                new Category{ID=234, CategoryName = "Shirt", Description="none",Picture="https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Fb%2Fb6%2FImage_created_with_a_mobile_phone.png%2F640px-Image_created_with_a_mobile_phone.png&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FImage&tbnid=ItY9cBsepnqjwM&vet=12ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ..i&docid=0JWe7yDOKrVFAM&w=640&h=480&q=image&ved=2ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ"},
                new Category{ID=235, CategoryName = "Jeans", Description="nice",Picture="https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Fb%2Fb6%2FImage_created_with_a_mobile_phone.png%2F640px-Image_created_with_a_mobile_phone.png&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FImage&tbnid=ItY9cBsepnqjwM&vet=12ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ..i&docid=0JWe7yDOKrVFAM&w=640&h=480&q=image&ved=2ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ"},
                new Category{ID=236, CategoryName = "Shoes", Description="none",Picture="https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Fb%2Fb6%2FImage_created_with_a_mobile_phone.png%2F640px-Image_created_with_a_mobile_phone.png&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FImage&tbnid=ItY9cBsepnqjwM&vet=12ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ..i&docid=0JWe7yDOKrVFAM&w=640&h=480&q=image&ved=2ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ"},
                new Category{ID=237, CategoryName = "Shorts", Description="none",Picture="https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Fb%2Fb6%2FImage_created_with_a_mobile_phone.png%2F640px-Image_created_with_a_mobile_phone.png&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FImage&tbnid=ItY9cBsepnqjwM&vet=12ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ..i&docid=0JWe7yDOKrVFAM&w=640&h=480&q=image&ved=2ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ"},
                new Category{ID=238, CategoryName = "Shit", Description="none",Picture="https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Fb%2Fb6%2FImage_created_with_a_mobile_phone.png%2F640px-Image_created_with_a_mobile_phone.png&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FImage&tbnid=ItY9cBsepnqjwM&vet=12ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ..i&docid=0JWe7yDOKrVFAM&w=640&h=480&q=image&ved=2ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ"},
                new Category{ID=239, CategoryName = "Pepe", Description="none",Picture="https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Fb%2Fb6%2FImage_created_with_a_mobile_phone.png%2F640px-Image_created_with_a_mobile_phone.png&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FImage&tbnid=ItY9cBsepnqjwM&vet=12ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ..i&docid=0JWe7yDOKrVFAM&w=640&h=480&q=image&ved=2ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ"},
            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{category = new Category(){ ID=236}, ProductName = "ÁO SƠ MI DÀI TAY BÉ TRAI RABITY 9900",SupplierID = 231,QuantityPerUnit=5,UnitPrice =150000,UnitslnStock="Jeans",UnitOnOrder="Shorts",ReorderLevel="12",Discontinued="no" },
                new Product{ category = new Category(){ ID=236}, ProductName = "ÁO SƠ MI DÀ00",SupplierID = 231,QuantityPerUnit=5,UnitPrice =1505000,UnitslnStock="Condom",UnitOnOrder="Shorts",ReorderLevel="12",Discontinued="no" },
                new Product{ category = new Category(){ ID=236}, ProductName = "ÁO SƠ900",SupplierID = 231,QuantityPerUnit=54,UnitPrice =1520000,UnitslnStock="Shorts",UnitOnOrder="Shorts",ReorderLevel="12",Discontinued="no" },
                new Product{ category = new Category(){ ID=236}, ProductName = "ÁO SƠ MI DÀ00",SupplierID = 231,QuantityPerUnit=6,UnitPrice =1520000,UnitslnStock="Hat",UnitOnOrder="Shorts",ReorderLevel="12",Discontinued="no" },
                new Product{ category = new Category(){ ID=236}, ProductName = "TRAI RABITY 9900",SupplierID = 231,QuantityPerUnit=23,UnitPrice =1250000,UnitslnStock="Jeans",UnitOnOrder="Shorts",ReorderLevel="12",Discontinued="no" },
                new Product{ category = new Category(){ ID=236}, ProductName = "ÁO S RABITY 9900",SupplierID = 231,QuantityPerUnit=65,UnitPrice =1250000,UnitslnStock="Hat",UnitOnOrder="Shorts",ReorderLevel="12",Discontinued="no" },
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}
