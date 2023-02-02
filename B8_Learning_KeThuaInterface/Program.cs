using B8_Learning_KeThuaInterface.modal;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8_Learning_KeThuaInterface
{
    internal class Program
    {
        private static void Main()
        {

            People[] listPeople = new People[3];

            People p1 = new GiangVien("GiangVien00", "Levi", "Male", new DateTime(1995, 11, 3), DateTime.Now, 2.5, "DaiHoc");
            listPeople[0] = p1;
            p1 = new GiangVien("GiangVien01", "Levi", "Male", new DateTime(1995, 11, 3), DateTime.Now, 4, "DaiHoc");
            listPeople[1] = p1;
            p1 = new GiangVien("NhanVien02", "ViChiLe", "Male", new DateTime(1990, 8, 3), DateTime.Now, 3, "TienSi");
            listPeople[2] = p1;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(listPeople[i]);
            }
        }
    }
}