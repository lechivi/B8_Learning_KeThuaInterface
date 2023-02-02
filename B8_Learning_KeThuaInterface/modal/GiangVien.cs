using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8_Learning_KeThuaInterface.modal
{
    internal class GiangVien : People, TinhLuong
    {
        private string maGV;
        private DateTime ngayVaoLam;
        private double heSoLuong;
        private string trinhDo;

        public string MaNV { get => this.maGV; set => this.maGV = value; }
        public DateTime NgayayVaoLam { get => this.ngayVaoLam; set => this.ngayVaoLam = value; }
        public double HeSoLuong { get => this.heSoLuong; set => this.heSoLuong = value; }
        public string TrinhDo { get => this.trinhDo; set => this.trinhDo = value; }

        public GiangVien() : base()
        {
            this.maGV = "";
            this.ngayVaoLam = DateTime.Now;
            this.heSoLuong = 0;
            this.trinhDo = "";
        }

        public GiangVien(string maGV, string name, string gender, DateTime dateOfBirth,
            DateTime ngayVaoLam, double heSoLuong, string trinhDo) : base(name, gender, dateOfBirth)
        {
            this.maGV = maGV;
            this.ngayVaoLam = ngayVaoLam;
            this.heSoLuong = heSoLuong;
            this.trinhDo = trinhDo;
        }

        public double CalSalary()
        {
            return heSoLuong * Constance.MLCB + Constance.PhuCapGV;
        }

        public override string ToString()
        {
            return "Thuc lanh: " + CalSalary();
        }
    }
}
