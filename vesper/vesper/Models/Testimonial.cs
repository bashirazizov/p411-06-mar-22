using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vesper.Models
{
    public class Testimonial : BaseEntity
    {
        [Display(Name = "Yazan Adam")]
        [Required, MaxLength(100)]
        public string AuthorName { get; set; }
        [Required, MaxLength(1000)]
        public string AuthorImage { get; set; }
        [Required, MaxLength(100)]
        public string AuthorOccupation { get; set; }
        [Required]
        public string Text { get; set; }

        public Testimonial(string AuthorName, string AuthorImage, string AuthorOccupation, string Text)
        {
            this.AuthorName = AuthorName;
            this.AuthorImage = AuthorImage;
            this.AuthorOccupation = AuthorOccupation;
            this.Text = Text;
        }

        public Testimonial()
        {

        }
    }
}
