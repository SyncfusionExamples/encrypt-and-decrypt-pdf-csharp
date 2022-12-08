using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_PDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Load existing PDF document.
            PdfLoadedDocument document = new PdfLoadedDocument(@"../../Data/PDF_Succinctly.pdf");

            //Create a document security.
            PdfSecurity security = document.Security;

            //Set user password for the document.
            security.UserPassword = "sample123";
            //Set encryption algorithm.
            security.Algorithm = PdfEncryptionAlgorithm.AES;
            //Set key size.
            security.KeySize = PdfEncryptionKeySize.Key256Bit;

            //Save the PDF document.
            document.Save("Output.pdf");
            //Close the PDF document.
            document.Close(true);
        }
    }
}
