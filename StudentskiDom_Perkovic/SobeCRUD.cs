using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiDom_Perkovic
{
    public interface SobeCRUD
    {
        void CreateSobe(Soba soba);
        List<Soba> GetSobe();
        void UpdateSobe(Soba soba);
        void DeleteSobe(Soba soba);
    }
}
