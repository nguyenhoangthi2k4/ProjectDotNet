﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVien : TaiKhoan
    {
        private string _maGV, _tenGV, _ngaySinh, _soDT, _diaChi, _email, _gioiTinh, _monGD, _maToGV;
        ToGV toGV = new ToGV();

        public GiaoVien():base()
        {
            MaToGV = toGV.MaToGV; 
        }

        public string MaGV { get => _maGV; set => _maGV = value; }
        public string TenGV { get => _tenGV; set => _tenGV = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string SoDT { get => _soDT; set => _soDT = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string Email { get => _email; set => _email = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string MonGD { get => _monGD; set => _monGD = value; }
        public string MaToGV { get => _maToGV; set => _maToGV = value; }        
    }
}
