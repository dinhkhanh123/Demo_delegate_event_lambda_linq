using System;
using System.Linq;

namespace Demo_Lambda_Example
{
    /*
     
    lambda - còn gọi là biểu thức hàm nặc danh (Anonymous), một biểu thức khai báo giống phương thức (hàm) nhưng thiếu tên. 
    1. 
    (các_tham_số) => biểu_thức;

    2.
    (các_tham_số) =>
{
   // các câu lệnh
    // Sử dụng return nếu có giá trị trả về
}
    ex: 
    (int x, int y) => {
           return x + y;
     };
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Khong tham so*/
            //Action thongbao;
            //thongbao = () => Console.WriteLine("Xin chao");
            //thongbao?.Invoke();

            /* Co 1 tham so*/
            //Action<string> thongbao;
            //thongbao =   (s) => Console.WriteLine(s);
            //thongbao?.Invoke("Xin chao");

            /* Co 2 tham so*/
            //Action<string,string> thongbao;
            //thongbao = (s, n) =>
            //{
            //    Console.WriteLine(s +" "+ n);
            //};
            //thongbao?.Invoke("Xin chao","Khanh");

            /* Khai bao kieu tra ve */
            //Func<int, int, int> tinhtoan;

            //tinhtoan = (a, b) =>
            //{
            //    int kq = a + b;
            //    return kq;
            //};

            //Console.WriteLine("Ket qua la :" + tinhtoan?.Invoke(5, 6));


            int[] mang = { 15, 65, 47, 35, 86, 48, 2, 85, 43, 13, 86, 66, 56 };

            //mang.ToList().ForEach(
            //    (x)=>
            //    {
            //        if(x % 2 !=0 )
            //            Console.WriteLine(x);
            //    }
            //    );

            var kq = mang.Where(
                (s) =>
                {
                    return s % 4 == 0;
                    
                });

            foreach(var s in kq)
            {
                Console.WriteLine(s);
            }
        }
    }
}
