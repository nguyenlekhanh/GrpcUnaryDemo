using Grpc.Core;

namespace GrpcService.Services
{
    //sample.samplebase get from Protos/Sample.proto line Service Sample
    public class SampleService : Sample.SampleBase
    {
        public override Task<SampleResponse> GetFullName(SampleRequest request, ServerCallContext context)
        {
            var result = $"{request.FirstName} {request.LastName}";
            return Task.FromResult(new SampleResponse { FullName = result });
        }
    }
}
