using System;
using System.Collections.Generic;
using System.Text;
using SOILD.Interface_Segregation.DataTypes;

namespace SOILD.Interface_Segregation
{
    interface ISpreadsheetConverter : IConvertToPdf, IConvertExcelToCsv, IConvertCsvToExcel
    {

    }
}
