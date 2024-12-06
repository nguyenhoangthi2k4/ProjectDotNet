using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhuHuynh
    {
        private string _maHS, _hoTen, _ngaySinh, _diaChi, _soDT, _quanHe, _gioiTinh;

        public PhuHuynh() { }
        public string MaHS { get => _maHS; set => _maHS = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string SoDT { get => _soDT; set => _soDT = value; }
        public string QuanHe { get => _quanHe; set => _quanHe = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
    }
}
