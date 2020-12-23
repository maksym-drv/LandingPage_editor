using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Entities
{
    public class Information : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }
        [Display(Name = "Название заголовка")]
        public override string Title { get; set; } = "Some Title";
        [Display(Name = "Содержание подзаголовка")]
        public override string Subtitle { get; set; } = "Some Subtitle";
        [Display(Name = "Содержание заголовка")]
        public override string Text { get; set; } = "Some Text";
    }
}
