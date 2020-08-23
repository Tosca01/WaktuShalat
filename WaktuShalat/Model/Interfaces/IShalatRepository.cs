using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaktuShalat.Model.Interfaces
{
    interface IShalatRepository
    {
        Task<bool> CreateTableIfNotExists();
        Task<List<Shalat>> GetShalat();
        Shalat GetByDate(string date);
        bool CheckIfDataExists(string date);
        void Insert(Shalat shalat);
        void Remove(string date);
        void RemoveAll();

    }
}
