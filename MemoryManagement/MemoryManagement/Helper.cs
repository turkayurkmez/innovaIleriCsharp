using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    public class Helper : IDisposable
    {

        private SqlConnection sqlConnection = new SqlConnection();
        private FileStream fileStream = null;

        public void SaveProductsToFile(string path)
        {
            fileStream = new FileStream(path, FileMode.OpenOrCreate);
            var array = Encoding.UTF8.GetBytes("deneme");
            fileStream.Write(array, 0, array.Length);
            fileStream.Close();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.Collect();

           

        }
        bool isDisposed = false;
        void Dispose(bool isDisposing)
        {
            if (!isDisposed)
            {
                if (isDisposing)
                {
                    this.fileStream.Dispose();
                    this.sqlConnection.Dispose();
                    GC.SuppressFinalize(this);
                }
            }
            isDisposed = true;
        }

        ~Helper()
        {
            Dispose(isDisposing: false);
        }
    }

}
