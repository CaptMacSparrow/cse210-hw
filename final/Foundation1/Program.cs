using System;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video();
        vid1._name = "Charlie Bit My Finger";
        vid1._author = "Charles A.";
        vid1._length = 220;

        Comment comm1 = new Comment();
        comm1._commentor = "Ed";
        comm1._text = "this isnt even funy";

        Comment comm2 = new Comment();
        comm2._commentor = "Edd";
        comm2._text = "charlie bites like a girl";

        Comment comm3 = new Comment();
        comm3._commentor = "Eddy";
        comm3._text = "Charlie 4 prez";

        vid1._comments.Add(comm1);
        vid1._comments.Add(comm2);
        vid1._comments.Add(comm3);


        Video vid2 = new Video();
        vid2._name = "Becky Bit My Finger";
        vid2._author = "Rebecca B.";
        vid2._length = 218;

        Comment comm11 = new Comment();
        comm11._commentor = "Ed";
        comm11._text = "this is not funy to";

        Comment comm22 = new Comment();
        comm22._commentor = "Edd";
        comm22._text = "Becky also bites like a girl";

        Comment comm33 = new Comment();
        comm33._commentor = "Eddy";
        comm33._text = "@Edd, Becky IS a girl";

        vid2._comments.Add(comm11);
        vid2._comments.Add(comm22);
        vid2._comments.Add(comm33);


        Video vid3 = new Video();
        vid3._name = "Charlie The Unicorn";
        vid3._author = "Jason S.";
        vid3._length = 226;

        Comment c1 = new Comment();
        c1._commentor = "Ed";
        c1._text = "this one is funy";

        Comment c2 = new Comment();
        c2._commentor = "Edd";
        c2._text = "What happened to Charlie?";

        Comment c3 = new Comment();
        c3._commentor = "Eddy";
        c3._text = "Charlie 4 Prez!!!";

        vid3._comments.Add(c1);
        vid3._comments.Add(c2);
        vid3._comments.Add(c3);

        
        vid1.Display();
        Console.WriteLine($"Number of comments: {vid1.GetCommentsNumber()}");
        vid2.Display();
        Console.WriteLine($"Number of comments: {vid2.GetCommentsNumber()}");
        vid3.Display();
        Console.WriteLine($"Number of comments: {vid3.GetCommentsNumber()}");

    }
}