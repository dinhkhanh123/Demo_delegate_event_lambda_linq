using System;

namespace Demo_Delegate_Example
{
    public delegate void ShowLog(string message);
    class Program
    {
        //tao phuong thuc 
        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();   

        }
        static void Warning(string t)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(t);
            Console.ResetColor();
        }

        static int Tong(int a, int b) => a + b;    
        static int Hieu(int a, int b) => a - b;

        /* Sử dụng Delegate làm tham số hàm 'void'*/

        static void Nhan(int a, int b,ShowLog log)
        {
            int kq = a*b;
            log?.Invoke($"Tich la {kq}");
        }

        //delegate tham chieu
        static void Main(string[] args)
        {
            ShowLog log = null;/* biến , Co the tham chieu den nhieu phuong thuc += */

            /* gan */
            // log += Info;
            // log += Warning;

            /* thi hanh phuong thuc */

            //if(log != null)
            //log("Xin chao");

            /* cach 2 de thi hanh cac phuong thucdang luu trong bien delegate bang cach goi phuong thuc Invoke */
            // log?.Invoke("Xin chao cac ban");



            /* Func và Action là hai mẫu delegate định nghĩa sẵn,
            giúp bạn nhanh chóng tạo ra biến kiểu delegate mà không mất công khai báo */

         //   Action action;                   /* ~ delehate void KIEU()  */
           // Action<string, int> action1;    /* ~ delehate void KIEU(string s, int i)  */
          //  Action<string> action2;         /* ~ delehate void KIEU(string s)  */

            /*gan*/
            //action2 = Warning;
            //action2 += Info;

            //action2?.Invoke("Xin chao");


            // Func<int> f1;                   /* ~ delegate int Kieu() - delegate tra ve int */
            // Func<string,double,string> f2;  /* ~ delegate string Kieu(string s,double d) - tra ve string va co 2 tham so string,double */

            //Func<int, int, int> tinhtoan;

            //Console.Write("Nhap so a: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Nhap so b:");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Chon phep tinh (1. Tinh tong - 2. Tinh hieu): ");
            //int s = int.Parse(Console.ReadLine());  
            //switch (s)
            //{
            //    case 1:
            //        tinhtoan = Tong;
            //        Console.WriteLine($"Ket qua la {tinhtoan(a,b)}");
            //        break;
            //        case 2:
            //            tinhtoan = Hieu;
            //        Console.WriteLine($"Ket qua la {tinhtoan(a, b)}");
            //        break;
            //    default:
            //        Console.WriteLine("Phep tinh khong hop le");
            //        break;
            //}

            /* Sử dụng Delegate làm tham số hàm */
            Nhan(5, 5, Info);
        }
    }
}
