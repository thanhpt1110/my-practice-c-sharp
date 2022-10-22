using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using BT_LT_21520455;

namespace BT_LT_21520455
{
    public class SinhVien : IComparable
    {
        public string ten, lop;
        public int mssv;

        public void nhapThongTin()
        {
            Console.Write("Nhap ten: "); this.ten = Console.ReadLine();
            Console.Write("Nhap MSSV: "); this.mssv = int.Parse(Console.ReadLine());
            Console.Write("Nhap lop: "); this.lop = Console.ReadLine();
        }

        public override string ToString()
        {
            return this.mssv.ToString() + "-" + this.ten + "-" + this.lop;
        }

        public int CompareTo(object obj)
        {
            SinhVien a = (SinhVien)obj;
            return this.mssv.CompareTo(a.mssv);
        }
    }

    public class Lop : IEnumerable
    {
        List<SinhVien> Lop_SV = new List<SinhVien>();

        public void Add(SinhVien s)
        {
            Lop_SV.Add(s);
        }

        public void Sort()
        {
            Lop_SV.Sort();
        }

        public void Clear()
        {
            Lop_SV.Clear();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Lop_SV.GetEnumerator();
        }
    }

    internal class Program
    {
        public static void GhiDuLieuVaoFile(Lop QuanLySinhVien)
        {
            if (!File.Exists("data.txt"))
            {
                using (StreamWriter sw = new StreamWriter("data.txt"))
                {
                    foreach (SinhVien x in QuanLySinhVien)
                        sw.WriteLine(x);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("data.txt"))
                {
                    foreach (SinhVien x in QuanLySinhVien)
                        sw.WriteLine(x);
                }
            }
        }

        public static void DocDuLieuTuFile(Lop QuanLySinhVien)
        {
            QuanLySinhVien.Clear();

            string[] lines = File.ReadAllLines("data.txt");
            for (int i = 0; i < lines.Length; ++i)
            {
                string[] words = lines[i].Split('-');
                SinhVien tmp = new SinhVien();
                tmp.mssv = int.Parse(words[0]);
                tmp.ten = words[1];
                tmp.lop = words[2];
                QuanLySinhVien.Add(tmp);
            }
        }

        public static void NhapThongTinLop(Lop QuanLySinhVien)
        {
            Console.Write("So luong sinh vien can nhap thong tin: ");
            int SoLuongSV = int.Parse(Console.ReadLine());

            // Nhập thông tin
            for (int i = 0; i < SoLuongSV; ++i)
            {
                Console.WriteLine("Nhap thong tin sinh vien thu {0}", i + 1);
                SinhVien tmp = new SinhVien();
                tmp.nhapThongTin();
                QuanLySinhVien.Add(tmp);
            }
        }

        static void Main(string[] args)
        {
            Lop QuanLySinhVien = new Lop();
            NhapThongTinLop(QuanLySinhVien);

            DocDuLieuTuFile(QuanLySinhVien);
            QuanLySinhVien.Sort();
            GhiDuLieuVaoFile(QuanLySinhVien);

            // Hiển thị dữ liệu cho người dùng
            Console.WriteLine("----------------------------");
            Console.WriteLine("Bo du lieu trong file hien tai!");
            string data = File.ReadAllText("data.txt");
            Console.Write(data);

            // Xử lý nhập thêm MSSV 
            Console.WriteLine("----------------------------");
            Console.Write("Nhap MSSV can them: ");
            string mssv = Console.ReadLine();

            if (data.Contains(mssv))
            {
                Console.WriteLine("MSSV nay da co trong file. Chuong trinh ket thuc!");
                Console.ReadKey();
                return;
            }

            DocDuLieuTuFile(QuanLySinhVien);
            Console.WriteLine("MSSV nay chua co trong file. Xin moi nhap cac thong tin sau:");
            SinhVien a = new SinhVien();
            a.nhapThongTin();
            QuanLySinhVien.Add(a);

            QuanLySinhVien.Sort();

            GhiDuLieuVaoFile(QuanLySinhVien);

            Console.WriteLine("----------------------------");
            Console.WriteLine("Du lieu da duoc them vao thanh cong!");
            Console.Write(File.ReadAllText("data.txt"));

            Console.ReadKey();
        }
    }
}