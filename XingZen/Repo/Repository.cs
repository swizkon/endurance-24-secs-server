
namespace XingZen.Repo
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using XingZen.Model;

    public class Repository
    {
        private static ConcurrentDictionary<Guid, Account> accounts 
        = new ConcurrentDictionary<Guid, Account>();

        public static void Add(Account account)
        {
            accounts.AddOrUpdate(account.Id, account, (key, obj) => account );
        }
 
        public static ICollection<Account> All()
        {
            return accounts.Values;
        }
    }
}