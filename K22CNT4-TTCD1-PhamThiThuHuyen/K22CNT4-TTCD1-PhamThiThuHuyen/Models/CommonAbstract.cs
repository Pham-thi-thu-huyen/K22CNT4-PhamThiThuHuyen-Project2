using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace K22CNT4_TTCD1_PhamThiThuHuyen.Models
{
   
    public class CommonAbstract
    {
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate  { get; set; }
        public string ModifiedBy { get; set; }
    }
}