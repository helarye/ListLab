using ListLab;
namespace ListLab;
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Node<int> lst = new Node<int>(4);//יצירת חוליה ראשונה ששם הרשימה מצביע עליה
                                          //null בעת היצירה החוליה היחידה מצביעה על
        Console.WriteLine(lst);
        Node<int> CurrNode = new Node<int>(10,lst);//יצירת חוליה נוספת, שמוצבת לפני ליסט ומצביעה
                                                   //על החוליה הראשונה של ליסט
        lst = CurrNode;//גורמים למצביע ליסט להצביע על החוליה שהוספנו בתחילת הרשימה
        Console.WriteLine(lst);
        CurrNode = new Node<int>(9, lst);
        lst = CurrNode;
        CurrNode = new Node<int>(-2, lst);
        lst = CurrNode;
        CurrNode = new Node<int>(10, lst);
        lst = CurrNode;
        CurrNode = new Node<int>(22, lst);
        lst = CurrNode;
        CurrNode = new Node<int>(1, lst);
        lst = CurrNode;
        CurrNode = new Node<int>(-1, lst);
        lst = CurrNode;
        CurrNode = new Node<int>(-9, lst);
        lst = CurrNode;
        Console.WriteLine(lst);
        Console.WriteLine(Whidth(lst, 9));
        Console.WriteLine(Whidth(lst, -1));
        Console.WriteLine(Whidth(lst, 22));
    }
    public static int Whidth(Node<int>lst,int num)
    {
        int SidraNegLength = -1;
        Console.WriteLine(lst);
        int numLoc = 0;
        int revNumLoc = 0;
        bool numFound = false;
        bool revNumFound = false;
        Node<int> CurrNode = lst;//יוצרים מצביע על החוליה הראשונה של הרשימה
        while (CurrNode != null && !revNumFound)
        {
            if (CurrNode.GetValue() == -num)
            {
                revNumFound = true;
            }
            else
            {
                CurrNode = CurrNode.GetNext();
            }
            revNumLoc++;
        }
        
        CurrNode = lst;
        while (CurrNode != null && !numFound && revNumFound)
        {
            if (CurrNode.GetValue() == num)
            {
                numFound = true;
            }
            else
            {
                CurrNode = CurrNode.GetNext();
            }
            numLoc++;
        }
        if(revNumFound) SidraNegLength = Math.Abs(revNumLoc - numLoc)+1;
        return SidraNegLength;
    }


}