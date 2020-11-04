# BitcoinLogger
This is a web platform that fetches Bitcoin price (BTC/USD) from multiple sources and presents them to the user.

In order to run this project on your computer you need to have installed Visual Studio (Community) and Microsoft SQL Server Managment Studio.

https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2019
https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15


	1. Open BitcoinLogger.sln

	2. Install all packages
	Go to Tools > NuGet Package Manager and select Manage NuGet Packages for Soloution
	You will see an alert "Some NuGet packages are missing from this soloution. Click restore from your online packages sources."
	Please click right on 'Restore' button

	3. Update connectionstring 
	Go to BitconLogger.Database > App.config and update the connection string (in line 19 replace 'YOURDATASOURCE' with yours)
	Go to BitconLogger.Web and repeat the same action.         >>                                  >>

	4. Update Database
	Set BitcoinLogger.Database as startup project (Right click on project > Set as startup project)
	Open Package Manager Console (Tools > NuGet Package Manager > Package Manager Console) , set as Default project BitcoinLogger.Database, and then 
	run update-database command. 

	5. Launch application
	Set  BitcoinLogger.Web as startup project (Right click on project > Set as startup project) and run ISS Express
