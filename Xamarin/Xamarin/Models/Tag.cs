using System;
using System.Collections.Generic;

namespace Xamarin.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime MadeAt { get; set; }
        public double Discount { get; set; }
        public virtual List<Tag> Tags { get; set; }
    }
}