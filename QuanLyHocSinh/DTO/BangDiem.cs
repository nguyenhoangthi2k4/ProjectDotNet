using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangDiem : HocSinh
    {
        private string _maNH, _maHK, _toan, _ngVan, _ngNgu, _vatLy, _hoaHoc, _sinhHoc, _diaLy, _lichSu, _gdcd, _dtb;
        public BangDiem() { }

        public string MaNH { get => _maNH; set => _maNH = value; }
        public string MaHK { get => _maHK; set => _maHK = value; }
        public string Toan { get => _toan; set => _toan = value; }
        public string NgVan { get => _ngVan; set => _ngVan = value; }
        public string NgNgu { get => _ngNgu; set => _ngNgu = value; }
        public string VatLy { get => _vatLy; set => _vatLy = value; }
        public string HoaHoc { get => _hoaHoc; set => _hoaHoc = value; }
        public string SinhHoc { get => _sinhHoc; set => _sinhHoc = value; }
        public string DiaLy { get => _diaLy; set => _diaLy = value; }
        public string LichSu { get => _lichSu; set => _lichSu = value; }
        public string Gdcd { get => _gdcd; set => _gdcd = value; }
        public string Dtb { get => _dtb; set => _dtb = value; }

        public void TinhDTB()
        {
            double tmp = (double.Parse(Toan) + double.Parse(NgVan) + double.Parse(NgNgu) + double.Parse(VatLy) + double.Parse(HoaHoc) + double.Parse(SinhHoc) + double.Parse(DiaLy) + double.Parse(LichSu) + double.Parse(Gdcd))/9;
            this.Dtb = tmp.ToString();
        }
    }
}
