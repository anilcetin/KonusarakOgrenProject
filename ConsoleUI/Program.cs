﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetUserDetails().Data)
            {
                Console.WriteLine(user.user_email+" | "+user.cliem_title);
            }
        }
    }
}
