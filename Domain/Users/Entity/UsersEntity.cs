﻿using Domain.Base.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users.Entity
{
    [Table("Users")]
    public class UsersEntity : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public DateTime CreationDate { get; set; }
        public string Email { get; set; }
        public int PostsDay {  get; set; }
        public bool Active {  get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? LastAccessDate { get; set; }
        public string ImgBase64 { get; set; }


        public void UpdateLastAccess()
        {
            this.LastAccessDate = DateTime.UtcNow.AddHours(-3);
        }

        public void IncrementPostsDay()
        {
            this.PostsDay += 1;
        }

        public void ResetPostsDay()
        {
            this.PostsDay = 0;
        }
    }
}
