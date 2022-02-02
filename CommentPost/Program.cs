using CommentPost.Entities;
using System;
using System.Collections.Generic;

namespace CommentPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeland",
                "I'm going to visit this wonderful country!",
                21
                );
            p1.AddComment(c1);
            p1.AddComment(c2);
        }
    }
}
