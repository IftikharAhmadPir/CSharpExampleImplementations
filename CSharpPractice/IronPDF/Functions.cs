using System;
using IronPdf;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace CSharpPractice.IronPDF
{
    public static class Functions
    {
        public static void PNGToPDF()
        {
            // One or more images as IEnumerable.  This example selects all JPEG images in a specific folder.
            //var ImageFiles = Directory.EnumerateFiles(@"D:\IronPDFLibrary\Images").Where(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg"));
            var ImageFile = @"D:\IronPDFLibrary\Images\PNGImage.PNG";

            // Convert the images to a PDF and save it.
            ImageToPdfConverter.ImageToPdf(ImageFile).SaveAs(@"D:\IronPDFLibrary\PDF\pngtopdf.pdf");

            //Also see PdfDocument.RasterizeToImageFiles() method to flatten a PDF to images or thumbnails
        }

        public static void JPGToPDF()
        {
            // One or more images as IEnumerable.  This example selects all JPEG images in a specific folder.
            //var ImageFiles = Directory.EnumerateFiles(@"D:\IronPDFLibrary\Images").Where(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg"));
            var ImageFile = @"D:\IronPDFLibrary\Images\JPGImage.JPG";

            // Convert the images to a PDF and save it.
            ImageToPdfConverter.ImageToPdf(ImageFile).SaveAs(@"D:\IronPDFLibrary\PDF\jpgtopdf.pdf");

            //Also see PdfDocument.RasterizeToImageFiles() method to flatten a PDF to images or thumbnails
        }

        public static void TIFFToPDF()
        {
            // One or more images as IEnumerable.  This example selects all JPEG images in a specific folder.
            //var ImageFiles = Directory.EnumerateFiles(@"D:\IronPDFLibrary\Images").Where(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg"));
            var ImageFile = @"D:\IronPDFLibrary\Images\TIFFImage.tif";

            // Convert the images to a PDF and save it.
            ImageToPdfConverter.ImageToPdf(ImageFile).SaveAs(@"D:\IronPDFLibrary\PDF\tifftopdf.pdf");

            //Also see PdfDocument.RasterizeToImageFiles() method to flatten a PDF to images or thumbnails
        }

        public static void PDFToImage()
        {
            ////Example rendering PDF documents to Images or Thumbnails
            //var Pdf = PdfDocument.FromFile(@"D:\IronPDFLibrary\PDF\PDFToJPG.pdf");
            ////Extract all pages to a folder as image files
            //Pdf.RasterizeToImageFiles(@"D:\IronPDFLibrary\Images\pdftojpg.jpg");
            byte[] file = File.ReadAllBytes(@"D:\IronPDFLibrary\PDF\PDFToJPG.pdf");

            using(var mem = new MemoryStream(file))
            {
                using(var PDF = new PdfDocument(mem))
                {
                    MemoryStream mems = new MemoryStream();
                    var pagetobitmatp = PDF.PageToBitmap(1);
                    pagetobitmatp.Save(mems, ImageFormat.Jpeg);

                    //Stream input = mems;
                    var longlength = mems.Length;
                    var intLength = (int)mems.Length;

                    byte[] Result = new byte[longlength];
                    mems.Read(Result, 0, intLength);

                    //pagetobitmatp.Save((stream)PageToBitmap,IronPDF.imaging.imagetype.)
                    //var savedPath = PDF.RasterizeToImageFiles(@"C:\images\pdf_page_*.tiff", IronPdf.Imaging.ImageType.Tiff);
                    //using(var NeededStream = new MemoryStream(File.ReadAllBytes(savedPath[0])))
                    //{
                    //    var stream = (Stream)NeededStream;
                    //    var Result = new byte[stream.Length];
                    //    stream.Read(Result, 0, (int)stream.Length);
                    //    File.Delete(savedPath[0]);
                    //    //ImageToPdf(Result);
                    //}
                }
            }

        }

        public static void ImageToPdf(byte[] imagebyte)
        {
            using(var mem = new MemoryStream(imagebyte))
            {
                var imagefrombyte = Image.FromStream(mem);
                var pdfdoc = ImageToPdfConverter.ImageToPdf(imagefrombyte);
                pdfdoc.Print();
            }
            
        }

            

        public static void MergePDF()
        {
            var pdf1 = PdfDocument.FromFile(@"D:\IronPDFLibrary\PDF\pngtopdf.pdf");
            var pdf2 = PdfDocument.FromFile(@"D:\IronPDFLibrary\PDF\jpgtopdf.pdf");

            var merged = PdfDocument.Merge(pdf1, pdf2);

            merged.SaveAs(@"D:\IronPDFLibrary\PDF\merged.pdf");
        }

        public static void streamToPDF(byte[] file)
        {
            //byte[] file = File.ReadAllBytes(@"D:\IronPDFLibrary\PDF\PDFToJPG.pdf");
            short copies = 3;

            using (var mem = new MemoryStream(file))
            {
                using (var PDF = new PdfDocument(mem))
                {
                    using(var printDocument = PDF.GetPrintDocument())
                    {
                        printDocument.PrinterSettings.Copies = copies;
                        //printDocument.PrinterSettings.PrintFileName = "IftikharFile";
                        //printDocument.PrinterSettings.PrinterName = "TestPrinterForPDF";
                        printDocument.Print();
                        //PDF.Print();
                    }
                    
                }
                //pdfdDocument.Print();
                //pdfdDocument.Print("TestPrinterForPDF");
                //pdfdDocument.PrintToFile(@"D:\TestPdfCreated.pdf");
            }
            //var pdfDocument = new PdfDocument(file);
            //pdfDocument.Print();
            //pdfDocument.PrintToFile(@"D:\TestPdfCreated.pdf");
            //pdfDocument.Print("TestPrinterForPDF");
        }

        public static void mergePDFStream()
        {
            var value = new List<PdfDocument>();

            var listbyte = new List<byte[]>();

            #region dontlook
            byte[] file1 = File.ReadAllBytes(@"D:\IronPDFLibrary\MergePDF\PDF1.pdf");
            byte[] file2 = File.ReadAllBytes(@"D:\IronPDFLibrary\MergePDF\PDF2.pdf");
            byte[] file3 = File.ReadAllBytes(@"D:\IronPDFLibrary\MergePDF\PDF3.pdf");

            listbyte.Add(file1);
            listbyte.Add(file2);
            listbyte.Add(file3);

            var abc = listbyte.Select(x => new PdfDocument(x)).ToList();

            //var doc1 = new PdfDocument(file1);
            //var doc2 = new PdfDocument(file2);
            //var doc3 = new PdfDocument(file3);

            //value.Add(doc1);
            //value.Add(doc2);
            //value.Add(doc3);
            #endregion

            //LogicStarthere
            var pdfDocument = PdfDocument.Merge(value).BinaryData;
            var pdf = new PdfDocument(pdfDocument);
            pdf.Print();


        }

        public static void pdfStreamToImageStream()
        {
            byte[] file1 = File.ReadAllBytes(@"D:\IronPDFLibrary\MergePDF\PDF1.pdf");

            using(var PDFDocStream = new MemoryStream(file1))
            {
                
            };
        }

        public static void getByte()
        {
            //using (var pdf1 = PdfDocument.FromFile(@"C:\Users\iftik\Downloads\dummy.pdf"))
            //{
            //    pdf1.PrintToFile(@"C:\Users\iftik\Downloads\File1.pdf");
            //}

            //using (var pdf2 = PdfDocument.FromFile(@"C:\Users\iftik\Downloads\TestPDF_PDFNotMergeableBySautinSoft.pdf"))
            //{
            //    pdf2.PrintToFile(@"C:\Users\iftik\Downloads\File2.pdf");
            //}

            var pdf1 = PdfDocument.FromFile(@"C:\Users\iftik\Downloads\File1.pdf");
            var pdf2 = PdfDocument.FromFile(@"C:\Users\iftik\Downloads\File2.pdf");

            var merged = PdfDocument.Merge(pdf1, pdf2);
            merged.SaveAs(@"C:\Users\iftik\Downloads\File3.pdf");
            

            //using(var pdfDocument = new PdfDocument(merged))
            //{
            //    pdfDocument.PrintToFile(@"C:\Users\iftik\Downloads\ResultPDF.pdf");
            //}

            var abc = PdfDocument.FromFile(@"C:\Users\iftik\Downloads\ResultPDF.pdf").BinaryData;
        }
    }
}
