﻿using eUseControl.Domain.Entities.User;
using eUseControl.Domain.Entities.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic.Core
{
    public class UserApi
    {
        public RequestResponceAction UserLoginAction(ULoginData data)
        {
            UDbTable user;

            using (var db = new UserContext())
            {
                user = new UDbTable
                {
                    Username = "Vladimir",
                    Password = "wasd234566",
                    LastLogin = DateTime.Now,
                    Level = Domain.Entities.Enums.URole.ADMINISTRATOR,
                    Email = "stentychanell@gmail.com"
                };
                db.Users.Add(user); db.SaveChanges();   
            }

            using (var db = new UserContext())
            {
                 user = db.Users.FirstOrDefault(u => u.Username == data.Credential);
                 
            }
            using (var db = new UserContext())
            {
                user = (from u in db.Users where u.Username == data.Credential select u).FirstOrDefault();
            }
            if(user != null)
            {
                
            }
                return new RequestResponceAction();
        }
    }
}
