Describe the bug
When I try to issue the dotnet ef dbcontext scaffold command, I get this error:

error MSB4006: There is a circular dependency in the target dependency graph involving target "GetEFProjectMetadata". [ ..path..\TestTemplateEF.csproj]
Unable to retrieve project metadata. Ensure it's an MSBuild-based .NET Core project. If you're using custom BaseIntermediateOutputPath or MSBuildProjectExtensionsPath values, Use the --msbuildprojectextensionspath option.

To Reproduce
Steps to reproduce the behavior:
Create an MVVM Light project with SQL data and just the main page -- no other options
go to the Package Manager Console and issue these commands:

cd {the .core directory}

dotnet ef dbcontext scaffold "Server={server name};Initial Catalog={dbname};Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models --startup-project={pathToMainProject}\TestTemplateEF20191108B -Verbose

System
VS Version: 2019
WinTS Version: 3.5.19310.1 -- fresh install
Windows Build: 18362.418