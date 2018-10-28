using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace iTextSharp
    {
    class Program
        {
        static void Main(string[] args)
            {
            byte[] mergedPdf = null;
            string[] filePaths = Directory.GetFiles(@"C:\Users\Intri\Downloads\HayesEsq\2016-12-20-Bucci-Bank Statements\Bucci Entertainment Group LLC-Checking-5565/")
             .Select(x => new FileInfo(x).FullName)
             .ToArray();

            string filePathExtension = Path.GetExtension(filePaths[0]);
            Console.Out.WriteLine("file Path Extension is: {0}", filePathExtension);



            using (MemoryStream ms = new MemoryStream())
                {
                using (Document document = new Document())
                    {
                    using (PdfCopy copy = new PdfCopy(document, ms))

                        {
                        document.Open();
                        for (int i = 0; i < filePaths.Count() - 1; i++)
                            {
                              if (Path.GetExtension(filePaths[i]) == ".pdf")
                                {
                                PdfReader reader = new PdfReader(filePaths[i]);
                                int n = reader.NumberOfPages;
                                for (int page = 0; page < n;)
                                    {
                                    copy.AddPage(copy.GetImportedPage(reader, ++page));
                                    }
                                }


                             }
                            }
                        }
                    mergedPdf = ms.ToArray();
                    System.IO.File.WriteAllBytes(@"C: \Users\Intri\Downloads\HayesEsq\2016-12-20-Bucci-Bank Statements\newPdf.pdf", mergedPdf);

                    }





                }
            }
        }
