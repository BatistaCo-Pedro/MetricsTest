var builder = DistributedApplication.CreateBuilder(args);

var servicesProject = builder.AddProject<Projects.Services>("services");
builder.AddProject<Projects.Caller1>("Caller1").WithReference(servicesProject).WaitFor(servicesProject);
builder.AddProject<Projects.Caller2>("Caller2").WithReference(servicesProject).WaitFor(servicesProject);

builder.Build().Run();