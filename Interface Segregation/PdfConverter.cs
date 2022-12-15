using SOILD.Interface_Segregation.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Interface_Segregation
{
    class PdfConverter : SpreadsheetConverter
    {

        public Pdf CsvToPdf(Csv csv)
        {
            // Conversion Logic
            return new Pdf();
        }

        public Pdf ExcelToPdf(Excel excel)
        {
            // Conversion Logic
            return new Pdf();
        }

        public Csv ExcelToCsv(Excel excel)
        {
            throw new InvalidOperationException();
        }

        public Excel CsvToExcel(Csv csv)
        {
            throw new NotImplementedException();
        }

    }
}
