using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Entities
{
    public class Skills : EntityBase
    {
        [Required]
        [Display(Name = "Содержание раздела навыки")]
        public override string ContentSkills { get; set; }
    }
}
