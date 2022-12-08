using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restrict_PDF_permissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Load existing PDF document.
            PdfLoadedDocument document = new PdfLoadedDocument(@"../../Data/PDF_Succinctly.pdf");

            //Create document security.
            PdfSecurity security = document.Security;

            //Set owner password for the document.
            security.OwnerPassword = "sample123";
            //Set encryption algorithm.
            security.Algorithm = PdfEncryptionAlgorithm.AES;
            //Set key size.
            security.KeySize = PdfEncryptionKeySize.Key256Bit;

            //Set various permissions for the PDF document.
            security.Permissions = PdfPermissionsFlags.Print |
            PdfPermissionsFlags.FillFields |
            PdfPermissionsFlags.CopyContent |
            PdfPermissionsFlags.FullQualityPrint;

            //Save the PDF document.
            document.Save("Output.pdf");
            //Close the PDF document.
            document.Close(true);
        }
    }
}
