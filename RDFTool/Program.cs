using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDS.RDF;

namespace RDFTool
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/dotnetrdf/dotnetrdf/wiki/UserGuide-Reading-RDF
            IGraph g = new Graph();
            using (var client = new System.Net.WebClient())
            {
                var rdfText = client.DownloadString("http://localhost/w/index.php/Special:ExportRDF/Walmart");
                g.LoadFromString(rdfText);
            }
            Console.WriteLine($"Hi there, I've got {g.Triples.Count} triples");
            //TurtleParser tp = new TurtleParser();
            //tp.Load(g, )
        }
    }
}
