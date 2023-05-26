using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelperAndJSON.Net
{
    internal class CSvOperation
    {
        public static void CsvImplementFunction()
        {
            string firstPath = "D:\\CsharpBasicprograms\\CsvHelperAndJSON.Net\\CsvHelperAndJSON.Net\\Files\\Book.csv";
            string secondPath = "D:\\CsharpBasicprograms\\CsvHelperAndJSON.Net\\CsvHelperAndJSON.Net\\Files\\Address.csv";
            try
            {
                //ReadOperation
                //FileStream stream = new FileStream(firstPath, FileMode.CreateNew);
                StreamReader sr = new StreamReader(firstPath);
                CsvReader cr = new CsvReader(sr, CultureInfo.InvariantCulture);
                List<Contact> lists = cr.GetRecords<Contact>().ToList();
                Console.WriteLine("Sucessfully read from Book.csv");

                foreach (Contact data in lists)
                {
                    Console.WriteLine(data.Name + " " + data.Id + " " + data.Phone + " " + data.Age);
                }
                //WriteOperation
                StreamWriter sw = new StreamWriter(secondPath);
                CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture);
                cw.WriteRecords(lists);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
