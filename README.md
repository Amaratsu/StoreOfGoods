# StoreOfGoods Run
To start the project, you need to clone the repository https://github.com/Amaratsu/StoreOfGoods.git.

Change the connection string: WebUI->Web.Config:

add name="EfDbContext" connectionString="Data Source=Replace with your server name;
Initial Catalog=StoreOfGodsDB;Integrated Security=True" providerName="System.Data.SqlClient". 

The database will generate itself, register to add a new product, as it will not be possible to add an authorization.
