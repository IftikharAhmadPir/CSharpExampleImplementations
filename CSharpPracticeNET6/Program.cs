using NETStandardClassLibrary;
using NETStandardClassLibrary.Models;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var abc = new SerializedModel()
{
    Id = 1,
    Name = "Iftikhar",
    Type = typeof(string)
};
BaseDirectory.justserialize(abc);