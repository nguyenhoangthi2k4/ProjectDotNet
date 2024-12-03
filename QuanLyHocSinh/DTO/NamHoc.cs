using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NamHoc
    {
        private string _maNH, _maHK;

        public NamHoc()
        {
        }

        public string MaNH { get => _maNH; set => _maNH = value; }
        public string MaHK { get => _maHK; set => _maHK = value; }
    }
}
