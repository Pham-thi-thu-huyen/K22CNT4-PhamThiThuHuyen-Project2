using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace K22CNT4_Project2_PhamThiThuHuyen.Models
{
    public class cartItem
    {
        public int ItemId { get; set; }      
        public string ItemName { get; set; } 
        public decimal Price { get; set; }   
        public int Quantity { get; set; }     
    }
}