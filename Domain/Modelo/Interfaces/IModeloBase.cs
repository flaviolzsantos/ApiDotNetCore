
using MongoDB.Bson;

namespace Modelo
{
    public interface IModeloBase
    {
        ObjectId Id { get; set; }
        string NomeColecao { get;}
    }
}