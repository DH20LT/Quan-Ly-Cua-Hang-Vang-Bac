using System;

namespace QuanLyCuaHangVangBac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode; // Giúp hiển thị Tiếng Việt trên app Console
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            VangBac[] arrVangBac = new VangBac[50];
            int iVangBac = 0;
            //int l, j, tmp;
            
            do
            {
                Console.Clear();
                Console.WriteLine("1. Nhap Thong Tin San Pham"); // DONE
                Console.WriteLine("2. Xuat ra các san pham Vang"); // DONE
                Console.WriteLine("3. Xuat ra các san pham Bac"); // DONE
                Console.WriteLine("4. Xuat ra cac san pham duoc san xuat boi hang PNJ");
                Console.WriteLine("5. Xuat ra cac san pham la Bac loai 10k");
                Console.WriteLine("6. Xuat ra cac san pham la Bac kieu Day chuyen");
                Console.WriteLine("7. Sap xep cac san pham co gia tang dan");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhập chức năng bạn muốn su dụng: ");
                int ChucNang = 10;
                try
                {
                    ChucNang = int.Parse(Console.ReadLine());
                } catch
                {
                    Console.WriteLine("Nhập lại: ");
                }
                switch (ChucNang)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1: //Nhập thông tin sản phẩm
                        {
                            
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("Vang = 1 | Bac = 2");
                            Console.Write("Nhap: ");
                            int LoaiSanPham = int.Parse(Console.ReadLine());
                            switch (LoaiSanPham)
                            {
                                case 1:
                                    {
                                        arrVangBac[iVangBac] = new Vang();
                                        arrVangBac[iVangBac].NhapThongTin();
                                        arrVangBac[0].XuatThongTin();
                                        Console.ReadLine();
                                        iVangBac++;
                                        break;
                                    }
                                case 2:
                                    {
                                        arrVangBac[iVangBac] = new Bac();
                                        arrVangBac[iVangBac].NhapThongTin();
                                        iVangBac++;
                                        break;
                                    }
                                default:
                                    break;
                            }

                            break;
                        }
                    case 2: // Xuat ra các san pham Vang
                        {
                            for (int ThuTu = 0; ThuTu < iVangBac; ThuTu++)
                            {
                                if (arrVangBac[ThuTu].getLoaiSP() == 1)
                                {
                                    arrVangBac[ThuTu].XuatThongTin();
                                }
                            }
                            Console.ReadLine();
                            break;
                        }
                    case 3: // Xuat ra các san pham Vang
                        {
                            for (int ThuTu = 0; ThuTu < iVangBac; ThuTu++)
                            {
                                if (arrVangBac[ThuTu].getLoaiSP() == 2)
                                {
                                    arrVangBac[ThuTu].XuatThongTin();
                                }
                            }
                            break;
                        }

                    case 4: //  Xuat ra cac san pham duoc san xuat boi hang PNJ
                        {
                            for (int ThuTu = 0; ThuTu < iVangBac; ThuTu++)
                            {
                                if (arrVangBac[ThuTu].getHangsx() == "PNJ")
                                {
                                    arrVangBac[ThuTu].XuatThongTin();
                                }
                            }
                            break;
                        }

                    case 5: //Xuat ra cac san pham la Bac loai 10k
                        {
                            for (int ThuTu = 0; ThuTu < iVangBac; ThuTu++)
                            {
                                if (arrVangBac[ThuTu].getLoaiSP() == 2)
                                {
                                    XuatBac10k((Bac)arrVangBac[ThuTu]);
                                }
                            }
                            break;
                        }
                    case 6: // Xuat ra cac san pham la Bac kieu Day chuyen
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
                    case 7: // Sap xep cac san pham co gia tang dan
                        {
                            for (int l = 0; l < 50; l++)
                            {
                                for (int j = l + 1; j < 50; j++)
                                {
                                    if (arrVangBac[j].getDonGia() < arrVangBac[l].getDonGia())
                                    {
                                        VangBac tmp = arrVangBac[l];
                                        arrVangBac[l] = arrVangBac[j];
                                        arrVangBac[j] = tmp;
                                    }
                                }
                            }
                            for (int ThuTu = 0; ThuTu < iVangBac; ThuTu++)
                            {
                                arrVangBac[ThuTu].XuatThongTin();
                            }
                            break;
                        }
                    
                    default:
                        break;
                }
                
            }while(true);
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
