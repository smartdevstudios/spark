﻿using System.Collections.Generic;
using Spark.Engine.Core;

namespace Spark.Engine.Interfaces
{
    public interface IBaseFhirStore : IExtensibleObject<IFhirStoreExtension>
    {
        void Add(Entry entry);
        //void Add(IEnumerable<Entry> entries);
        Entry Get(IKey key);
        IList<Entry> Get(IEnumerable<string> identifiers, string sortby);

        //void Replace(Entry entry);
        //should these be here?
        //Snapshot Get(string snapshotkey);
        //void Add(Snapshot snapshot);

        IList<Entry> GetCurrent(IEnumerable<string> localIdentifiers, string sortby);
    }
}