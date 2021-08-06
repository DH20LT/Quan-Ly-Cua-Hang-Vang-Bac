using System;

namespace QuanLyCuaHangVangBac
{
    class Program
    {
        static void Main(string[] args)
        {
            VangBac[] arrVangBac = new VangBac[50];
            int iVangBac = 0;
            //int l, j, tmp;
            Console.WriteLine("1. Nhap Thong Tin San Pham");
            Console.WriteLine("2. Xuat ra các san pham Vang");
            Console.WriteLine("3. Xuat ra cac san pham duoc san xuat boi hang PNJ");
            Console.WriteLine("4. Xuat ra cac san pham la Bac loai 10k");
            Console.WriteLine("5. Xuat ra cac san pham la Bac kieu Day chuyen");
            Console.WriteLine("6. Sap xep cac san pham co gia tang dan");
            Console.WriteLine("7. Thoát");
            Console.Write("Nhập chức năng bạn muốn su dụng: ");
            int i = 1;
            while (i < 50)
            {
                int ChucNang = int.Parse(Console.ReadLine());
                switch (ChucNang)
                {
                    case 1: //Nhập thông tin sản phẩm
                        {
                            //Console.WriteLine("--------------------------------");
                            //Console.Write("Ban muon nhap Vang hay Bac?");
                            //string LoaiSanPham = Console.ReadLine();
                            //if(LoaiSanPham == "Vang")
                            //{
                            //    iVangBac++;
                            //    arrVangBac[iVangBac] = new Vang();
                            //    arrVangBac[iVangBac].NhapThongTin();
                            //}
                            //else if(LoaiSanPham == "Bac")
                            //{
                            //    iVangBac++;
                            //    arrVangBac[iVangBac] = new Bac();
                            //    arrVangBac[iVangBac].NhapThongTin();
                            //}
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("Vang = 1 | Bac = 2");
                            Console.Write("Nhap: ");
                            int LoaiSanPham = int.Parse(Console.ReadLine());
                            switch (LoaiSanPham)
                            {
                                case 1:
                                    {
                                        iVangBac++;
                                        arrVangBac[iVangBac] = new Vang();
                                        arrVangBac[iVangBac].NhapThongTin();
                                        break;
                                    }
                                case 2:
                                    {
                                        iVangBac++;
                                        arrVangBac[iVangBac] = new Bac();
                                        arrVangBac[iVangBac].NhapThongTin();
                                        break;
                                    }
                                default:
                                    break;
                            }

                            break;
                        }
                    case 2:
                        {
                            for (int ThuTu = 1; ThuTu < iVangBac; ThuTu++)
                            {
                                if (arrVangBac[ThuTu].getLoaiSP() == 1)
                                {
                                    arrVangBac[ThuTu].XuatThongTin();
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            for (int ThuTu = 1; ThuTu < iVangBac; ThuTu++)
                            {
                                if (arrVangBac[ThuTu].getHangsx() == "PNJ")
                                {
                                    arrVangBac[ThuTu].XuatThongTin();
                                }
                            }
                            break;
                        }
                    case 4: // Xuat ra tat ca san pham la Bac loai 10k
                        {
                            for (int ThuTu = 1; ThuTu < iVangBac; ThuTu++)
                            {
                                if (arrVangBac[ThuTu].getLoaiSP() == 2)
                                {
                                    XuatBac10k((Bac)arrVangBac[ThuTu]);
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            for (int ThuTu = 1; ThuTu < iVangBac; ThuTu++)
                            {
                                if (arrVangBac[ThuTu].getLoaiSP() == 2)
                                {
                                    XuatBacDayChuyen((Bac)arrVangBac[ThuTu]);
                                }
                            }
                            break;
                        }
                    case 6: // Sap xep cac san pham co gia tang dan
                        {
                            //for (l = 0; l < 50; l++)
                            //{
                            //    for (j = l + 1; j < 50; j++)
                            //    {
                            //        if (arrVangBac[j].getDongia() < arrVangBac[l].getDongia())
                            //        {
                            //            tmp = arrVangBac[l].getDongia();
                            //            arrVangBac[l].getDongia() = arrVangBac[l].getDongia();
                            //            arrVangBac[j].getDongia() = tmp;
                            //        }
                            //    }
                            //}
                            break;
                        }
                    default:
                        break;
                }
                
                i++;
            }
        }
        public static void XuatBac10k(Bac bac1)
        {
            if (bac1.getLoaiBac() == "10k")
            {
                bac1.XuatThongTin();
            }
        }
        public static void XuatBacDayChuyen(Bac bac1)
        {
            if (bac1.getKieuBac().Equals("Day chuyen"))
            {
                bac1.XuatThongTin();
            }
        }

    }
}
