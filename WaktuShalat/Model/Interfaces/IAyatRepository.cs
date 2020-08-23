using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaktuShalat.Model.Interfaces
{
    interface IAyatRepository
    {
        Task<bool> CreateTableIfNotExists();
        Task<List<Ayat>> GetAyat();
        Task<Ayat> GetRandom();
        void Insert(Ayat ayat);
        void RemoveAll();

    }
}
