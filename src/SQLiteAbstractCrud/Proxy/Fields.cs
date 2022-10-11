using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SQLiteAbstractCrud.Proxy.Queries;

namespace SQLiteAbstractCrud.Proxy
{
    internal class Fields
    {
        public Fields(List<ProxyPropertyInfo> proxyPropertiesInfos)
        {
            foreach (var p in proxyPropertiesInfos)
            {
                var field = new Field(p.OriginalName, p.CSharpType, p.IsPrimaryKey, p.IsAutoIncrement);
                Items.Add(field);
            }
        }

        public List<Field> Items { get; } = new();

        public string GetPrimaryKeyName()
        {
            return Items.First(x => x.IsPrimaryKey).NameOnDb;
        }

        public IEnumerable<Field> GetPrimariesKeys()
        {
            return Items.Where(x => x.IsPrimaryKey);
        }

        public string GetQuotePrimaryKey()
        {
            return Items.First(x => x.IsPrimaryKey).Quote;
        }

        public string GetPrimaryKeyType()
        {
            return Items.First(x => x.IsPrimaryKey).TypeCSharp;
        }
    }
}