// System is included by default because of <ImplicitUsings>enable</ImplicitUsings> in project file
Console.WriteLine(Math.Cos(Math.PI));

// System.Text.RegularExpressions is included in the project file
Console.WriteLine(Regex.Match("Hello, 2022!", @"\d{4}").Value);

// System.Net.Http is disabled in the project file
System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

// System.Numerics namespace is included in GlboalUsings.cs file
Console.WriteLine(new Matrix3x2(1,2,3,4,5,6).GetDeterminant());

/*
The default namespaces:

Microsoft.NET.Sdk
    System
    System.Collections.Generic
    System.IO
    System.Linq
    System.Net.Http
    System.Threading
    System.Threading.Tasks

Microsoft.NET.Sdk.Web
    Microsoft.NET.Sdk namespaces
    System.Net.Http.Json
    Microsoft.AspNetCore.Builder
    Microsoft.AspNetCore.Hosting
    Microsoft.AspNetCore.Http
    Microsoft.AspNetCore.Routing
    Microsoft.Extensions.Configuration
    Microsoft.Extensions.DependencyInjection
    Microsoft.Extensions.Hosting
    Microsoft.Extensions.Logging

Microsoft.NET.Sdk.Worker
    Microsoft.NET.Sdk namespaces
    Microsoft.Extensions.Configuration
    Microsoft.Extensions.DependencyInjection
    Microsoft.Extensions.Hosting
    Microsoft.Extensions.Logging

Microsoft.NET.Sdk.WindowsDesktop (Windows Forms)
    Microsoft.NET.Sdk namespaces
    System.Drawing
    System.Windows.Forms

Microsoft.NET.Sdk.WindowsDesktop (WPF)
    Microsoft.NET.Sdk namespaces
    Removed System.IO
    Removed System.Net.Http
*/
