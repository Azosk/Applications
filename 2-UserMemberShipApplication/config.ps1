$tools = "dotnet-aspnet-codegenerator", "dotnet-ef"
$packages = "Microsoft.EntityFrameworkCore.Tools", "Microsoft.EntityFrameworkCore.Design",
"Microsoft.EntityFrameworkCore.SQLite", "Microsoft.VisualStudio.Web.CodeGeneration.Design",
"Microsoft.EntityFrameworkCore.SqlServer"

foreach ($tool in $tools) {
    dotnet tool uninstall --global $tool
    dotnet tool install --global $tool
}

foreach ($package in $packages) {
    dotnet add package $package
}

dotnet restore