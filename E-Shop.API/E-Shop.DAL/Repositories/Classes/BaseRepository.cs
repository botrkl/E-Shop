﻿using E_Shop.DAL.Context;
using E_Shop.DAL.Entities;
using E_Shop.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace E_Shop.DAL.Repositories.Classes
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private EShopDbContext _dbContext;
        public BaseRepository(EShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<TEntity?> GetByIdAsync(Guid id)
        {
            var searchedEntity = await _dbContext.Set<TEntity>().FirstAsync(x => x.Id == id);
            return searchedEntity;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var removeEntity = await _dbContext.Set<TEntity>().FirstAsync(x => x.Id == id);
            _dbContext.Set<TEntity>().Remove(removeEntity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<TEntity>?> GetAllAsync()
        {
            var result = await _dbContext.Set<TEntity>().ToListAsync();
            return result;
        }
    }
}
