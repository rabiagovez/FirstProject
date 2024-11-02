﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using YoutubeBlog.Core.Entities;
using YoutubeBlog.Data.Repositories.Abstractions;
namespace YoutubeBlog.Data.Repositories.Concretes
{
    public class Repository<T> : IRepository<T> where T : class, IEntityBase, new()
    {
        private readonly DbContext dbContext;

        //Constructor (field)
        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //Veritabanında set etme işlemi
        private DbSet<T> Table { get => dbContext.Set<T>(); }

        //Liste olarak dönmesini ayrıca filtreleme yapabilmemi sağlamak için bir method
        public async Task<List<T>> GetAllAsync(Expression<Func<T,bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            if(predicate != null)
                query = query.Where(predicate);

            if(includeProperties.Any())
                foreach(var item  in includeProperties)
                    query = query.Include(item);

            return await query.ToListAsync();  
        }

        //AddAsync Methodu: Veritabanına veri kaydeder
        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            query = query.Where(predicate);
            if (includeProperties.Any())
                foreach (var item in includeProperties)
                    query = query.Include(item);

            return await query.SingleOrDefaultAsync();
        }

        public async Task<T> GetByGuidAsync(Guid id)
        {
            return await Table.FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            Table.Update(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task<T> DeleteAsync(T entity)
        {
            Table.Remove(entity);
            await dbContext.SaveChangesAsync(); // Save changes
            return entity;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            return await Table.CountAsync(predicate);
        }
    }
}

//Task = void
