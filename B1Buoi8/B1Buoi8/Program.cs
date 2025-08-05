using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1Buoi8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng Car
            Car car = new Car("Toyota Camry", 180.5, "Xăng");
            car.StartEngine();
            car.DisplayInfo();
            car.StopEngine();

            Console.WriteLine();

            // Tạo đối tượng Motorbike
            Motorbike motorbike = new Motorbike("Honda Wave", 100.0, 110);
            motorbike.StartEngine();
            motorbike.DisplayInfo();
            motorbike.StopEngine();
        }
        static void Bai1()
        {
            Random r = new Random();
            int rlnt = r.Next(1, 100);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Nhap so ban doan: ");
                int input = int.Parse(Console.ReadLine());
                if (input < rlnt)
                {
                    Console.WriteLine("Nho hon");
                }
                else if (input > rlnt)
                {
                    Console.WriteLine("Lon hon");
                }
                else
                {
                    Console.WriteLine("Ban da doan dung!");
                    break;
                }
            }
            Console.WriteLine($"So dung là: {rlnt}");
        }
        static void Bai2()
        {
           
            {
                Console.WriteLine("Nhap day so nguyen:");
                string input = Console.ReadLine();
                string[] parts = input.Split(new[] { ' ' });
                List<int> numbers = new List<int>();
                foreach (string part in parts)
                {
                    if (int.TryParse(part, out int number))
                    {
                        numbers.Add(number);
                    }
                }
                Dictionary<int, int> freq = new Dictionary<int, int>();
                foreach (int num in numbers)
                {
                    if (freq.ContainsKey(num))
                        freq[num]++;
                    else
                        freq[num] = 1;
                }

                int dem = freq.Values.Max();
                int xhnhieu = freq.First(x => x.Value == dem).Key;

                Console.WriteLine($"So xh nhieu nhat: {xhnhieu} (xuat hien {dem} lan)");
            }
        }
        static void B3()
        {
            Console.WriteLine("Nhap vao mot chuoi:");
            string input = Console.ReadLine();
            string daonguoc = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                daonguoc += input[i];
            }
            Console.WriteLine("Chuoi dao nguoc: " + daonguoc);

        }
        static void B4()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            
            string ten = Console.ReadLine();
            string sodienthoai;

            // Vòng lặp để nhập nhiều cặp tên và số điện thoại
            while (!string.IsNullOrEmpty(ten)) // Dừng khi tên rỗng
            {
                Console.WriteLine("Nhập số điện thoại:");
                phoneBook[ten] = sodienthoai = Console.ReadLine(); // Gán và lưu vào Dictionary

                Console.WriteLine("Nhập tên tiếp theo (nhấn Enter để kết thúc):");
                ten = Console.ReadLine();
            }

        }
    }
}
