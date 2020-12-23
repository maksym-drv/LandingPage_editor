using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;
        public Guid Id { get; set; }
        [Display(Name = "Название (заголовок)")]
        public virtual string Title { get; set; }
        [Display(Name = "Название раздела (подзаголовок)")]
        public virtual string Subtitle { get; set; }
        [Display(Name = "Описание раздела")]
        public virtual string Text { get; set; }
        [Display(Name = "Содержание раздела навыки")]
        public virtual string ContentSkills { get; set; }
        [Display(Name = "Содержание раздела опыт")]
        public virtual string ContentExperience { get; set; }
        [Display(Name = "Содержание раздела образование")]
        public virtual string ContentEducation { get; set; }
        [Display(Name = "Картинка образовательного заведения")]
        public virtual string ImagePath { get; set; }
        [Display(Name = "SEO метатег Title")]
        public virtual string MetaTitle { get; set; }
        [Display(Name = "SEO метатег Description")]
        public virtual string MetaDescription { get; set; }
        [Display(Name = "SEO метатег Keywords")]
        public virtual string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
