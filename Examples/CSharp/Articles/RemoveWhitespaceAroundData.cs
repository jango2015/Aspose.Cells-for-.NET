using System.IO;

using Aspose.Cells;
using Aspose.Cells.Rendering;

namespace Aspose.Cells.Examples.Articles
{
    public class RemoveWhitespaceAroundData
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            //Instantiate a workbook
            //Open the template file
            Workbook book = new Workbook(dataDir+ "MyTestBook1.xlsx");

            //Get the first worksheet
            Worksheet sheet = book.Worksheets[0];

            //Specify your print area if you want
            //sheet.PageSetup.PrintArea = "A1:H8";

            //To remove the white border around the image.
            sheet.PageSetup.LeftMargin = 0;
            sheet.PageSetup.RightMargin = 0;
            sheet.PageSetup.BottomMargin = 0;
            sheet.PageSetup.TopMargin = 0;

            //Define ImageOrPrintOptions
            ImageOrPrintOptions imgOptions = new ImageOrPrintOptions();
            imgOptions.ImageFormat = System.Drawing.Imaging.ImageFormat.Emf;
            //Set only one page would be rendered for the image
            imgOptions.OnePagePerSheet = true;
            imgOptions.PrintingPage = PrintingPageType.IgnoreBlank;

            //Create the SheetRender object based on the sheet with its
            //ImageOrPrintOptions attributes
            SheetRender sr = new SheetRender(sheet, imgOptions);
            //Convert the image
            sr.ToImage(0, dataDir+ "img_MyTestBook1.emf");
            
        }
    }
}