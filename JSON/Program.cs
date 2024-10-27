using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string json = File.ReadAllText("C:\\Users\\Tylika\\source\\repos\\JSON\\JSON\\books.json", Encoding.UTF8);
        List<Book> books = JsonSerializer.Deserialize<List<Book>>(json);

        
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Name}, Publisher: {book.PublishingHouse.Name}, Adress: {book.PublishingHouse.Adress}\n");
        }
        var options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true
        };

        string serializedJson = JsonSerializer.Serialize(books, options);
        File.WriteAllText("C:\\Users\\Tylika\\source\\repos\\JSON\\JSON\\BooksUpdate.json", serializedJson);
        Console.WriteLine("\nBooks serialized and saved to BooksUpdate.json");
    }
}
