﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StraxServiceDetails.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        public string Image { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [Column(TypeName ="ntext")]
        public string Context { get; set; }

        public DateTime CreateDate { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        public List<ServiceCategory> serviceCategories { get; set; }
    }
}
