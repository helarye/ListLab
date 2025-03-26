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
        lst = new Node<int>(-55, lst);
        Console.WriteLine(lst);
        Console.WriteLine(Whidth(lst, 9));
        Console.WriteLine(Whidth(lst, -1));
        Console.WriteLine(Whidth(lst, 22));
        Console.WriteLine(Longest(lst));
    }
    public static int Whidth(Node<int>lst,int num)
    {
        int SidraNegLength = -1;
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
    public static int Longest(Node<int> lst)
    {
        int SidraNegLengthCurr = -1;
        int SidraNegLengthLongest = -1;
        Node<int> CurrNode = lst;
        while (CurrNode != null)
        {
            SidraNegLengthCurr = Whidth(lst, CurrNode.GetValue());
            if (SidraNegLengthCurr > SidraNegLengthLongest)
            {
                SidraNegLengthLongest = SidraNegLengthCurr;
            }
            CurrNode = CurrNode.GetNext();
        }
        return SidraNegLengthLongest;
    }


}