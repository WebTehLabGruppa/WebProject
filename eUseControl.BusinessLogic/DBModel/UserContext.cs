using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using eUseControl.Domain.Entities.Enums;
using eUseControl.Domain.Entities;


namespace eUseControl.Domain.Entities.User
{

    class UserContext: DbContext
    {
        public UserContext(): 
        base("name = eUseControl")
        {

        }
        public virtual DbSet<UDbTable> Users { get;set; }
    }
}
    