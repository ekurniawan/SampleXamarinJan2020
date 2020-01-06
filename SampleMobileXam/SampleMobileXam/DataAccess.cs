using Plugin.NetStandardStorage.Abstractions.Interfaces;
using Plugin.NetStandardStorage.Implementations;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SampleMobileXam
{
    public class DataAccess
    {
        SQLiteConnection database;
        public SQLiteConnection GetConnection()
        {
            SQLiteConnection sqliteConnection;
            var sqliteFileName = "MyDb.db3";
            IFolder folder = new FileSystem().LocalStorage;
            string path = Path.Combine(folder.FullPath, sqliteFileName);
            sqliteConnection = new SQLiteConnection(path);
            return sqliteConnection;
        }

        public DataAccess()
        {
            database = GetConnection();
            database.CreateTable<Employee>();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return database.Query<Employee>("select * from Employee order by EmpName");
        }

        public int SaveEmployee(Employee employee)
        {
            return database.Insert(employee);
        }
        public int DeleteEmployee(Employee employee)
        {
            return database.Delete(employee);
        }

        public int EditEmployee(Employee employee)
        {
            return database.Update(employee);
        }
    }
}
