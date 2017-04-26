﻿namespace BugsTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Web;

    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }
        
        public int BugId { get; set; }

        //[ForeignKey("BugId")]
        public virtual Bug Bug { get; set; }

        public DateTime DateAdded { get; set; }

        [ForeignKey("Author")]
        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }
    }
}