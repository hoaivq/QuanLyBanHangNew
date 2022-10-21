using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace HCommon.Class
{
    public class AppCommon
    {
        public string PathCombine(params string[] Paths)
        {
            if (Paths.Length <= 0) { return string.Empty; }
            string firstPath = Paths[0];

            string filePath = string.Empty;
            bool isFirstPath = true;
            foreach (string nextPath in Paths)
            {
                if (isFirstPath) { isFirstPath = false; continue; }
                filePath = Path.Combine(filePath, nextPath);
            }

            return firstPath.TrimEnd(new char[] { '\\' }) + @"\" + filePath.TrimStart(new char[] { '\\' });
        }

       
       

        public string GetExcelColumnName(int columnNumber)
        {
            string columnName = "";

            while (columnNumber > 0)
            {
                int modulo = (columnNumber - 1) % 26;
                columnName = Convert.ToChar('A' + modulo) + columnName;
                columnNumber = (columnNumber - modulo) / 26;
            }

            return columnName;
        }

        public string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
