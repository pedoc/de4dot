$ErrorActionPreference = 'Stop'

msbuild -v:m -restore -t:Build -p:Configuration=Release -p:TargetFramework=net45 de4dot.netframework.sln
if ($LASTEXITCODE) { exit $LASTEXITCODE }
Remove-Item Release\net45\*.pdb, Release\net45\*.xml, Release\net45\Test.Rename.*

dotnet publish -c Release -f netcoreapp3.1 -o publish-netcoreapp3.1 de4dot
if ($LASTEXITCODE) { exit $LASTEXITCODE }
Remove-Item publish-netcoreapp3.1\*.pdb, publish-netcoreapp3.1\*.xml
