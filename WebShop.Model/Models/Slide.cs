﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
        public string Description { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public string URL { set; get; }

        public int? DisplayOrder { set; get; }

        public bool Status { set; get; }
    }
}