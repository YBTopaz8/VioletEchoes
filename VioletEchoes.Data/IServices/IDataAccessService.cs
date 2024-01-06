using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VioletEchoes.Data.IServices;
public interface IDataAccessService
{
    Task<Realm> GetDBAsync();
}
