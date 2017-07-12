namespace _02.BookShop.Models
{
    using System;
    using System.Text;

    public class Book
    {
        // 1. Add Fields
        private string _author;

        private string _title;

        private decimal _price;

        // 2. Add Constructors
        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        // 3. Add Properties
        private string Author
        {
            get => this._author;
            set
            {
                var splitedNames = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (splitedNames.Length > 1)
                {
                    var secondName = splitedNames[1];
                    if (char.IsDigit(secondName[0]))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }
                this._author = value;
            }
        }

        private string Title
        {
            get => this._title;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                this._title = value;
            }
        }

        protected virtual decimal Price
        {
            get => this._price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                this._price = value;
            }
        }

        // 4. Add Methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name).Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author).Append("Price: ").Append($"{this.Price:F1}").AppendLine();

            return sb.ToString();
        }
    }
}
