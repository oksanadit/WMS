WMS
===

Test application for invoices management.
Invoices are stored in MSSQL database. All log events are stored in a separate table.

Lunch instruction
-----------------

1. Clone this repo
2. Run `nuget restore` or `dotnet restore` (or let your Visual Studio to run it automatically)
3. Run sql migration script on your MSSQL server [sql](./WMS/Doc/InitDB.sql)
4. Change connectionStrings in your App.config file.
5. Run application.