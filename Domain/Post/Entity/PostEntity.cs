using Domain.Base.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Post.Entity
{
    [Table("Post")]
    public class PostEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Description {  get; set; }
        public int RepostQnt {  get; set; }
        public DateTime PostDate { get; set; }
        public PostEnum PostType { get; set; }
    }
}
