using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BanXeMay.Models
{
    public class ProductModel
    {
        [Key]
        public int id { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yeu cau nhap ten Danh Muc")]

        public string Name { get; set; }

        public string Slug { get; set; }
        public string Description { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yeu cau nhap ten Danh Muc")]

        public int Price { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yeu cau nhap Gia")]

        public int BrandId { get; set; }

        public int CategoeyId { get; set; }

        public CategoryModel Category { get; set; }

        public BrandModel Brand { get; set; }

        public string Image { get; set; }



    }
}
