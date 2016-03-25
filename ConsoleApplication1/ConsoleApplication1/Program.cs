using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApplication2
{
    public class RootObject
    {
        [JsonProperty("glossary")]
        public Glossary Glossary { get; set; }
    }
    public class Glossary
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("GlossDiv")]
        public GlossDiv GlossDiv { get; set; }
    }
    public class GlossDiv
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("GlossList")]
        public GlossList GlossList { get; set; }
    }
    public class GlossList
    {
        [JsonProperty("GlossEntry")]
        public GlossEntry GlossEntry { get; set; }
    }
    public class GlossEntry
    {
        [JsonProperty("ID")]
        public string ID { get; set; }
        [JsonProperty("SortAs")]
        public string SortAs { get; set; }
        [JsonProperty("GlossTerm")]
        public string GlossTerm { get; set; }
        [JsonProperty("Acronym")]
        public string Acronym { get; set; }
        [JsonProperty("Abbrev")]
        public string Abbrev { get; set; }
        [JsonProperty("GlossDef")]
        public GlossDef GlossDef { get; set; }
        [JsonProperty("GlossSee")]
        public string GlossSee { get; set; }
    }
    public class GlossDef
    {
        [JsonProperty("para")]
        public string Para { get; set; }
        [JsonProperty("GlossSeeAlso")]
        public List<string> GlossSeeAlso { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            JsonSerializer js = new JsonSerializer();
            StreamReader reader = new StreamReader(@"C:\Users\Robert\Desktop\ConsoleApplication2\ConsoleApplication2\json1.json");
            string json= reader.ReadToEnd();
            RootObject r = JsonConvert.DeserializeObject<RootObject>(json);
            Console.WriteLine(r.Glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);

            ClassXML mojXml = new ClassXML();
            catalog kat= mojXml.Deserialize(File.OpenRead(@"C:\Users\Robert\Desktop\ConsoleApplication2\ConsoleApplication2\XMLFile1.xml"));
            foreach(var book in kat.book)
            {
                Console.WriteLine(book.title + " "+book.author+" "+book.price.ToString());

                
            }
            //ClassXML soapEncode = new ClassXML();
            //GetStockPrice price = soapEncode.DeserializeSOAP(File.OpenRead(@"C:\Users\Robert\Desktop\ConsoleApplication2\ConsoleApplication2\XMLFile2.xml"));
            //Console.WriteLine(price.StockName);

            
            Console.ReadLine();
        }
    }
}
