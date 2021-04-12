using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTutorial1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Release Day")]
        public DateTime Date { get; set; }

        public string Batch { get; set; }
    }
}
