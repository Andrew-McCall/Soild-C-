using System;
using System.Collections.Generic;
using System.Text;
using SOILD.Interface_Segregation.DataTypes;

namespace SOILD.Interface_Segregation
{
    interface SpreadsheetConverter
    {
        public Csv ExcelToCsv(Excel excel);
        public Excel CsvToExcel(Csv csv);
        public Pdf ExcelToPdf(Excel excel);
        public Pdf CsvToPdf(Csv csv);

    }
}
