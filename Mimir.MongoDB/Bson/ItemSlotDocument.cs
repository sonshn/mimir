using Lib9c.Models.States;
using Libplanet.Crypto;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Mimir.MongoDB.Bson;

[BsonIgnoreExtraElements]
public record ItemSlotDocument(
    [property: BsonIgnore, JsonIgnore] long StoredBlockIndex,
    [property: BsonIgnore, JsonIgnore] Address Address,
    ItemSlotState Object
) : MimirBsonDocument(Address, new DocumentMetadata(1, StoredBlockIndex));
