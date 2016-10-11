using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
    /*Created Category model*/
{
    public class Category
    {
        public int ID { get; set; }
        [Display(Name = "Category")]
        public string Name { get; set; }
        public virtual ICollection <Review> Review { get; set; }
    }
}