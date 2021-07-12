using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using DocumentFormat.OpenXml.Packaging;

namespace ParseWordDocument
{
    internal class Program
    {
        private static void Main()
        {
            using var wordDoc = WordprocessingDocument.Open(@"C:\temp\1.docx", false);
            if (wordDoc.MainDocumentPart == null) return;
            var body = wordDoc.MainDocumentPart.Document.Body;

            var serializer = new XmlSerializer(typeof(Body));

            if (body == null) return;
            using var reader = new StringReader(body.OuterXml);
            var bodySerialize = (Body)serializer.Deserialize(reader);

            foreach (var p in bodySerialize.P)
            {
                var text = p.R.Where(r => r.T != null).Aggregate("", (current, r) => current + r.T.Text);
                Console.WriteLine(text);
            }
        }
    }
}
