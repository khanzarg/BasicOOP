using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    public class BMI
    {
        private float berat;
        private float tinggi;
        private float nilai;
        private string nama;

        public BMI()
        {

        }

        public BMI(float weight, float height)
        {
            this.berat = weight;
            this.tinggi = height;
        }

        public float setBMI()
        {
            this.nilai = (berat * berat) / tinggi;
            return nilai;
        }

        public virtual void getKategori()
        {

        }
    }

    public class Nama : BMI
    {
        private string name;
        private float berat;
        private float tinggi;
        private float nilai;

        public Nama(string n)
        {
            this.name = n;
        }

        public void getNama()
        {
            for (int i = 1; i <= name.Length; i++)
            {
                Console.WriteLine("Huruf ke " + i + " adalah " + name[i - 1]);
            }
        }

        public override void getKategori()
        {
            if (nilai < 18.1)
                Console.WriteLine("Your BMI's " + Math.Round(nilai, 1) + "," + "you're Underweight");
            else if (nilai > 18.1 && nilai < 23.1)
                Console.WriteLine("Your BMI's " + Math.Round(nilai, 1) + "," + "you're Normal");
            else if (nilai > 23.1)
                Console.WriteLine("Your BMI's " + Math.Round(nilai, 1) + "," + "you're Overweight");
            else
                Console.WriteLine("Your BMI's " + Math.Round(nilai, 1) + "," + "you're Obesitas");
        }

        public void getEvenChar()
        {
            for (int i = 1; i < name.Length; i = i + 2)
            {
                Console.WriteLine(name[i]);
            }
        }

        public void getOddChar()
        {
            for (int i = 0; i < name.Length; i = i + 2)
            {
                Console.WriteLine(name[i]);
            }
        }
    }

    public class sumArray
    {
        int[] sum;

        public sumArray(int size)
        {
            this.sum = new int[size];
        }

        public void getSumArray()
        {
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = Convert.ToInt32(Console.ReadLine());
            }
            int total = sum.Sum();
            Console.WriteLine("Result : " + total);
        }
    }


    class Program
    {
        static void Menu()
        {
            Console.WriteLine("Input Your Number From 1-5");
            Console.WriteLine("1. Body Mass Index");
            Console.WriteLine("2. Reprint Name");
            Console.WriteLine("3. Print Even's Character");
            Console.WriteLine("4. Print Odd's Character");
            Console.WriteLine("5. Sum the Inputted Array");
            Console.WriteLine("");
            String option = Console.ReadLine();
            int menu = Convert.ToInt32(option);

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Body Mass Index");
                    Console.Write("Input Your Weigth(Kg) : ");
                    String berat = Console.ReadLine();
                    Console.Write("Input Your Height(Cm) : ");
                    String tinggi = Console.ReadLine();

                    float weight = Convert.ToInt32(berat);
                    float height = Convert.ToInt32(tinggi);
                    BMI bmi = new BMI(weight, height);
                    bmi.setBMI();
                    bmi.getKategori();
                    break;
                case 2:
                    Console.Write("Please Input Your Name : ");
                    String name = Console.ReadLine();
                    Nama reprint = new Nama(name);
                    reprint.getNama();
                    break;
                case 3:
                    Console.Write("Please Input Your Name : ");
                    name = Console.ReadLine();
                    Nama even = new Nama(name);
                    even.getEvenChar();
                    break;
                case 4:
                    Console.Write("Please Input Your Name : ");
                    name = Console.ReadLine();
                    Nama odd = new Nama(name);
                    odd.getOddChar();
                    break;
                case 5:
                    Console.WriteLine("Please Input the Array Size : ");
                    String size = Console.ReadLine();
                    sumArray sumInput = new sumArray(Convert.ToInt32(size));
                    sumInput.getSumArray();
                    break;
                default:
                    Console.WriteLine("Please Input Number 1-5");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("Type yes to restart program");
            String restart = Console.ReadLine();
            if (restart.ToLower() == "yes")
            {
                Menu();
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}