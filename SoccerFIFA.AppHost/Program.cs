var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("sql")
    .AddDatabase("sqldata");

var api = builder.AddProject<Projects.WebApiFIFA>("backend")
    .WithReference(sql);

builder.AddProject<Projects.BlazorFIFA>("frontend")
    .WithReference(api);

builder.Build().Run();
