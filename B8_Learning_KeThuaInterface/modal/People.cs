using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8_Learning_KeThuaInterface.modal
{
    internal class People
    {
        private string name;
        private string gender;
        private DateTime dateOfBirth;
        public string Name { get => this.name; set => this.name = value; }
        public string Gender { get => this.gender; set => this.gender = value; }
        public DateTime DateOfBirth { get => this.dateOfBirth; set => this.dateOfBirth = value; }


        public People()
        {
            this.name = "";
            this.gender = "";
            this.dateOfBirth = DateTime.Now;
        }

        public People(string name, string gender, DateTime dateOfBirth)
        {
            this.name = name;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
        }

        //Hàm ảo => thể hiện tính đa hình
        //public virtual double CalSalary()
        //{
        //    //return Constance.MLCB;
        //}
    }
}
