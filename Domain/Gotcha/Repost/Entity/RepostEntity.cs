using Domain.Base.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Gotcha.Repost.Entity
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
