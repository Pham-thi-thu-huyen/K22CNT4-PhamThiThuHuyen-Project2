using System.Data.Entity;
using K22CNT4_Project2_PhamThiThuHuyen.Models;

namespace K22CNT4_Project2_PhamThiThuHuyen.Models
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        // DbSet cho các thực thể (model) của bạn
        public DbSet<Item> Items { get; set; }  // Item là tên của bảng trong cơ sở dữ liệu
    }
}
