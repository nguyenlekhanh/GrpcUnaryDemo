using Grpc.Net.Client;
using GrpcService;
using System.ComponentModel.DataAnnotations;

namespace GrpcClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //C:\khanh\vs\test\26\1\GrpcUnaryDemo\GrpcService\bin\Debug\net7.0
            //run service: GrpcService.exe and find the path
            var channel = GrpcChannel.ForAddress("http://localhost:5000");
            var client = new Sample.SampleClient(channel);
            //var response = client.GetFullName(new SampleRequest { FirstName="John" , LastName="Thomas"});
            var response = await client.GetFullNameAsync(new SampleRequest { FirstName = "John", LastName = "Thomas" });
            Console.WriteLine(response.FullName);
            Console.ReadLine();
        }
    }
}