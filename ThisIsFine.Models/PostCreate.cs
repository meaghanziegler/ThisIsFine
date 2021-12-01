﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsFine.Models
{
    public class PostCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many chracters in this field.")]
        public string Title { get; set; }

        [MaxLength(8000)]
        public string Text { get; set; }

    }
}
