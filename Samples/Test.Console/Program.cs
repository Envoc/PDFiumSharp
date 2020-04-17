using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDFiumSharp;
using System.IO;

namespace TestConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var doc = new PdfDocument(@"C:\temp\80d4e54f-8064-4c7f-b924-c196dbe2a087.pdf"))
            {
                var test = doc.InitFormFillEnvironment();
				int i = 0;
				foreach (var page in doc.Pages)
				{
					using (var bitmap = new PDFiumBitmap((int)page.Width, (int)page.Height, true))
					using (var stream = new FileStream($"{i++}.bmp", FileMode.Create))
					{
						page.Render(bitmap);
                        //page.RenderForm(test,bitmap);
						bitmap.Save(stream);
					}
				}
			}
		}
	}
}
