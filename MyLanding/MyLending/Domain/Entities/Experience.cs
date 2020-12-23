using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Entities
{
    public class Experience : EntityBase
    {
        [Required]
        [Display(Name = "Содержание раздела опыт")]
        public override string ContentExperience { get; set; }
    }
}
