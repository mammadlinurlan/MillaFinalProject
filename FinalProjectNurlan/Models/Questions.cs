﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Models
{
    public class Questions
    {
        public int Id { get; set; }

        public bool IsAcces { get; set; }

        [Required]
        [StringLength(maximumLength:50)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Phone { get; set; }

        [Required]
        //[StringLength(maximumLength: 50)]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Subject { get; set; }

        [Required]
        [StringLength(maximumLength: 350)]
        public string Message { get; set; }
    }
}
