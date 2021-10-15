using System;

namespace SQLiteAbstractCrud.Tests.Teste3CamposStrStrDatetime
{
    public class Teste3CamposStrStrDatetime
    {
        [PrimaryKey]
        public string Foo { get; init; }
        public int Bar { get; init; }
        public DateTime Data { get; init; }

        public Teste3CamposStrStrDatetime(string foo, int bar, DateTime data)
        {
            Foo = foo;
            Bar = bar;
            Data = data;
        }
    }
}