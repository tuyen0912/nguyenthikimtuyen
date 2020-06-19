using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nguyenthikimtuyen.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }
        [Required]
        [StringLength(225)]
        public string Place { get; set; }
        public DateTime DataTime { get; set; }
        public Category Category  { get; set; }
        public byte CategoryId { get; set; }


    }
}