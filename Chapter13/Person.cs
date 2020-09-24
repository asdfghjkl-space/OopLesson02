// ■リスト13-2：基底クラスの定義
using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
        get { return LastName + FirstName; }
    }
    public string Email { get; set; }
    public DateTime Birthday { get; set; }

    //派生クラスでオーバーライドできる
    public virtual void Print()
    {
        Console.WriteLine($"名前 : {FullName}({Email})");
    }
}
