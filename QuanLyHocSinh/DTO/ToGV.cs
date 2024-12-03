using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ToGV
    {
        private string _maToGV, _tenToGV, _truongToGV;

        public ToGV() 
        { 
        }

        public string MaToGV { get => _maToGV; set => _maToGV = value; }
        public string TenToGV { get => _tenToGV; set => _tenToGV = value; }
        public string TruongToGV { get => _truongToGV; set => _truongToGV = value; }
    }
}
