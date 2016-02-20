using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class PopulateList
    {
        public void loadList()
        {
            List<string> columns;
            List<Dictionary<string, string>> myData = GetData(out columns);

            foreach (Dictionary<string, string> row in myData)
            {
                PrabhData listing = new PrabhData();
                foreach (string column in columns)
                {
                    if (column == "Title")
                    {
                        listing.Title = row[column].ToString();
                    }
                    else if (column == "Rating")
                    {
                        listing.Rating = row[column].ToString();
                    }
                    else if (column == "Genre")
                    {
                        listing.Genre = row[column].ToString();
                    }
                    else if (column == "Type")
                    {
                        listing.Type = row[column].ToString();
                    }
                }
                Globals.data.Add(listing);
            }

        }
        private static List<Dictionary<string, string>> GetData(out List<string> columns)
        {
            string line;
            string[] stringArray;
            char[] charArray = new char[] { ',' };       //delimited character
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
            columns = new List<string>();

            try
            {
                FileStream fname = new FileStream("MyData/data.txt", FileMode.Open);
                StreamReader ofile = new StreamReader(fname);

                line = ofile.ReadLine();                  
                if (line != null)                         
                {
                    stringArray = line.Split(charArray);  //splits line based on location of ,
                    for (int x = 0; x <= stringArray.GetUpperBound(0); x++)
                    {
                        columns.Add(stringArray[x]);
                    }

                    line = ofile.ReadLine();
                    while (line != null)
                    {
                        stringArray = line.Split(charArray);
                        Dictionary<string, string> dataRow = new Dictionary<string, string>();
                        for (int x = 0; x <= stringArray.GetUpperBound(0); x++)
                        {
                            dataRow.Add(columns[x], stringArray[x]);
                        }
                        data.Add(dataRow);
                        line = ofile.ReadLine();
                    }
                }
                ofile.Close();
                return data;

            }
            catch (IOException)
            {
                FileStream fname = new FileStream("MyData/txt", FileMode.OpenOrCreate);
                StreamReader ofile = new StreamReader(fname);
                ofile.Close();

                return data;        // all code paths must return a value even if empty
            }
        }
    }
}
