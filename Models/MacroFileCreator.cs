using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StringRestAPI.Models
{
    using System.IO;

    public class MacroFileCreator
    {
        public void CreateMacro(string filePath, string header, string footer, string originalText, string modifiedText, string[,] replacements, int lines)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(header);

                for (int i = 2; i <= lines; i++)
                {
                    if (string.IsNullOrEmpty((string)replacements[i, 9]))
                    {
                        string modifiedLine = originalText;

                        for (int j = 1; j <= 14; j++)
                        {
                            modifiedLine = modifiedLine.Replace($"XX{j}XX", replacements[i, j]);
                        }

                        writer.WriteLine(modifiedLine);
                    }
                }

                writer.WriteLine(footer);
            }
        }
    }

}