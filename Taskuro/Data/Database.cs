using SQLite;
using Taskuro.Models;
namespace Taskuro.Data
{
    public class Database
    {
        static string DataBasePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Taskuro.db";
        static SQLiteAsyncConnection db;
        static async Task InitializeDatabase()
        {
            if(db != null)
                return;
            else
               db = new SQLiteAsyncConnection(DataBasePath);

            await db.CreateTableAsync<Tasks>();
        }
        static public async Task addTask(Tasks task)
        {
            await InitializeDatabase();
            await db.InsertAsync(task);
        }
        static public async Task<List<Tasks>> getTasksAsync()
        {
            await InitializeDatabase();
            return await db.Table<Tasks>().ToListAsync();
        }
        static public async Task<Tasks> getTaskByIDAsync(int id)
        {
            await InitializeDatabase();
            return await db.Table<Tasks>().Where(t => t.Id == id).FirstOrDefaultAsync();
        }
        static public async Task updateTask(Tasks task)
        {
            await InitializeDatabase();
            await db.UpdateAsync(task);
        }
    }
}
