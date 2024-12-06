using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinh : TaiKhoan
    {
        private string _maHS, _hoTen, _ngaySinh, _diaChi, _soDT, _maLop, _maPH, _gioiTinh;
        
        public HocSinh():base() { }
        
        public string MaHS { get => _maHS; set => _maHS = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string SoDT { get => _soDT; set => _soDT = value; }
        public string MaLop { get => _maLop; set => _maLop = value; }
        public string MaPH { get => _maPH; set => _maPH = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
    }
}
