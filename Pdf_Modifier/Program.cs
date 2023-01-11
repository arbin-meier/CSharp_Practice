using iText.Forms;
using iText.Forms.Fields;
using iText.Kernel.Pdf;
using iText.Kernel.Geom;
using System.Diagnostics;

string ORIG = "Sample.pdf";
string ModifiedFilePath = "Modified.pdf";
string ProtectedFilePath = "Protected.pdf";
string UnlockedFilePath = "Unlocked.pdf";
byte[] USERPASS = System.Text.Encoding.Default.GetBytes("user");
byte[] OWNERPASS = System.Text.Encoding.Default.GetBytes("owner");

void Create_NewPdf()
{
    PdfDocument pdfDoc = new PdfDocument(new PdfWriter(ORIG));
    PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);
    PdfTextFormField startField = PdfFormField.CreateText(pdfDoc, new Rectangle(99, 730, 425, 15), "startField", "This is a start field.");
    form.AddField(startField);
    pdfDoc.Close();
}

void Modify_Pdf()
{
    PdfDocument doc = new PdfDocument(new PdfReader(new FileInfo(ORIG)), new PdfWriter(new FileInfo(ModifiedFilePath)));
    PdfAcroForm form = PdfAcroForm.GetAcroForm(doc, true);
    PdfTextFormField nameField = PdfFormField.CreateText(doc, new Rectangle(99, 700, 425, 15), "newField", "This is a new field");
    form.AddField(nameField);
    doc.Close();
}


void Protect_PdfFile()
{
    PdfReader pdfReader = new PdfReader(ORIG);
    WriterProperties writerProperites = new WriterProperties();
    writerProperites.SetStandardEncryption(USERPASS, OWNERPASS, EncryptionConstants.ALLOW_PRINTING, EncryptionConstants.ENCRYPTION_AES_128);
    PdfWriter pdfWriter = new PdfWriter(new FileStream(ProtectedFilePath, FileMode.Create), writerProperites);
    PdfDocument pdfDocument = new PdfDocument(pdfReader, pdfWriter);
    pdfDocument.Close();
}

void Crack_PdfFile()
{
    ReaderProperties readerProperties = new ReaderProperties().SetPassword(OWNERPASS);
    PdfReader pdfReader = new PdfReader(ProtectedFilePath, readerProperties);
    PdfDocument pdfDocument = new PdfDocument(pdfReader, new PdfWriter(UnlockedFilePath));
    pdfDocument.Close();
}

Create_NewPdf();
Modify_Pdf();
Protect_PdfFile();
Crack_PdfFile();

string workingDirectory = Environment.CurrentDirectory;
Process process = Process.Start("explorer.exe", string.Format("/select,\"{0}\"\\\"{1}\"", workingDirectory, UnlockedFilePath)); ;