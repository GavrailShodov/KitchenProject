using CsvHelper;
using CsvHelper.Configuration;
using KitchenProject.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KitchenProject.Services
{
    public class FileService
    {
        public void SaveInFile(string OrderName,List<Furniture> furnitures)
        {
            var scvPath = Path.Combine(Environment.CurrentDirectory + "/Поръчки", OrderName + ".scv");
            if (!File.Exists(scvPath))
            {
                using (var sr = new StreamWriter(scvPath))
                {
                    using (var scvWriter = new CsvWriter(sr, CultureInfo.InvariantCulture))
                    {
                        scvWriter.WriteRecords(furnitures);
                    }
                }
            }
            else
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = false,
                };

                using (var stream = File.Open(scvPath, FileMode.Append))
                using (var sr = new StreamWriter(stream))
                {
                    using (var scvWriter = new CsvWriter(sr, config))
                    {
                        scvWriter.WriteRecords(furnitures);
                    }
                }
            }
            
        }

        public List<Furniture> ReadFile(string fileName)
        {
            
            var scvPath = Path.Combine(Environment.CurrentDirectory+ "/Поръчки",  fileName +$".scv");
            using (var sr  = new StreamReader(scvPath)) 
            {
                using(var csvReader = new CsvReader(sr, CultureInfo.InvariantCulture))
                {
                    var result = csvReader.GetRecords<Furniture>().ToList();
                    return result;
                }
            }
        }

        public List<string> getExistingOrdersNames()
        {
            var list = new List<string>();
            List<string>filesNames = Directory.GetFiles(Environment.CurrentDirectory + "/Поръчки").ToList();
            foreach(var file in filesNames)
            {
                list.Add(Path.GetFileNameWithoutExtension(file));
            }
            return list;
        }

        public void ExportOrder(List<Furniture> furnitures,FurnitureCalculateService fcs,string orderName)
        {
            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(pathDesktop,orderName+ ".txt");
            using StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.Write(fcs.ListInfo(furnitures));

        }
    }
}
