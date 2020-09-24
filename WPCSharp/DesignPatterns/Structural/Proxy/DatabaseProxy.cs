using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Proxy
{
    public class DatabaseProxy : IDatabase
    {
        public const int NumberOfConnections = 5;
        private IDatabase _database;
        private SemaphoreSlim _semaphore = new SemaphoreSlim(NumberOfConnections);

        public DatabaseProxy()
        {
        }

        public DatabaseProxy(IDatabase database)
        {
            _database = database;
        }

        public async Task<int?> RequestAsync(int parameter)
        {
            if (_database == null)
            {
                Console.WriteLine("New database connection");
                _database = new Database();
            }

            await _semaphore.WaitAsync();
            var result = await _database.RequestAsync(parameter);
            _semaphore.Release();

            if(_semaphore.CurrentCount == NumberOfConnections)
            {
                _database = null;
                Console.WriteLine("Zamknięcie połączenia");
            }

            return result;
        }
    }
}
