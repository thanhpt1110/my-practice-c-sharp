using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTW_BTH1_Bai_4
{
    class PhanSo
    {
        private double tu, mau;
        public PhanSo()
        {
            this.mau = 1;
        }
        public double TuSo
        {
            get
            {
                return this.tu;
            }
            set
            {
                this.tu = value;
            }
        }

        public double MauSo
        {
            get
            {
                return this.mau;
            }
            set
            {
                try
                {
                    if (value == 0)
                    {
                        Exception MauBangKhong = new Exception("Mau phai khac 0!");
                        throw MauBangKhong;
                    }
                    else
                        this.mau = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw e;
                }
            }
        }

        public void Rutgon()
        {
            double a = this.TuSo;
            double b = this.MauSo;
            double ucln;
            if (a < 0)
            {
                a = a * (-1);
            }
            if (b < 0)
            {
                b = b * (-1);
            }
            if (a == 0)
            {
                ucln = a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            ucln = a;
            this.TuSo /= ucln;
            this.MauSo /= ucln;
        }

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo res = new PhanSo();
            res.MauSo = a.MauSo * b.MauSo;
            res.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            res.Rutgon();
            return res;
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo res = new PhanSo();
            res.MauSo = a.MauSo * b.MauSo;
            res.TuSo = a.TuSo * b.MauSo - b.TuSo * a.MauSo;
            res.Rutgon();
            return res;
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo res = new PhanSo();
            res.MauSo = a.MauSo * b.MauSo;
            res.TuSo = a.TuSo * b.TuSo;
            res.Rutgon();
            return res;
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo res = new PhanSo();
            try
            {
                if (b.TuSo == 0)
                {
                    Exception ThuongBangKhong = new Exception("Thuong phai khac 0");
                    throw ThuongBangKhong;
                }
                else
                {
                    res.TuSo = a.TuSo * b.MauSo;
                    res.MauSo = a.MauSo * b.TuSo;
                    res.Rutgon();
                    return res;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        public void nhapPhanSo()
        {
            Console.Write("Nhap tu so: ");
            this.TuSo = double.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            this.MauSo = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return Convert.ToString(this.TuSo) + "/" + Convert.ToString(this.MauSo);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap phan so thu nhat");
            PhanSo a = new PhanSo(); a.nhapPhanSo();

            Console.WriteLine("Nhap phan so thu hai");
            PhanSo b = new PhanSo(); b.nhapPhanSo();

            Console.Write("Tong 2 phan so la: ");
            Console.WriteLine(a + b);

            Console.Write("Hieu 2 phan so la: ");
            Console.WriteLine(a - b);

            Console.Write("Tich 2 phan so la: ");
            Console.WriteLine(a * b);

            Console.Write("Thuong 2 phan so la: ");
            Console.WriteLine(a / b);

            Console.ReadKey();
        }
    }
}
