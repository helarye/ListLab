using ListLab;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Node<int> list = new Node<int>(5);//יצירת חוליה ראשונה ששם הרשימה מצביע עליה
                                          //null בעת היצירה החוליה היחידה מצביעה על
        Console.WriteLine(list);
        Node<int> CurrNode = new Node<int>(7,list);//יצירת חוליה נוספת, שמוצבת לפני ליסט ומצביעה
                                                   //על החוליה הראשונה של ליסט
        list = CurrNode;//גורמים למצביע ליסט להצביע על החוליה שהוספנו בתחילת הרשימה
        Console.WriteLine(list);
    }
    

}