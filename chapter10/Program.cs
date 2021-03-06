﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace chapter10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            var person = new Person();
            //{
            //    FirstName = "太郎",
            //    LastName = "池田"
            //};

            var name1 = person.FullName;
            Console.WriteLine(name1);
            #endregion

            #region オブジェクトを返すSample
            //var book1 = MakeBookObject();
            //var book2 = MakeBookObject();

            //book1.Print();
            //book2.Print();
            #endregion

            #region GetArrayの呼び出し
            //var nums = GetArray(5);

            ////nums配列内の要素の合計を求める
            //var total = 0;

            //foreach (var num in nums)
            //{
            //    total += num;
            //}

            //Console.WriteLine($"合計:{total}");
            #endregion
        }

        public static int[] GetArray(int count)
        {
            var array = new int[count];
            for (int i = 0; i < count; i++)
            {
                var line = Console.ReadLine();
                array[i] = int.Parse(line);
            }
            return array; //配列を返却
        }

        //オブジェクトを返却するメソッド
        public static Book MakeBookObject()
        {
            Console.Write("書籍名　⇒　");
            var title = Console.ReadLine();
            Console.Write("著者名　⇒　");
            var author = Console.ReadLine();
            Console.Write("ページ数　⇒　");
            var pages = Console.ReadLine();

            //オブジェクト初期化子
            var book = new Book
            {
                Title = title,
                Author = author,
                Pages = int.Parse(pages),
                Rating = 3
            };

            return book;
        }
    }
}
