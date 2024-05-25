using Domain.BaseMongo.Entity;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Feed.Entity
{
    public class FeedEntity : BaseMongoEntity
    {
        public List<FeedGotcha> Feed {  get; set; }
    }

    public class FeedGotcha
    {
        [BsonId]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public Guid GotchaId { get; set; }
        public DateTime CrationDate { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserNickname { get; set; }
        public string Content { get; set; }
        public bool IsRepost { get; set; }
        public FeedRepostedGotcha? RepostedGotcha { get; set; }
    }

    public class FeedRepostedGotcha
    {
        [BsonId]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public Guid GotchaId { get; set; }
        public DateTime CrationDate { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserNickname { get; set; }
        public string Content { get; set; }
    }
}
