// See https://aka.ms/new-console-template for more information

using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using SqliteBatchDelete;

Console.WriteLine("Started!");

var context = new MyDbContext();
await context.Database.EnsureDeletedAsync();
await context.Database.MigrateAsync();

await context.AddAsync(new MyEntity { MyUintId = 5 });
await context.SaveChangesAsync();

Console.WriteLine("Trying batch delete!");
uint myId = 5;
await context.MyDbSet.Where(x => x.MyUintId == myId).BatchDeleteAsync();
