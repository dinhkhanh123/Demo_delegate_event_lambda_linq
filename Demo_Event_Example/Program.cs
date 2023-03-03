using System;

namespace Demo_Event_Example
{

    /*Các sự kiện (Event) là cơ chế để một đối tượng (đối tượng của lớp) 
      này thông báo đến đối tượng khác có điều gì đó mà lớp khác quan tâm vừa xảy ra.
     *Lớp mà từ đó gửi đi sự kiện gọi tên nó là publisher và 
      các lớp nhận được sự kiện gọi là là các subsriber.
    
    publisher - class - phat su kien
    subsriber - class - nhan su kien

     
     
     */

    public delegate void Sukiennhap(int x);
    class UserInput
    {
       // public Sukiennhap sukiennhap { set; get; }
        public event Sukiennhap sukiennhap;
        public void Input()
        {
            do
            {
                Console.WriteLine("Nhap mot so");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                sukiennhap?.Invoke(i);
            } while (true);                       
        }
    }
    class TinhCan
    {
        public void Sub(UserInput input)
        {
           // input.sukiennhap = Can;
            input.sukiennhap += Can;
        }
        public void Can(int x)
        {
            Console.WriteLine($"Can cua {x} la {Math.Sqrt(x)}");
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            //publisher
            UserInput input = new UserInput();
           //subsriber
            TinhCan tinh = new TinhCan();
            tinh.Sub(input);
            input.Input();
        }
    }
}
