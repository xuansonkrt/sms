using sms.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        internal static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        public List<NhanVienDTO> GetDSNV()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_NHANVIEN_Getall");
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO nhanVien = new NhanVienDTO(item);
                list.Add(nhanVien);
            }
            return list;
        }
        public bool InsertNV(string hoten, DateTime ngsinh, string gioitinh, string diachi, string sdt, int luong)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_NHANVIEN_Insert @hoten , @ngsinh , @gioitinh , @diachi , @sdt , @luong ", new object[] { hoten, ngsinh, gioitinh, diachi, sdt, luong });

            return result > 0;
        }
        public bool UpdateNV(int maNV, string hoten, DateTime ngsinh, string gioitinh, string diachi, string sdt, int luong)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_NHANVIEN_Update @maNV , @hoten , @ngsinh , @gioitinh , @diachi , @sdt , @luong ", new object[] { maNV, hoten, ngsinh, gioitinh, diachi, sdt, luong });

            return result > 0;
        }
        public bool DeleteNV(int maNV)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_NHANVIEN_Delete @maNV ", new object[] { maNV });

            return result > 0;
        }
        public List<NhanVienDTO> SearchNV(string str)
        {
            List<NhanVienDTO> NhanVienList = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_NHANVIEN_Search @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO nhan = new NhanVienDTO(item);
                NhanVienList.Add(nhan);
            }
            return NhanVienList;
        }


    }
}
