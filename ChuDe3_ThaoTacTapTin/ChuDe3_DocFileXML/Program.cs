using System;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuDe3_DocFileXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            #region Phần đọc file XML
            /*var xmlDoc = new XmlDocument();
            xmlDoc.Load("book1.xml");
            var nodeList = xmlDoc.DocumentElement.SelectNodes("/catalog/book");

            foreach (XmlNode node in nodeList)
            {
                var isbn = node.Attributes["ISBN"].Value;
                var title = node.SelectSingleNode("title").InnerText;
                var price = node.SelectSingleNode("price").InnerText;
                var firstName = node.SelectSingleNode("author/first-name").InnerText;
                var lastName = node.SelectSingleNode("author/last-name").InnerText;
                Console.WriteLine("{0,-15}{1,-50}{2,-15}{3,-15}{4,6}",
                                  isbn, title, firstName, lastName, price);
            }*/
            Console.ReadKey();
            #endregion
            #region Phần ghi file XML
            using (XmlWriter writer = XmlWriter.Create("book2.xml"))
            {
                string pi = "type=\"text/xsl\" href=\"book.xsl\"";
                writer.WriteProcessingInstruction("xml-stylesheet", pi);
                writer.WriteDocType("catalog", null, null, "<!ENTITY h \"hardcover\">");
                writer.WriteComment("This is a book sample XML");
                writer.WriteStartElement("book");
                writer.WriteAttributeString("ISBN", "9831123212");
                writer.WriteAttributeString("yearpublished", "2002");
                writer.WriteElementString("author", "Mahesh Chand");
                writer.WriteElementString("title", "Visual C# Programming");
                writer.WriteElementString("price", "44.95");
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
            #endregion
        }
    }
}
