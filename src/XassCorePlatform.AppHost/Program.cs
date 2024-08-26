var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.XassCorePlatform_AuthServer>("XassCorePlatform-authserver", launchProfileName: "XassCorePlatform.AuthServer");

builder.AddProject<Projects.XassCorePlatform_Administration_HttpApi_Host>("XassCorePlatform-administration-httpapi-host", launchProfileName: "XassCorePlatform.Administration.Host");

builder.AddProject<Projects.XassCorePlatform_IdentityService_HttpApi_Host>("XassCorePlatform-identityservice-httpapi-host", launchProfileName: "XassCorePlatform.IdentityService.Host");

builder.AddProject<Projects.XassCorePlatform_Projects_HttpApi_Host>("XassCorePlatform-projects-httpapi-host", launchProfileName: "XassCorePlatform.Projects.Host");

builder.AddProject<Projects.XassCorePlatform_SaaS_HttpApi_Host>("XassCorePlatform-saas-httpapi-host", launchProfileName: "XassCorePlatform.SaaS.Host");

builder.AddProject<Projects.XassCorePlatform_Gateway>("XassCorePlatform-gateway", launchProfileName: "XassCorePlatform.Gateway");

builder.AddProject<Projects.XassCorePlatform_Blazor_Server>("XassCorePlatform-blazor-server", launchProfileName: "XassCorePlatform.Blazor.Server");

builder.AddProject<Projects.XassCorePlatform_Blazor>("XassCorePlatform-blazor", launchProfileName: "XassCorePlatform.Blazor");

builder.Build().Run();
