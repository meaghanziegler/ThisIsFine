﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsFine.Models
{
    public class ReplyCreate
    {
        [Required]
        public int ReplyId { get; set; }
        public string Text { get; set; }

    }
}
