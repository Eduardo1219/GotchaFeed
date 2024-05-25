using Domain.Base.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Post.Repost.Entity
{
    [Table("Repost")]
    public class RepostEntity : BaseEntity
    {
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public DateTime RepostDate { get; set; }
        public string RepostContent {  get; set; }
    }
}
