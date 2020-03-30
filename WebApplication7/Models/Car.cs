using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Car
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Car name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Max speed is required")]
        public int MaxSpeed { get; set; }
    }
}
