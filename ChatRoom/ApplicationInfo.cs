using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    internal class ApplicationInfo
    {
        private MyDbContext dbContext = new MyDbContext();

        public ApplicationInfo()
        {
            bool flag = dbContext.Database.EnsureCreated();
            dbContext.UserInfos.Load();// загружаем данные в UserInfos
            if (flag) // класс который отвечает за взаимодействие с базами данных. Метод создает базу данных если ее еще нет
            {
                dbContext.UserInfos.Add(new UserInfo { Login = "ahad06@list.ru", Name = "Ahad1", Lastname = "Suleymanov1", Password = "123" });
                dbContext.UserInfos.Add(new UserInfo { Login = "ahad@list.ru", Name = "Ahad2", Lastname = "Suleymanov2", Password = "123" });
                dbContext.SaveChanges();
            }
        }

        public bool IsUserForLogin(string input)//Метод проверящий есть ли такой пользователь по логину в фале
        {
            foreach (UserInfo item in dbContext.UserInfos.Local)// перечсиление из файла UserInfo о пользователях
            {
                if (item.Login == input)// Если item.Login это в содержимом файла имеетя такой пользователь который ввел в input
                {
                    return true;
                }
            }
            return false;
        }

        internal void CreateNewUser(string text, object password)
        {
            throw new NotImplementedException();
        }

        public bool IsUserForPassword(string input, string inputPas)
        {
            foreach (UserInfo item in dbContext.UserInfos)
            {
                if (item.Login == input && item.Password == inputPas)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetUserId(string input)
        {
            foreach (UserInfo item in dbContext.UserInfos)
            {
                if (item.Login == input)
                {
                    return item.Id;
                }
            }
            return 0;
        }

        public void CreateNewUser(string login, string name, string lastname, string password)
        {
            /*int idUser = 0;
            foreach (UserInfo item in users)
            {
                idUser++;
            }*/
            dbContext.UserInfos.Add(new UserInfo { Login = login, Name = name, Lastname = lastname, Password = password });
            dbContext.SaveChanges();
        }
    
    }
}
