
namespace Endurance.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using Model;

    public class Repository
    {
        private static ConcurrentDictionary<Guid, Circuit> circuits = new ConcurrentDictionary<Guid, Circuit>();

        public static void Add(Circuit circuit)
        {
            circuits.AddOrUpdate(circuit.CircuitId, circuit, (key, obj) => circuit );
        }

        public static ICollection<Circuit> All()
        {
            return circuits.Values;
        }
    }
}