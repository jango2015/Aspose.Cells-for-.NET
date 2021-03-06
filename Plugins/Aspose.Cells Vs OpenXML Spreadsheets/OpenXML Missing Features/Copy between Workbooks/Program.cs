﻿// Copyright (c) Aspose 2002-2014. All Rights Reserved.

using Aspose.Cells;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Cells for .NET API reference when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. If you do not wish to use NuGet, you can manually download Aspose.Cells for .NET API from http://www.aspose.com/downloads, install it and then add its reference to this project. For any issues, questions or suggestions please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Plugins.AsposeVSOpenXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"..\..\..\Sample Files\";
            string FileName = FilePath + "Copy between Workbooks.xlsx";
            string destFileName = FilePath + "Resulting Copy between Workbooks.xlsx";
            
            //Create a Workbook.
            //Open a file into the first book.
            Workbook excelWorkbook0 = new Workbook(FileName);

            //Create another Workbook.
            Workbook excelWorkbook1 = new Workbook();

            //Copy the first sheet of the first book into second book.
            excelWorkbook1.Worksheets[0].Copy(excelWorkbook0.Worksheets[0]);

            //Save the file.
            excelWorkbook1.Save(destFileName);
        }
    }
}
