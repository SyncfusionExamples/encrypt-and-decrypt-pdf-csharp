using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_encrption_options
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Load existing PDF document.
            PdfLoadedDocument document = new PdfLoadedDocument(@"../../Data/PDF_Succinctly.pdf");

            //Create a document security.
            PdfSecurity security = document.Security;

            //Set owner password.
            security.OwnerPassword = "sample123";
            //Set user password.
            security.UserPassword = "user";

            //Set encryption algorithm.
            security.Algorithm = PdfEncryptionAlgorithm.AES;
            //Set key size
            security.KeySize = PdfEncryptionKeySize.Key256Bit;

            //Set various permissions for the PDF document.
            security.Permissions = PdfPermissionsFlags.Print |
            PdfPermissionsFlags.FillFields |
            PdfPermissionsFlags.CopyContent |
            PdfPermissionsFlags.FullQualityPrint;

            //Encrypt all the content except metadata.
            security.EncryptionOptions = PdfEncryptionOptions.EncryptAllContentsExceptMetadata;

            //Save the PDF document.
            document.Save("Output.pdf");
            //Close the PDF document.
            document.Close(true);
        }
    }
}
