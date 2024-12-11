using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HanhKiem : HocSinh
    {
        private string _maNH, _maHK, _loaiHK;
        public HanhKiem() { }

        public string MaNH { get => _maNH; set => _maNH = value; }
        public string MaHK { get => _maHK; set => _maHK = value; }
        public string LoaiHK { get => _loaiHK; set => _loaiHK = value; }
    }
}
