using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    class Program
    {
        static void Main(string[] args)
        {
            #region リストの復習
            ////配列　string[] lines = new string[5];

            ////リストの初期化
            //var lines = new List<string>
            //{
            //    "おはよう",
            //    "こんにちは",
            //    "こんばんは"
            //};

            ////追加
            //lines.Add("おやすみ");
            //lines.Add("さようなら");

            ////削除
            //lines.RemoveAt(3);

            //foreach (var line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //lines.Clear();  //要素の全削除

            //Console.WriteLine($"リストの要素数は{lines.Count}です。");
            #endregion

            #region ラムダ式
            //var nums = new List<int> { 12, 56, 75, 8, 12, 95, 32, 85, 24, 48 };

            ////抽出
            //var query = nums.Where(x => x %2 == 0);
            //foreach (var n in query)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion

            #region ラムダ　文字
            //var words = new List<string>
            //{
            //    "effect","access","condition","sign","profit","line","result"
            //};

            //var query = words.Where(x => x.Length >= 4);

            //foreach (var word in query)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            var nums = new List<int> { 4, 6, 7, 1, 3, 9, 2, 5, 8 };
            //var query = nums.Select(x => x * 3).Where(y => y >= 20).Sum();
            //Console.WriteLine(query);
            //foreach (var num in query)
            //{
            //    Console.WriteLine(num);
            //}


            var books = new List<Book>();

            books.Add(new Book("人間失格", "太宰治", 212, 5));
            books.Add(new Book("女生徒", "太宰治", 279, 4));
            books.Add(new Book("吾輩は猫である", "夏目漱石", 610, 4));
            books.Add(new Book("こゝろ", "夏目漱石", 378, 5));
            books.Add(new Book("銀河鉄道の夜", "宮沢賢治", 357, 3));
            books.Add(new Book("伊豆の踊子", "川端康成", 201, 3));

            //var query = books.Where(x => x.Author == "夏目漱石");

            var query = books.OrderByDescending(x => x.Pages);

            foreach (var book in query)
            {
                Console.WriteLine($"{book.Title}{book.Author}{book.Pages}");
            }
        }
    }
}
