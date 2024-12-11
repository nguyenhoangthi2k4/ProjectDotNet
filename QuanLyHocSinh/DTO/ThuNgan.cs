using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThuNgan
    {
        private string _maHS, _maNH, _maHK, _tinhTrangHP, _tinTrangBHYT, _ngayDongHP, _ngayDongBHYT;
        private float _tienHP, _tienBHYT;
        public ThuNgan() { }

        public string MaHS { get => _maHS; set => _maHS = value; }
        public string MaNH { get => _maNH; set => _maNH = value; }
        public string MaHK { get => _maHK; set => _maHK = value; }
        public float TienHP { get => _tienHP; set => _tienHP = value; }
        public float TienBHYT { get => _tienBHYT; set => _tienBHYT = value; }
        public string TinhTrangHP { get => _tinhTrangHP; set => _tinhTrangHP = value; }
        public string TinTrangBHYT { get => _tinTrangBHYT; set => _tinTrangBHYT = value; }
        public string NgayDongHP { get => _ngayDongHP; set => _ngayDongHP = value; }
        public string NgayDongBHYT { get => _ngayDongBHYT; set => _ngayDongBHYT = value; }
    }
}
