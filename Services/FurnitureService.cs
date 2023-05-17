using CsvHelper;
using KitchenProject.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KitchenProject.Services
{
    public class FurnitureService
    {
        public List<Neshto> neshtos = new List<Neshto>();
        
        public List<Furniture> furnitures = new List<Furniture>()
        {
            new Furniture
            {
                Name = "test",
                X= 10

            },
            new Furniture
            {
                Name = "test2",
                X= 10
            },
            new Furniture
            {
                Name = "test3",
                X= 10
            }
        };
        
        
        public void SaveInFile()
        {
            var scvPath = Path.Combine(Environment.CurrentDirectory, $"1.scv");
            using(var sr = new StreamWriter(scvPath))
            {
                using(var scvWriter = new CsvWriter(sr,CultureInfo.InvariantCulture))
                {
                    scvWriter.WriteRecords(furnitures);
                }
            }
        }

        public List<Furniture> ReadFile(string fileName)
        {
            
            var scvPath = Path.Combine(Environment.CurrentDirectory, fileName+$".scv");
            using (var sr  = new StreamReader(scvPath)) 
            {
                using(var csvReader = new CsvReader(sr, CultureInfo.InvariantCulture))
                {
                    var result = csvReader.GetRecords<Furniture>().ToList();
                    return result;
                }
            }
        }
    }
}
