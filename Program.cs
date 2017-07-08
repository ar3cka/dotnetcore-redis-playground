using System;
using StackExchange.Redis;

namespace dotnetcore_redis_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = ConnectionMultiplexer.Connect("0.0.0.0");
            var database = connection.GetDatabase();
            
            database.StringSet("greeting", "Hello World!");
            Console.WriteLine(database.StringGet("greeting"));
        }
    }
}
