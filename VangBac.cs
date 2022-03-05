using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangVangBac
{
	class VangBac
	{
		protected string maSP;
		protected string tenSP;
		protected string hangSX;
		protected int donGia; // Đơn Giá
		protected int loaiSP;

		public int getLoaiSP()
        {
			return loaiSP;
        }
		public void setLoaiSP(int LoaiSP)
        {
			this.loaiSP = LoaiSP;
        }

		public VangBac()
		{//Ham Khoi Tao
			maSP = "";
			tenSP = "";
			hangSX = "";
			donGia = 0;
		}
		public VangBac(string maSP, string tenSP, string hangSX, int donGia)
		{
			this.maSP = maSP;
			this.tenSP = tenSP;
			this.hangSX = hangSX;
			this.donGia = donGia;
		}
		public void setMaSP(string maSP)
		{
			this.maSP = maSP;
		}
		public void setTenSP(string tenSP)
		{
			this.tenSP = tenSP;
		}
		public void setHangSX(string hangSX)
		{
			this.hangSX = hangSX;
		}
		public void setDonGia(int donGia)
		{
			this.donGia = donGia;
		}
		public string getMasp()
		{
			return maSP;
		}
		public string getTensp()
		{
			return tenSP;
		}
		public string getHangsx()
		{
			return hangSX;
		}
		public int getDongia()
		{
			return donGia;
		}
		public virtual void NhapThongTin()
		{
			Console.Write("Nhap ma san pham: ");
			maSP = Console.ReadLine();
			Console.Write("Nhap ma Ten san pham: ");
			tenSP = Console.ReadLine();
			Console.Write("Nhap hang san xuat: ");
			hangSX = Console.ReadLine();
			Console.Write("Nhap don gia: ");
			donGia = int.Parse(Console.ReadLine());
		}
		public virtual void XuatThongTin()
		{
			Console.WriteLine("--------------------------------");
			Console.WriteLine("Ma san pham la: " + maSP);
			Console.WriteLine("Ten san pham la: " + tenSP);
			Console.WriteLine("Hang san xuat la: " + hangSX);
			Console.WriteLine("Don gia la: " + donGia);
		}
	}
}	
