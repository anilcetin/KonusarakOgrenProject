using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, KonusaraOgrenContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetails()
        {
            using (KonusaraOgrenContext context = new KonusaraOgrenContext())
            {
                var result = from u in context.Users
                             join c in context.Cliems
                             on u.cliemuser equals c.cliem_id
                             select new UserDetailDto
                             {
                                 user_id = u.user_id,
                                 user_email = u.user_email,
                                 cliem_title = c.cliem_title
                             };
                return result.ToList();
            }
        }
    }
}
