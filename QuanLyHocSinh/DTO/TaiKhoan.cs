using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string _taikhoan, _matkhau, _quyen;
        public TaiKhoan() { }
        public string Taikhoan { get => _taikhoan; set => _taikhoan = value; }
        public string Matkhau { get => _matkhau; set => _matkhau = value; }
        public string Quyen { get => _quyen; set => _quyen = value; }
    }
}
