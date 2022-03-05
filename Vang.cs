using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangVangBac
{
	class Vang : VangBac
	{
		int tuoiVang;
		string loaiVang;
		int soLuong;

		public Vang() : base()
		{
			tuoiVang = 0;
			loaiVang = "";
			soLuong = 0;
		}		
		public Vang(string maSP, string tenSP, string hangSX, int donGia,
			int tuoiVang, string loaiVang, int soLuong)
			: base (maSP, tenSP, hangSX, donGia)
		{
			this.tuoiVang = tuoiVang;
			this.loaiVang = loaiVang;
			this.soLuong = soLuong;
		}
		public void setTuoivang(int tuoiVang)
		{
			this.tuoiVang = tuoiVang;
		}
		public void setLoai(string loaiVang)
		{
			this.loaiVang = loaiVang;
		}
		public void setSoluong(int soLuong)
		{
			this.soLuong = soLuong;
		}
		public int getTuoivang()
		{
			return tuoiVang;
		}
		public string getLoai()
		{
			return loaiVang;
		}
		public int getSoluong()
		{
			return soLuong;
		}
		public override void NhapThongTin()
		{
			Console.WriteLine("--------------------------------");
			base.NhapThongTin();
			Console.Write("Nhap Tuoi Vang: ");
			tuoiVang = int.Parse(Console.ReadLine());
			Console.Write("Nhap Loai: ");
			loaiVang = Console.ReadLine();
			Console.Write("Nhap So Luong: ");
			soLuong = int.Parse(Console.ReadLine());
		}
		public override void XuatThongTin()
		{
			base.XuatThongTin();
			Console.WriteLine("Tuoi Vang la: " + tuoiVang);
			Console.WriteLine("Loai Vang la: " + loaiVang);
			Console.WriteLine("So luong la: " + soLuong);
			Console.WriteLine("--------------------------------");
		}
		public float XetGiamGia()
        {
			if (this.getTuoivang() == 96 && this.getLoai() == "Nhan")
            {
				return 3;
            } 
			else if (this.getTuoivang() == 97 && this.getLoai() == "Nhan")
            {
				return 2;
            } 
			else if (this.getTuoivang() == 98 && this.getLoai() == "Nhan")
            {
				return 1;
            } 
			else 
			{ 
				return 0;
			}
        }
		public void TinhTongTien()
        {
			float TongTien = this.getDongia()/100 * (100 - this.XetGiamGia());
			Console.Write("Tong tien la: " + TongTien);
        }
	}
}