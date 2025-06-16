using SQLite;
namespace Taskuro.Data
{
    public class Database
    {
        static string DataBasePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Taskuro.db";
        static SQLiteAsyncConnection db;
        static async void InitializeDatabase()
        {
            if(db != null)
                return;
            else
               db = new SQLiteAsyncConnection(DataBasePath);

            await db.CreateTableAsync<Models.Task>();
        }
    }
}
