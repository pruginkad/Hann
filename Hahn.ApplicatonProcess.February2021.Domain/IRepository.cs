﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Domain
{
    public enum EN_RETCODE
    {
        OK = 0,
        FAILED
    }
    public interface IRepository<T> where T : class
    {
        Task<T> Create(T item);
        Task<T> GetById(int id);
        Task<EN_RETCODE> Delete(int id);
        Task<EN_RETCODE> Update(T item);
        Task<IEnumerable<T>> GetAll();

    }
}
