using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using PhotoMadness.MVVM.Models;

namespace PhotoMadness.Repositories
{
    public class RoleRepository
    {
        SQLiteConnection connection;
        public string? statusMessage { get; set; }

        public RoleRepository()
        {
            connection = new SQLiteConnection(
                Constants.DBPath,
                Constants.flags);
            connection.CreateTable<Role>();
        }

        public void AddOrUpdateRole(Role newRole)
        {
            int result = 0;
            try
            {
                if (newRole.Id != 0)
                {
                    result = connection.Update(newRole);
                    statusMessage = $"{result} row(s) updated.";
                }
                else
                {
                    result = connection.Insert(newRole);
                    statusMessage = $"{result} row(s) added.";
                }

            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }

        public void DeleteRole(int roleId)
        {
            try
            {
                Role role = Get(roleId);
                connection.Delete(role);
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }

        public List<Role>? GetAll()
        {
            try
            {
                return connection.Table<Role>().ToList();
            }
            catch (Exception ex) 
            {
                statusMessage = $"Error: {ex.Message}";
            }
            return null;
        }
        public Role? Get(int id)
        {
            try
            {
                return connection.Table<Role>().FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
            return null;
        }
    }
}
