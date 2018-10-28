using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Pdf;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using PdfSharp.Pdf.IO;

namespace PDFReaderRead
    {
    class Program
        {
       
        
    static void Main(string[] args)
        {
            string[] filePaths = Directory.GetFiles(@"C:\Users\Intri\Downloads\HayesEsq\2016-12-20-Bucci-Bank Statements\")
                .Select(x => new FileInfo(x).FullName)
                .ToArray();
                    string outputPdfPath = @"C:\Users\Intri\Downloads\HayesEsq\2016-12-20-Bucci-Bank Statements\newPdf.pdf";


            MergePDFs(outputPdfPath, filePaths);

            var firstFilePath = filePaths[0];

            
            ArrayList list = new ArrayList();

            int i =   filePaths.Count();

           

            //for (int b = 0; b < fileInfos.Length-1; b++)
            //    {
               
            //    int pages =  get_pageCount(fileInfos[b]);
            //    reader = new PdfReader(fileInfos[b]);
            //    for (int g = 0; g <= pages; g++)
            //        {
            //        importedPage = pdfCopyProvider.GetImportedPage(reader, g);
            //        pdfCopyProvider.AddPage(importedPage);
            //        }
            //    reader.Close();
            //    }
          
            //foreach (FileInfo info in fileInfos)
            //    {
            //    if (info.Name.IndexOf("protected") == -1)
            //        list.Add(info.FullName);
            //    }
            //int listCount = list.Count;
            //foreach (var listItem in list)
            //    {
               
            //        Console.Out.WriteLine("listItem: {0}", listItem);
            //        //Console.ReadKey();

            //    }
            
            #region
            //var filePathLIst = new List<string>();
            //var filePaths = Directory.GetFiles(@"C:\Users\Intri\Downloads\HayesEsq\2016-12-20-Bucci-Bank Statements\Bucci Entertainment Group LLC-Checking-5565\");


            //var numberOfFilePaths =   filePaths.Count();
            //Console.Out.WriteLine("Count {0}", numberOfFilePaths);
            //foreach (var filePath in filePaths)
            //    {
            //    filePathLIst.Add(filePath);
            //    };
            //    foreach (var itemFile in filePathLIst)
            //    {
            //        Console.Out.WriteLine("itemFile is {0}", itemFile);
            //        Console.ReadKey();
            //    }
            //PdfDocument pdfDocument = new PdfDocument();

            }
        //PdfReader pdfReader = new PdfReader(@"C:\Users\Intri\Downloads\HayesEsq\2014-01-31-BucciEntertainmentGroupLLC-Checking-5565.pdf");
        //byte[] b = pdfReader.Metadata;

        //if (b !=null)
        //    {

        //    string xml = new UTF8Encoding().GetString(b);
        //    Console.Out.WriteLine("xml string: {0}", xml);
        //    Console.ReadKey();
        #endregion

            private static int get_pageCount(string file)
            {
            using (StreamReader sr = new StreamReader(File.OpenRead(file)))
                {
                Regex regex = new Regex(@"/Type\s*/Page[^s]");
                MatchCollection matches = regex.Matches(sr.ReadToEnd());

                return matches.Count;
                }

            }
        public static void MergePDFs(string targetPaths, params string[] pdfs)
            {
            using (PdfDocument targetDoc = new PdfDocument())
                {
                    foreach (string pdf in pdfs )
                    {
                    //using 
                   

                    PdfDocument pdfDoc = PdfSharp.Pdf.IO.PdfReader.Open(pdf, PdfDocumentOpenMode.Import);
                        {
                            for (int i = 0; i < pdfDoc.PageCount;i++)
                          {
                            PdfPage page = pdfDoc.Pages[i];
                           
                            }
                        }
                    }
                targetDoc.Save(targetPaths);
                targetDoc.Close();
                }

            }
      

        }

    }

 
