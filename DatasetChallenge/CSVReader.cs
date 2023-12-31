﻿using System;
using System.Collections.Generic;
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
