using KitchenProject.Models;
using System;
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
        public string BasicCloset(Furniture item)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(item.Name);
            string output = "Дъно - "+item.Width.ToString()+"*/"+ item.Depth.ToString() + "** - 1бр.";
            sb.AppendLine(output) ;
            output = "Страница - " + (item.Height - 18).ToString() + "/" + item.Width.ToString() + " - 2бр.";
            sb.AppendLine(output);
            output = "Бленда - " + (item.Width - 36).ToString() + "/" + 80.ToString() + " - 2бр.";
            sb.AppendLine(output);

            return sb.ToString();

        }
    }
}
