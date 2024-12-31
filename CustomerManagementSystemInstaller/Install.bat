SET ApplicationName=CustomerManagementSystemInstaller
:: $Configuraiton="Release"
:: $Platform="x64"

msiexec.exe /i %ApplicationName%.msi
:: /quiet /passive /norestart