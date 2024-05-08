using OfficeOpenXml;
using StringRestAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace StringRestAPI.Controllers
{
    public class MacroControllerController : ApiController
    {
        [HttpPost]
        public IHttpActionResult ProcessExcelSheet()
        {
            // Check if the request contains a multipart/form-data.
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.UnsupportedMediaType);
            }

            // Get the root directory where the Excel file will be saved
            var root = HttpContext.Current.Server.MapPath("~/App_Data");
            var provider = new MultipartFormDataStreamProvider(root);

            try
            {
                // Read the file from the request and save it to the server
                Request.Content.ReadAsMultipartAsync(provider).Wait();

                // Get the uploaded Excel file
                var file = provider.FileData[0];
                var fileInfo = new FileInfo(file.LocalFileName);

                // Process the Excel file
                ProcessExcel(fileInfo.FullName);

                return Ok("Excel sheet processed successfully.");
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        private void ProcessExcel(string filePath)
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1]; // Assuming the data is in the first worksheet

                // Get the number of rows in the worksheet
                int rowCount = worksheet.Dimension.End.Row;

                // Start processing the data from the second row (assuming the first row is headers)
                for (int row = 2; row <= rowCount; row++)
                {
                    string account = worksheet.Cells[row, 1].Value?.ToString();
                    string co = worksheet.Cells[row, 2].Value?.ToString();
                    string div = worksheet.Cells[row, 3].Value?.ToString();
                    string subDiv = worksheet.Cells[row, 4].Value?.ToString();
                    string dept = worksheet.Cells[row, 5].Value?.ToString();
                    string partner = worksheet.Cells[row, 6].Value?.ToString();
                    string className = worksheet.Cells[row, 7].Value?.ToString();
                    string scheme = worksheet.Cells[row, 8].Value?.ToString();

                    // Proceed with your logic to process each row
                    // You can call the existing logic or implement new logic here
                }
            }
        }
    }
}
