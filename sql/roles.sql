create role manager;
create role employee;

Grant Select, Delete, Update, Insert on database::CoffeeShop to employee;
go
Grant Exec, Select, Delete, Update, Insert on database::CoffeeShop to manager;
go
