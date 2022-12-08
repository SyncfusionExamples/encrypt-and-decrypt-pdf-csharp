using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrypt_PDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Load existing PDF document.
            PdfLoadedDocument document = new PdfLoadedDocument(@"../../Data/PDF_Succinctly.pdf", "user");

            //Create a document security.
            PdfSecurity security = document.Security;

            //Set permissions to default.
            security.Permissions = PdfPermissionsFlags.Default;
            //Set owner password.
            security.OwnerPassword = String.Empty;
            //Set user password.
            security.UserPassword = String.Empty;

            //Save the PDF document.
            document.Save("Output.pdf");
            //Close the PDF document.
            document.Close(true);
        }
    }
}
