using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using GenericRepository;

namespace TestApp.Entities
{
    [Table("test_Products")]
    public class Product : IEntity
    {
        [Column("ProductId")]  
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }

    }
}