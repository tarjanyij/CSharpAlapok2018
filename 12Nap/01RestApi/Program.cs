using RestSharp;
using System;
using System.Collections.Generic;

namespace _01RestApi
{
    class Program
    {
        static void Main(string[] args)
        {

            var baseUri = "http://jsonplaceholder.typecode.com";

            var client = new RestClient(baseUri);

            var request = new RestRequest("/post/{id}", Method.GET);

            request.AddUrlSegment("id", 1);

            //parameter ha az ?name=valami hez kell
            // request.AddParameter("id",1);
            
            var post = client.Execute<Post>(request);
                                 
            Console.WriteLine($"userId:{post.Data.userId}, Id : {post.Data.id}, title :{post.Data.title}, body :{post.Data.body}");


            request = new RestRequest("/post", Method.GET);
            var posts = client.Execute<List<Post>>(request);

            Console.WriteLine($"listCount: {posts.Data.Count}");
            Console.ReadLine();
            ;
        }

    }


    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }

}
