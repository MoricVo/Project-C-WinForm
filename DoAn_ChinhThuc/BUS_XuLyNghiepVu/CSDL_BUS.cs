﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_XuLyDuLieu;
namespace BUS_XuLyNghiepVu
{
   public class CSDL_BUS
    {
        public static bool SaoLuu(string sDuongDan)
        {
            return CSDL_DAO.SaoLuuDuLieu(sDuongDan);
        }
    }
}
