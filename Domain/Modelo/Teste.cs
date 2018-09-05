using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Modelo{
    public class Teste : IModeloBase
    {       
        public string NomeColecao { get => "Teste"; }
        
        [BsonId]
        public ObjectId Id { get; set; }

        public string NomeTeste { get; set; }
        
        
    }
}