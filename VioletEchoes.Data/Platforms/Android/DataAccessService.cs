using Realms;
using VioletEchoes.Data.IServices;

namespace VioletEchoes.Data;

// All the code in this file is only included on Android.
public class DataAccessService : IDataAccessService
{
    public Task<Realm> GetDBAsync() => throw new NotImplementedException();
}
