using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain.Model
{
    public class UsuarioModel
    {
        UsuarioDAO userDao = new UsuarioDAO();
        public async Task<bool>LoginUser(string user, string pass)
        {
            return await userDao.Login(user, pass);
        }
    }
}
