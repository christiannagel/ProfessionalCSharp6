using System;
using System.Threading.Tasks;
using static System.Console;

namespace QueueSample
{
  class Program
  {
    static void Main()
    {
      var dm = new DocumentManager();

      ProcessDocuments.StartAsync(dm);

      // Create documents and add them to the DocumentManager
      for (int i = 0; i < 1000; i++)
      {
        var doc = new Document($"Doc {i}", "content");
        dm.AddDocument(doc);
        WriteLine($"Added document {doc.Title}");
        Task.Delay(new Random().Next(20)).Wait();
      }

      ReadLine();
    }
  }
}
