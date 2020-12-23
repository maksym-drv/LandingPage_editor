using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Entities
{
    public class Education : EntityBase
    {
        [Required]
        [Display(Name = "Содержание раздела образование")]
        public override string ContentEducation { get; set; }
        [Display(Name = "Картинка образовательного заведения")]
        public override string ImagePath { get; set; }
    }
}
