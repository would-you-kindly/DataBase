using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBase
{
    class Identification
    {
        static public bool Registration(string login, string password, string passwodConfirmation)
        {
            if (login == string.Empty)
            {
                Control.Exclamation("Поле с логином пользователя не заполнено.", "Логин пользователя");
                return false;
            }
            if (password == string.Empty)
            {
                Control.Exclamation("Поле с паролем пользователя не заполнено.", "Пароль пользователя");
                return false;
            }
            if (passwodConfirmation == string.Empty)
            {
                Control.Exclamation("Поле с подтверждением паролем пользователя не заполнено.", "Подтверждение пароля пользователя");
                return false;
            }
            if (password != passwodConfirmation)
            {
                Control.Exclamation("Пароль пользователя не подтвержден. Проверьте правильность подтверждения пароля.",
                    "Пароль не подтвержден");
                return false;
            }
            if (Control.container.Users.ToList().Exists(x => x.Name == login))
            {
                Control.Exclamation("Пользователь с таким логином уже существует. Придумайте новый логин пользователя.",
                    "Логин не найден");
                return false;
            }
            User user = new User();
            user.Name = login;
            user.Password = password;
            Control.container.Users.Add(user);
            Control.container.SaveChanges();
            Control.Information("Регистрация прошла успешно.", "Регистрация");
            return true;
        }

        static public bool Entry(string login, string password)
        {
            if (login == string.Empty)
            {
                Control.Exclamation("Поле с логином пользователя не заполнено.", "Логин пользователя");
                return false;
            }
            if (password == string.Empty)
            {
                Control.Exclamation("Поле с паролем пользователя не заполнено.", "Пароль пользователя");
                return false;
            }
            if (!Control.container.Users.ToList().Exists(x => x.Name == login))
            {
                Control.Exclamation("Пользователя с таким логином не существует. Проверьте правильность логина пользователя.",
                    "Логин не найден");
                return false;
            }
            if (Control.container.Users.ToList().Exists(x => x.Id 
                == Control.container.Users.Where(y => y.Name == login).First().Id &&
                Control.container.Users.Where(z => z.Name == login).First().Password != password))
            {
                Control.Exclamation("Неверный пароль пользователя. Проверьте правильность пароля пользователя.",
                    "Неверный пароль");
                return false;
            }
            Control.currentUser = Control.container.Users.Find(Control.container.Users.Where(x => x.Name == login).First().Id);
            return true;
        }
    }
}
