# SQL
Slipe offers a simple interface to deal with SQL databases. The `Database` class ([documentation](/api/server/Slipe.Sql.Database.html)) supports both MySQL and sqlite databases.

## Connecting to a database
Connecting to a database is done by creating an instance of the `Database` class.  
In order to make it easier to create a MySql connection string you can use the `MySqlConnectionString` class ([documentation](/api/server/Slipe.Sql.MySqlConnectionString.html))
```cs
// MySql
Database database = new Database(new MySqlConnectionString()
{
    Hostname = "127.0.0.1",
    Port = 3306,
    DbName = "test"
}, "user", "password", new SqlOptions()
{
    AutoReconnect = true
});
```
```cs
// sqlite
Database database = new Database("file.db", new SqlOptions());
```

## Running queries
### Insert
When running an insert query (or another query without a result), use the `Datbase.Exec()`. This method returns `void`.
```cs
Random random = new Random();
database.Exec("INSERT INTO `vector` (`x`, `y`, `z`) VALUES(?, ?, ?)", 10, 20, 30);
```

### Select
When you use a select query use the `Database.Query()` method, this method returns a `Task`, this is due to the asynchronous nature of MTA's `dbQuery` function. Instead of using a callback like you would in MTA you can use `async / await` in order to get the result without having your entire server hang.
```cs
var results = await database.Query("SELECT * FROM `vector`");
foreach(var row in results)
{
    Console.WriteLine("X: {0}, Y: {1}, Z: {2}", (int) row["x"], (int) row["y"], (int) row["z"]);
    int xResult = row["x"] + 10;
}
```

## Example
The following example calls the `DoSQL` method asynchronously. The `DoSQL` method establishes connection to a database and inserts one row into the `vector` table. Afterwards it outputs all entries in the `vector` table to the server console. 
```cs
public void RandomMethod()
{
    _ = Task.Run(DoSQL);
}

public async Task DoSql()
{
    Database database = new Database(new MySqlConnectionString()
    {
        Hostname = "127.0.0.1",
        Port = 3306,
        DbName = "test"
    }, "user", "password");

    Random random = new Random();
    database.Exec("INSERT INTO `vector` (`x`, `y`, `z`) VALUES(?, ?, ?)", 
        random.Next(0, 1000),
        random.Next(0, 1000),
        random.Next(0, 1000)
    );

    var results = await database.Query("SELECT * FROM `vector`");
    foreach(var row in results)
    {
        Console.WriteLine("X: {0}, Y: {1}, Z: {2}", (int) row["x"], (int) row["y"], (int) row["z"]);
    }
}
```