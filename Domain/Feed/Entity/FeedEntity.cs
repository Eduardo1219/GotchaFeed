using Domain.BaseMongo.Entity;
using Domain.Gotcha.Entity;
using Domain.Gotcha.Repost.Entity;
using Domain.Users.Entity;
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

        public void AddGotcha(GotchaEntity gotcha, UsersEntity user)
        {
            var gotchaEntity = new FeedGotcha
            {
                Content = gotcha.Content,
                CreationDate = gotcha.CreationDate,
                GotchaId = gotcha.Id,
                IsRepost = false,
                UserId = gotcha.UserId,
                UserLastName = user.LastName,
                UserName = user.Name,
                UserNickname = user.Nickname,
            };

            this.Feed.Add(gotchaEntity);
        }

        public void AddRepost(RepostEntity repost, GotchaEntity gotcha, UsersEntity user)
        {
            var repostedGotcha = this.Feed.FirstOrDefault(g => g.GotchaId == gotcha.Id);
            var idxReposted = this.Feed.FindIndex(g => g.GotchaId == gotcha.Id);
            this.Feed[idxReposted].QntdRepost += 1;

            var gotchaEntity = new FeedGotcha
            {
                Content = repost.RepostContent,
                CreationDate = repost.RepostDate,
                GotchaId = repost.Id,
                IsRepost = true,
                UserId = repost.UserId,
                UserLastName = user.LastName,
                UserName = user.Name,
                UserNickname = user.Nickname,
                RepostedGotcha = new FeedRepostedGotcha
                {
                    Content = repostedGotcha.Content,
                    CreationDate = repostedGotcha.CreationDate,
                    GotchaId = repostedGotcha.GotchaId,
                    UserLastName = repostedGotcha.UserLastName,
                    UserName = repostedGotcha.UserName,
                    UserNickname = repostedGotcha.UserNickname,
                    UserId = repostedGotcha.UserId
                }
            };

            this.Feed.Add(gotchaEntity);
        }
    }

    public class FeedGotcha
    {
        [BsonId]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public Guid GotchaId { get; set; }
        public DateTime CreationDate { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserNickname { get; set; }
        public string Content { get; set; }
        public int QntdRepost { get; set; }
        public bool IsRepost { get; set; }
        public FeedRepostedGotcha? RepostedGotcha { get; set; }
    }

    public class FeedRepostedGotcha
    {
        [BsonId]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public Guid GotchaId { get; set; }
        public DateTime CreationDate { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserNickname { get; set; }
        public string Content { get; set; }
    }
}
