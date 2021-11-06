using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiDom_Perkovic
{
    public interface StudentiCRUD
    {
     
        void CreateStudent(Studenti studenti);
        List<Studenti> GetStudent();
        void UpdateStudent(Studenti studenti);
        void DeleteStudent(Studenti studenti);
    }
}
