using System.Diagnostics;
using TesseractDotnetWrapper;

var testImagePath = "./images/kor_sample.jpg";
if (args.Length > 0)
{
    testImagePath = args[0];
}

try
{
    using var engine = new TesseractEngine(@"./tessdata", "kor+eng", EngineMode.Default);
    using var img = Pix.LoadFromFile(testImagePath);
    // For images like receipts, you should use PageSegMode.SparseText.
    // using var page = engine.Process(img, pageSegMode: PageSegMode.SparseText);
    using var page = engine.Process(img, pageSegMode: null);

    var text = page.GetText();
    Console.WriteLine("Mean confidence: {0}", page.GetMeanConfidence());

    Console.WriteLine("Text (GetText): \r\n{0}", text);
    Console.WriteLine("Text (iterator):");
    using var iter = page.GetIterator();
    iter.Begin();

    //한번은 반복
    do
    {
        do
        {
            do
            {
                do
                {
                    if (iter.IsAtBeginningOf(PageIteratorLevel.Block))
                    {
                        Console.WriteLine("<BLOCK>");
                    }

                    Console.Write(iter.GetText(PageIteratorLevel.Word));
                    Console.Write(" ");

                    if (iter.IsAtFinalOf(PageIteratorLevel.TextLine, PageIteratorLevel.Word))
                    {
                        Console.WriteLine();
                    }
                } while (iter.Next(PageIteratorLevel.TextLine, PageIteratorLevel.Word));

                if (iter.IsAtFinalOf(PageIteratorLevel.Para, PageIteratorLevel.TextLine))
                {
                    Console.WriteLine();
                }
            } while (iter.Next(PageIteratorLevel.Para, PageIteratorLevel.TextLine));
        } while (iter.Next(PageIteratorLevel.Block, PageIteratorLevel.Para));
    } while (iter.Next(PageIteratorLevel.Block));
}

catch (Exception e)
{
    Trace.TraceError(e.ToString());
    Console.WriteLine("Unexpected Error: " + e.Message);
    Console.WriteLine("Details: ");
    Console.WriteLine(e.ToString());
}
Console.WriteLine("done.");
Console.WriteLine("Press any key...");
Console.ReadKey();