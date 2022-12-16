using SOILD.Interface_Segregation.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Interface_Segregation
{
    class PdfConverter : IConvertToPdf
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

    }
}
