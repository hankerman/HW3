using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{

    //задание 4 
    //Создайте класс «Магазин». Необходимо хранить в
    //полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail.
    //Реализуйте методы класса для ввода данных, вывода
    //данных, реализуйте доступ к отдельным полям через
    //методы класса.

    enum 

    class Products
    {
        private string name;
        private int quantity;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { if(value >= 0)
                {
                    quantity = value;
                }
                }
        }

        public Products(string name)
        {
            this.name = name;
            quantity = 1;
        }
        public Products(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }

    }

    class Market
    {

        private string name;
        private string adres;
        private string profil;
        private string telephone;
        private string email;
        private Products[] products;
        public string Name
        {
            get { return Name; }
        }
        public string Adres
        {
            get { return adres; }
        }
        public string Profil
        {
            get { return profil; }
            set { profil = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }



        Market(string name, string adres)
        {

            this.name = name;
            this.adres = adres;
            profil = name + "\n" + adres + "\n" + telephone + "\n" + email;

        }

        void PrintProd()
        {
            
            foreach(Products p in products)
            {
                Console.WriteLine(p.Name + " в колличестве - " + p.Quantity);
            }

        }

        void PrintProfil()
        {

            Console.WriteLine(Profil);

        }

        void RedacProfil()
        {
            Console.WriteLine("Введите номер телефона");
            Telephone = Console.ReadLine();
            Console.WriteLine("Введите электроную почту");
            Email = Console.ReadLine();
            profil = name + "\n" + adres + "\n" + telephone + "\n" + email;

        }

        void RedacProfil(string telephone, string email)
        {

            Telephone = telephone;
            Email = email;

            profil = name + "\n" + adres + "\n" + telephone + "\n" + email;

        }

        void refill(string name, int quantity)
        {

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == name)
                {
                    products[i].Quantity = quantity;
                }
                else
                {
                    Console.WriteLine("Продукт не найден");
                }
            }

        }

        

        void AddProduct(string name)
        {
            Products temp = new Products(name);
            Array.Resize(ref products, products.Length+1);
            products[products.Length - 1] = temp;

        }

        void AddProduct(string name, int quantity)
        {
            Products temp = new Products(name, quantity);
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = temp;

        }



    }



    class Program
    {

        static void PrintQuadro(int n, char s)
        {

            //задание1
            //Напишите метод, который отображает квадрат из
            //некоторого символа.Метод принимает в качестве параметра: длину стороны квадрата, символ.

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine();
            }

        }

        static bool Palindrom(int n)
        {

            //задание2
            //Напишите метод, который проверяет является ли
            //переданное число «палиндромом». Число передаётся в
            //качестве параметра.Если число палиндром нужно вернуть из метода true, иначе false.

            string s = n.ToString();
            char[] rev = s.ToCharArray();
            Array.Reverse(rev);
            string revers = new string(rev);
            if (s == revers)
            {
                return true;
            }

            return false;

        }

        static void DelArrEl(ref int[] arr, int index)
        {
            //дополнение для 3 задания
            for (int i = index; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);

        }

        static int[] ArrayFilter(int[] arr, int[] filter)
        {

            //задание3
            //Напишите метод, фильтрующий массив на основании
            //переданных параметров


            int count = 0;
            for(int i = 0; i < filter.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if(filter[i] == arr[j])
                    {
                        count++;
                    }
                }
                for(int j = 0; j < count; j++)
                {
                    for(int t = 0; t < arr.Length; t++)
                    {
                        if (filter[i] == arr[t])
                        {
                            DelArrEl(ref arr, t);
                            break;
                        }
                    }


                }
            }

            return arr;

        }

        static void Main(string[] args)
        {

            //int[] one = new int[] { 5, 4, 7, 3, 8, 9, 2 };
            //int[] two = new int[] { 4, 3, 2 };
            //int[] arr = ArrayFilter(one, two);

            //foreach (int i in arr)
            //{
            //    Console.Write(i + " ");
            //}

            


        }
    }
}