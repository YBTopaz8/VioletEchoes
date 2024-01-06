using Realms;
using System.Diagnostics;
using VioletEchoes.Data.IServices;

namespace VioletEchoes.Data;

// All the code in this file is only included on Windows.
public class DataAccessService : IDataAccessService
{
    Realm db;
    string pathToDBFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"VioletEchoes\VioletEchoes.realm");
    
    public async Task<Realm> GetDBAsync()
    {
        var config = new RealmConfiguration(pathToDBFile);
        db = await Realm.GetInstanceAsync(config);
        return db;
    }

    public void DeleteDB()
    {
        if (File.Exists(pathToDBFile))
        {
            try
            {
                File.Delete(pathToDBFile);
                Debug.WriteLine("DB Deleted");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
