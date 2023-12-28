using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemStoreOriginal.Shared
{
    internal class EFCoreStoreDB : DbContext
    {

       // C:\Training\Labs\Blazor\ItemStoreOriginal\ItemStoreOriginal.Shared>dotnet ef dbcontext scaffold "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Store;Integrated Security=True;Connect Timeout=10;Encrypt=True;Trust Server Certificate=True;" Microsoft.EntityFrameworkCore.SqlServer --table Item --output-dir Models --namespace ItemStoreOriginal.Shared.Models --data-annotations --context EFCoreStoreDB
        
        
        
        
        
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = Store; Integrated Security = True; Connect Timeout = 3; Encrypt=True;Trust Server Certificate=Ture;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
