using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Entities
{
    public class Meta : EntityBase
    {
        [Required]
        [Display(Name = "SEO метатег Title")]
        public override string MetaTitle { get; set; } = "My Page";
        [Display(Name = "SEO метатег Description")]
        public override string MetaDescription { get; set; } = "This is my lending page.";
        [Display(Name = "SEO метатег Keywords")]
        public override string MetaKeywords { get; set; } = "key";
    }
}
