using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.BaseMongo.Entity
{
    public class BaseMongoEntity
    {
        [BsonId]
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
