﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace K22CNT4_TTCD1_PhamThiThuHuyen.Models
{
    [Table("tb_ProductImage")]
    public class ProductImage
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       public int ProductId { get; set; }
       public string Image { get; set; }
       public bool IsDefault { get; set; }
    }
}