using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    /*Created Review model*/
    public class Review
    {
        /*Create properties for review*/
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Review")]
        public string Content { get; set; }
        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryID {get; set;}
        public virtual Category Category { get; set; }

    }
}