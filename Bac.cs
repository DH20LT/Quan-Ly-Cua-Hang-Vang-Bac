using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangVangBac
{
	class Bac : VangBac
	{
		string kieuBac;
		string loaiBac;
		int soLuong;

		public Bac() : base()
		{
			kieuBac = "";
			loaiBac = "";
			soLuong = 0;
		}
		public Bac(string maSP, string tenSP, string hangSX, int donGia,
			string kieuBac, string loaiBac, int soLuong)
			: base(maSP, tenSP, hangSX, donGia)
		{
			this.kieuBac = kieuBac;
			this.loaiBac = loaiBac;
			this.soLuong = soLuong;
		}
		public void setKieuBac(string kieuBac)
		{
			this.kieuBac = kieuBac;
		}
		public void setLoaiBac(string loaiBac)
		{
			this.loaiBac = loaiBac;
		}
		public void setSoluong(int soLuong)
		{
			this.soLuong = soLuong;
		}
		public string getKieuBac()
		{
			return kieuBac;
		}
		public string getLoaiBac()
		{
			return loaiBac;
		}
		public int getSoluong()
		{
			return soLuong;
		}
		public override void NhapThongTin()
		{
			Console.WriteLine("--------------------------------");
			base.NhapThongTin();
			Console.Write("Nhap Kieu Bac: ");
			kieuBac = (Console.ReadLine());
			Console.Write("Nhap Loai Bac: ");
			loaiBac = Console.ReadLine();
			Console.Write("Nhap So Luong: ");
			soLuong = int.Parse(Console.ReadLine());
		}
		public override void XuatThongTin()
		{
			base.XuatThongTin();
			Console.WriteLine("Kieu Bac la: " + kieuBac);
			Console.WriteLine("Loai Bac la: " + loaiBac);
			Console.WriteLine("So luong la: " + soLuong);
			Console.WriteLine("--------------------------------");
		}
		public int XetGiamGia()
		{
			if (this.getKieuBac() == "Day chuyen" && this.getLoaiBac() == "8k")
			{
				return 4;
			}
			else if (this.getKieuBac() == "Lac" && this.getLoaiBac() == "10k")
			{
				return 2;
			}
			else { return 0; }
		}
		public void TinhTongTien()
		{
			float TongTien = this.getDongia() / 100 * (100 - this.XetGiamGia());
			Console.Write("Tong tien la: " + TongTien);
		}
	}
}
