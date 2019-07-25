using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace News.Models
{
    public class News
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage ="News Title is required")]
        [Display(Name ="News Title")]
        public string Title { get; set; }

        [Required]
        public int PublisherId { get; set; }

        [DataType(DataType.Date)]
        public DateTime NewsDate { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

    }
}
