using System;
using Docker.DotNet;

namespace CkeckDocker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DockerClient client = new DockerClientConfiguration(new Uri("npipe://./pipe/docker_engine"))
                    .CreateClient();
            
        }
    }
}
