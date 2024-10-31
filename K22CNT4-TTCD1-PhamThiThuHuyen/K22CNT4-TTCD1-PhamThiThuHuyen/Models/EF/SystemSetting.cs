using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace K22CNT4_TTCD1_PhamThiThuHuyen.Models
{
    [Table("tb_SystemSetting")]
    public class SystemSetting
    {
        [Key]
        [StringLength(50)]
        public string SettingKey { get; set; }
        [StringLength(4000)]
        public string SeetingValue { get; set; }
        [StringLength(4000)]
        public string SettingDescription { get; set; }
    }
}