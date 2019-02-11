using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace TimesheetCompleter
{
    public static class PdfProcessor
    {
        public static void GenerateAndSavePDF(string filePath,string mon,string tues,string weds,string thurs,string fri,string weekDate,string todayDate)
        {
            // Assign where to save the file here
            // You can also impliment something else and pass along the string file path
            string newFile = @"C:\Users\SOMEONE_IMPORTANT\" + $"{DateTime.Today.ToString("MM-dd-yyyy")}.pdf";

            // open the reader
            PdfReader reader = new PdfReader(filePath);
            Rectangle size = reader.GetPageSizeWithRotation(1);
            Document document = new Document(size);

            // open the writer
            FileStream fs = new FileStream(newFile, FileMode.Create, FileAccess.Write);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            // the pdf content
            PdfContentByte cb = writer.DirectContent;

            // select the font properties
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetColorFill(BaseColor.DARK_GRAY);
            cb.SetFontAndSize(bf, 8);

            // Week ending date is this code block
            cb.BeginText();
            string text = Form1.monDate.ToString("MM/dd");
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 148, 365, 0);
            cb.EndText();
            cb.BeginText();
            text = weekDate;
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 274, 478, 0);
            cb.EndText();
            cb.BeginText();
            text = Form1.tuesDate.ToString("MM/dd");
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 148, 345, 0);
            cb.EndText();
            cb.BeginText();
            text = Form1.wedsDate.ToString("MM/dd");
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 148, 320, 0);
            cb.EndText();
            cb.BeginText();
            text = Form1.thurDate.ToString("MM/dd");
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 148, 298, 0);
            cb.EndText();
            cb.BeginText();
            text = Form1.friDate.ToString("MM/dd");
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 148, 273, 0);
            cb.EndText();
            cb.BeginText();
            text = Form1.totalHours.ToString();
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 448, 221, 0);
            cb.EndText();
            cb.BeginText();
            text = todayDate;
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 440, 182, 0);
            cb.EndText();


            // Regular Hours Code
            cb.BeginText();
            text = mon;
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 405, 365, 0);
            cb.EndText();
            cb.BeginText();
            text = tues;
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 405, 345, 0);
            cb.EndText();
            cb.BeginText();
            text = weds;
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 405, 320, 0);
            cb.EndText();
            cb.BeginText();
            text = thurs;
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 405, 298, 0);
            cb.EndText();
            cb.BeginText();
            text = fri;
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 405, 273, 0);
            cb.EndText();

            // create the new page and add it to the pdf
            PdfImportedPage page = writer.GetImportedPage(reader, 1);
            cb.AddTemplate(page, 0, 0);

            // close the stream and boom goes the dynamite
            document.Close();
            fs.Close();
            writer.Close();
            reader.Close();
        }
    }
}
