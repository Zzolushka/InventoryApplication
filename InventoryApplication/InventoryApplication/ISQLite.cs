using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryApplication
{
    public interface ISQLite
    { 
        string GetDatabasePath(string filename);
    }
}
