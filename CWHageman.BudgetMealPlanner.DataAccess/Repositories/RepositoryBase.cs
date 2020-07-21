using CWHageman.BudgetMealPlanner.DataAccess.Repositories.Interfaces;
using CWHageman.BudgetMealPlanner.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CWHageman.BudgetMealPlanner.DataAccess.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
    {
        private readonly string _connectionString;

        public RepositoryBase(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString(ConnectionStringNames.Main);
        }

        public void Add(TEntity entity)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                conn.Insert(entity);
            }
        }

        public void Update(TEntity entity)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                conn.Update(entity);
            }
        }

        public void Delete(int id)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var entity = conn.Get<TEntity>(id);
                conn.Delete(entity);
            }
        }

        public TEntity Get(int id)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                return conn.Get<TEntity>(id);
            }
        }

        public List<TEntity> GetAll()
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                return conn.GetAll<TEntity>().ToList();
            }
        }
    }
}
