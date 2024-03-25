

// db baglantı seçenekleri ornegi


using DesignPatterns.BridgePattern;

IDatabaseConnection myconnection = new MySqlConnection();
DatabaseClient mysqlClient = new CustomerClient(myconnection);
mysqlClient.GetData();

IDatabaseConnection posconnection = new PostgreSqlConnection();
DatabaseClient postgreClient = new CustomerClient(posconnection);
postgreClient.GetData();