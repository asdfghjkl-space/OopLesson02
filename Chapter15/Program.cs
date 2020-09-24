using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15
{
    class Program
    {
        static void Main(string[] args)
        {
            #region try_catchの勉強
            //try
            //{
            //    int[] array = new int[2];
            //    array[2] = 10;

            //    var total = 1000;
            //    var line = Console.ReadLine();
            //    var count = int.Parse(line);
            //    var ans = total / count;
            //    Console.WriteLine(ans);
            //    Console.WriteLine("正常終了");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Type:{ex.GetType().Name}");
            //    Console.WriteLine($"Message:{ex.Message}");
            //    Console.WriteLine($"TargetSite:{ex.TargetSite}");
            //    Console.WriteLine($"StackTrace:{ex.StackTrace}");
            //}
            #endregion
            double height, weight;

            //BmiCalculatorの呼び出し
            BmiCalculator bmi = new BmiCalculator();
            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    //身長の入力
                    Console.Write("身長(cm):");
                    string line = Console.ReadLine();

                    if (double.TryParse(line, out height))
                    {
                        break;
                    }
                    //入力した文字列が正しくdouble型へ変換できなかった場合
                    Console.WriteLine("正しい値を入力してください。");
                }

                while (true)
                {
                    //体重の入力
                    Console.Write("体重(kg):");
                    string wt = Console.ReadLine();

                    if (double.TryParse(wt, out weight))
                    {
                        break;
                    }
                    //入力した文字列が正しくdouble型へ変換できなかった場合
                    Console.WriteLine("正しい値を入力してください。");
                }
                double bc = bmi.GetBmi(height, weight);
                Console.WriteLine($"BMIは{bc:F1}です。");   //F1は小数点第一まで出力する

            }


            //BMI計算結果
        }
    }
}
