using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DatasetChallenge
{
    public class CSVReader
    {
        public string FilePath { get; set; }

        public bool HasHeader { get; set; }

        public string[] Columns { get; set; }

        public CSVReader(string filePath, bool hasHeader, string[] columns)
        {
            this.FilePath = filePath;
            this.HasHeader = hasHeader;
            if (hasHeader == false)
            { 
                this.Columns = columns;
            }
        }

        public void Write<T>(List<T> data)
        {
            // write the header 

            // write the file contents

            using (StreamWriter writer = new StreamWriter(this.FilePath))
            {
                if(this.HasHeader && this.Columns.Length > 0)
                {
                    writer.WriteLine(string.Join(",", this.Columns));
                }
                foreach (T item in data) 
                {
                    List<string> values = new List<string>();
                    for(int i = 0; i < this.Columns.Length; i++)
                    {
                        PropertyInfo column = typeof(T).GetProperty(this.Columns[i]);
                        string value = Convert.ToString(column.GetValue(item));
                      
                        values.Add(value);
                    }
                    writer.WriteLine(string.Join(",", values));
                }
            }
        }

        public List<T> Read<T>() where T : new()
        {
            List<T> rows = new List<T>();

            
            try
            {
                using (StreamReader reader = new StreamReader(this.FilePath))
                {
                    string line;
                    if (this.HasHeader)
                    {
                        line = reader.ReadLine();
                        if (line == null)
                        {
                            return new List<T>();
                        }
                        this.Columns = line.Split(",");

                    }
                    while ((line = reader.ReadLine()) != null)
                    {
                        if(line == "")
                        {
                            break;
                        }
                        string[] values = line.Split(",");
                        T obj = new T();
                        Type objType = typeof(T);
                        for (int i = 0; i < values.Length; i++)
                        {
                            PropertyInfo column = objType.GetProperty(this.Columns[i]);
                            if (column.PropertyType == typeof(string))
                            {
                                column.SetValue(obj, values[i]);
                            }
                            else if (column.PropertyType == typeof(int))
                            {
                                column.SetValue(obj, Convert.ToInt32(values[i]));
                            }
                            else if (column.PropertyType == typeof(bool))
                            {
                                column.SetValue(obj, values[i] == "1");
                            }

                        }
                        rows.Add(obj);
                    }
                }
            }
            catch ( FileNotFoundException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return rows;
        }

    }
}
