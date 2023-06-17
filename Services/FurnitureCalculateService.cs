using KitchenProject.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenProject.Services
{
    public class FurnitureCalculateService
    {
        public string ListInfo(List<Furniture> furnitures)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var f in furnitures) 
            {
                switch(f.Type)
                {
                    case "Обикновен шкаф":
                        sb.AppendLine(BasicCloset(f));
                        break;
                }
            }
            return sb.ToString();
        }

        public Dictionary<string, List<double>> Materials(List<Furniture> furnitures)
        {
            var Dic = new Dictionary<string, List<double>>();
            Dic["x"] = new List<double>();
            Dic["y"] = new List<double>();
            Dic["count"] = new List<double>();
            foreach (var f in furnitures)
            {
                switch (f.Type)
                {
                    case "Обикновен шкаф":
                        BasicClosetMatirials(Dic,f);
                        break;
                }
            }
            return Dic;
        }

        public string BasicCloset(Furniture item)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(item.Name+" - "+item.Type);
            string output = "Дъно - "+item.Width.ToString()+"*/"+ item.Depth.ToString() + "** - 1бр.";
            sb.AppendLine(output) ;
            output = "Страница - " + (item.Height - 18).ToString() + "/" + item.Width.ToString() + " - 2бр.";
            sb.AppendLine(output);
            output = "Бленда - " + (item.Width - 36).ToString() + "/" + 80.ToString() + " - 2бр.";
            sb.AppendLine(output);

            return sb.ToString();

        }
        public void BasicClosetMatirials(Dictionary<string, List<double>> Dic,Furniture item)
        {
            Dic["x"].Add(item.Width);
            Dic["y"].Add(item.Depth);
            Dic["count"].Add(1);

            Dic["x"].Add(item.Height - 18);
            Dic["y"].Add(item.Width);
            Dic["count"].Add(2);

            Dic["x"].Add(item.Width - 36);
            Dic["y"].Add(80);
            Dic["count"].Add(2);
        }
    }
}
