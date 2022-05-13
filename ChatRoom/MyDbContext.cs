using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    internal class MyDbContext : DbContext// Наследоваие чтобы воспользоваться этим калссом
    {
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)// Метод подключения
        {
            string v = $"Data Source={Path.Combine(@"C:\Users\ahads\Desktop\WPF", "User.db")}";
            optionsBuilder.UseSqlite();// Свойства куда подключать 
            base.OnConfiguring(optionsBuilder);
        }
    }
}
