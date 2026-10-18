var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.USS_ProjectTemplate_Web_ApiService>("usskanakkedu")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.USS_ProjectTemplate_Web_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
