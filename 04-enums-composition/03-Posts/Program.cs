using _03_Posts.Entities;

namespace _03_Posts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeland",
                "I'm goint to visit this wonderful country"
                );

            for(int i  = 0; i < 12; i++)
            {
                post1.LikePost();
            }

            Comment comment1 = new Comment("Have a nice trip");
            Comment comment2 = new Comment("Wow that's awesome!");

            post1.AddComment(comment1);
            post1.AddComment(comment2);


            Post post2 = new Post(
               DateTime.Parse("28/07/2018 23:14:19"),
               "Good night guys",
               "See you tomorrow"
               );

            for (int i = 0; i < 5; i++)
            {
                post2.LikePost();
            }

            Comment comment3 = new Comment("Good night");
            Comment comment4 = new Comment("May the Force be with you");

            post2.AddComment(comment3);
            post2.AddComment(comment4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}