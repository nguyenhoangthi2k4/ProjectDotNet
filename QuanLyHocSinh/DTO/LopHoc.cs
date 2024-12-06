using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHoc : NamHoc
    {
        private string _maLop, _tenLop, _gvcn, _siSo;
        public LopHoc():base() { }

        public string MaLop { get => _maLop; set => _maLop = value; }
        public string TenLop { get => _tenLop; set => _tenLop = value; }
        public string Gvcn { get => _gvcn; set => _gvcn = value; }
        public string SiSo { get => _siSo; set => _siSo = value; }
    }
}
