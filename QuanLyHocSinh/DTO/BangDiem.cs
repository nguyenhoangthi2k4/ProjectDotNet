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

        public string TinhDTB()
        {
            double toan = double.Parse(Toan);
            double ngVan = double.Parse(NgVan);
            double ngNgu = double.Parse(NgNgu);
            double vatLy = double.Parse(VatLy);
            double hoaHoc = double.Parse(HoaHoc);
            double sinhHoc = double.Parse(SinhHoc);
            double diaLy = double.Parse(DiaLy);
            double lichSu = double.Parse(LichSu);
            double gdcd = double.Parse(Gdcd);
            double dtb = (toan + ngVan + ngNgu + vatLy + hoaHoc + sinhHoc + diaLy + lichSu + gdcd) / 9;
            return Math.Round(dtb, 2).ToString();
        }
    }
}
