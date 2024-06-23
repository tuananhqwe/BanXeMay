using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BanXeMay.Models
{
    public class CategoryModel
    {
        [Key]
        public int id { get; set; }
        [Required, MinLength(4,ErrorMessage ="Yeu cau nhap ten Danh Muc") ]

        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yeu cau nhap ten Danh Muc")]
        public string Slug { get; set; }
        
        public int Status { get; set; }
    }
}
