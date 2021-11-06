using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiDom_Perkovic
{
    public interface StudentiPoSobamaCRUD
    {
        void CreateStudentiPoSobama(string oibStudenta, string idSobe);
        List<StudentiPoSobama> GetStudentiPoSobama();
        void UpdateStudentiPoSobama(string oibStudenta, string idSobe);
        void DeleteStudentiPoSobama(string oibStudenta, string idSobe);
    }
}
