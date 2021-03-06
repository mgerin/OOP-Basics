﻿namespace _02.BookShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price)
            : base(author, title, price)
        {
        }

        protected override decimal Price
        {
            get => base.Price;
            set => base.Price = value * 1.3m;
        }
    }
}
