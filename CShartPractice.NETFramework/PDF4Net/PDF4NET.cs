using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using O2S.Components.PDFRender4NET.Printing;
//using O2S.Components.PDFRender4NET.WPF;

//using IronPdf;
using System.Drawing;
using O2S.Components.PDFView4NET;
//using IronPdf;
//using O2S.Components.PDF4NET;


//using O2S.Components.PDFView4NET;

namespace CShartPractice
{
    public static class PDF4NET
    {
        //public static void DoPrint()
        //{
        //    var printThread = new Thread(() =>
        //    {
        //        try
        //        {
        //            string PrintQueueName = "";

        //            byte[] Data = File.ReadAllBytes(@"D:\IronPDFLibrary\PDF\pngtopdf.pdf");
        //            //PrintServer printServer = new PrintServer();

        //            //PrintQueue printQueue = printServer.GetPrintQueue();
        //            LocalPrintServer printServer = new LocalPrintServer();
        //            PrintQueue printQueue = printServer.DefaultPrintQueue;

        //            PDFPrintSettings pdfPrintSettings = new PDFPrintSettings(printQueue);
        //            printQueue.DefaultPrintTicket.CopyCount = 1;

        //            using (var stream = new MemoryStream(Data))
        //            {
        //                using (var PDF = PDFFile.Open(stream))
        //                {
        //                    PDF.Print(pdfPrintSettings);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            var abc = ex;
        //        }
        //    });

        //    printThread.SetApartmentState(ApartmentState.STA);
        //    printThread.Start();
        //    printThread.Join();
        //}

        //public static void checkPrintServer()
        //{
        //    //var printServer = new LocalPrintServer();
        //    //PrintQueue printQueue = printServer.GetPrintQueue("TestPrinterForPDF");
        //    //printQueue.DefaultPrintTicket.CopyCount = 1;

        //    byte[] file = File.ReadAllBytes(@"D:\IronPDFLibrary\PDF\PDFToJPG.pdf");
        //    var pdfDocument = new PdfDocument(file);
        //    pdfDocument.Print("TestPrinterForPDF");
        //}

        //public static string __ToTiff()
        //{
        //    var Results = "";
        //    var printThread = new Thread(() =>
        //    {
        //        byte[] PDFDocArray = File.ReadAllBytes(@"D:\IronPDFLibrary\PDF\PDFToJPG.pdf");
        //        using (var stream = new MemoryStream(PDFDocArray))
        //        {

        //            var PDF = PDFFile.Open(stream);

        //            using (var ResultStream = PDF.GetPageImagesAsMultipageTiff(100))
        //            {
        //                //using(var PDFA = new PdfDocument(ResultStream))
        //                //{
        //                //    PDFA.Print();
        //                //}
        //                Image img = Image.FromStream(ResultStream);
        //                var abc = IronPdf.ImageToPdfConverter.ImageToPdf(img);
        //                abc.Print();

        //                //ResultStream.Flush();
        //                //var abc = ResultStream.ToArray();
        //                //var convcettestring = Convert.ToBase64String(abc);
        //                //Results = convcettestring;
                        
        //            }
        //        }
        //    });
            
        //    printThread.SetApartmentState(ApartmentState.STA);
        //    printThread.Start();
        //    printThread.Join();

        //    return Results;
        //}

        //public static string __ToTiffByIronPDF()
        //{
        //    var Results = "";
        //    byte[] file = File.ReadAllBytes(@"D:\IronPDFLibrary\PDF\PDFToJPG.pdf");

        //    using (var mem = new MemoryStream(file))
        //    {
        //        using (var PDF = new PdfDocument(mem))
        //        {
        //            using (var pdfDocument = PDF.GetPrintDocument())
        //            {
        //                var savedPath = PDF.RasterizeToImageFiles(@"C:\images\pdf_page_*.tiff", IronPdf.Imaging.ImageType.Tiff,100);
        //                using (var NeededStream = new MemoryStream(File.ReadAllBytes(savedPath[0])))
        //                {
        //                    //using(var PDFA = new PdfDocument(NeededStream))
        //                    //{
        //                    //    PDFA.Print();
        //                    //}
        //                    Image img = Image.FromStream(NeededStream);
        //                    var abc = IronPdf.ImageToPdfConverter.ImageToPdf(img);
        //                    abc.Print();
        //                    //var stream = (Stream)NeededStream;
        //                    //var Result = new byte[stream.Length];
        //                    //stream.Read(Result, 0, (int)stream.Length);
        //                    //NeededStream.Flush();
        //                    //var abc = NeededStream.ToArray();
        //                    //Results = Convert.ToBase64String(abc);
        //                }
        //            }

        //        }
        //    }
        //    return Results;

        //}

        public static StringBuilder PDFStreamToTxtO2Lib()
        {
            StringBuilder Result = new StringBuilder();
            byte[] file = File.ReadAllBytes(@"D:\IronPDFLibrary\PDF\PDFToJPG.pdf");
            using (var PDFStream = new MemoryStream(file))
            {
                using (PDFDocument PDFDoc = new PDFDocument())
                {
                    PDFDoc.Load(PDFStream);

                    

                    foreach(PDFPage actual in PDFDoc.Pages)
                    {
                        Result.Append(actual.ExtractText());
                    }
                }
            }
            return Result;
        }
        public static StringBuilder PDFStreamToTxtIronPDF()
        {
            StringBuilder text = new StringBuilder();
            //byte[] file = File.ReadAllBytes(@"D:\IronPDFLibrary\PDF\PDFToJPG.pdf");
            //using (var PDFStream = new MemoryStream(file))
            //{
            //    using (var pdfDocument = new PdfDocument(PDFStream))
            //    {
            //        text.Append(pdfDocument.ExtractAllText());
            //        //byte[] bytes = Encoding.ASCII.GetBytes(text);
            //    }
            //}
            return text;
        }
            


    }
}
