﻿namespace SharpRepository.Repository.Configuration
{
    public interface IRepositoryElement
    {
        string Name { get; set; }

        IRepository<T, TKey> GetInstance<T, TKey>() where T : class, new();
    }
}
