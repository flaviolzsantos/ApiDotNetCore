using MongoDB.Driver;
using Modelo;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace Repositorio
{
    public class RepBase<T> where T : IModeloBase
    {
        private IMongoDatabase mongoClient = Conexao.ObterConexao;

        public void Adicionar(T item) =>
            mongoClient.GetCollection<T>(item.NomeColecao).InsertOne(item);

        public void Atualizar(T item, UpdateDefinition<T> update) =>
            mongoClient.GetCollection<T>(item.NomeColecao).UpdateOne(x => x.Id == item.Id, update);

        public void Deletar(T item) =>
            mongoClient.GetCollection<T>(item.NomeColecao).DeleteOne(x => x.Id == item.Id);
        
        public T ObterPorId(T item) => 
            mongoClient.GetCollection<T>(item.NomeColecao).Find(x => x.Id == item.Id).FirstOrDefault();

        public List<T> ListarPor(T item, Expression<Func<T, bool>> filter) =>
            mongoClient.GetCollection<T>(item.NomeColecao).Find(filter).ToList();
        
        public List<T> ListarTodos(T item) =>
            mongoClient.GetCollection<T>(item.NomeColecao).Find(x => true).ToList();

    }
}