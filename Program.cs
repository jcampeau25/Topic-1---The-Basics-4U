namespace Topic_1___The_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string aFriend = "Bill";

            Console.WriteLine(aFriend);

            aFriend = "Maira";
            Console.WriteLine(aFriend);

            Console.WriteLine("Hello " + aFriend);

            Console.WriteLine($"Hello {aFriend}");

            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");



            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");



            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);


            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());


            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));
            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));

            // assignment
            Console.WriteLine();
            Console.WriteLine("Assignment");
            Console.WriteLine("~~~~~~~~~~~~~~~");

            // Part 1

            string firstName = ("Josh");
            string favMovie = ("The Matrix");

            Console.WriteLine("hello " + firstName.ToLower() + " welcome to " + favMovie.ToLower());

            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);

            Console.WriteLine(favMovie.Contains("THE"));
            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);

            // Part 2

            Console.WriteLine();
            string quote = ("Our deepest fear is not that we are inadequate, our deepest fear is that we are powerful beyond measure");

            quote = quote.ToUpper();

            quote = quote.Replace("A", "");
            quote = quote.Replace("E", "");
            quote = quote.Replace("I", "");
            quote = quote.Replace("O", "");
            quote = quote.Replace("U", "");

            Console.WriteLine(quote);






            Console.WriteLine("                             _ _               ");
            Console.Write(" |\\/\\/\\/|          ");
            Console.WriteLine("     _(,_/ \\ \\____________  ");
            Console.Write(" |      |          ");
            Console.WriteLine("     |`. \\_@_@   `.     ,'  ");
            Console.Write(" |      |          ");
            Console.WriteLine("     |\\ \\ .        `-,-'    ");
            Console.Write(" | (o)(o)          ");
            Console.WriteLine("     || |  `-.____,-'       ");
            Console.Write(" C      _)         ");
            Console.WriteLine("     || /  /                ");
            Console.Write("  | ,___ |         ");
            Console.WriteLine("     |/ |  |                ");
            Console.Write("  |   /            ");
            Console.WriteLine("`..     /   \\               ");
            Console.Write(" / ____\\           ");
            Console.WriteLine("  \\\\   /    |                ");
            Console.Write("/       \\          ");
            Console.WriteLine("  ||  |      \\              ");

            Console.WriteLine("                      \\\\ /-.    |               ");

            Console.WriteLine("                      ||/  /_   |              ");

            Console.WriteLine("                      \\(_____)-'_))            ");































        }
    }
}
