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
                    case "Гардероб Еднокрилен,без крачета":
                        sb.AppendLine(Wardrobe1(f));
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

        public string kantDebelina(double kant)
        {
            string result = "*";
            if(kant == 1)
            {
                result = "~";
            }
            else if(kant >= 2)
            {
                result = "^";
            }
            return result;
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


        public string Wardrobe1(Furniture item)
        {
            string kant = kantDebelina(item.Kant);
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(item.Name + " - " + item.Type);
            string output = "Дъно - " + (item.Width-36).ToString() + "*/" + (item.Depth-22).ToString() + " - 1бр.";
            sb.AppendLine(output);
            output = "Страници - " + (item.Height - 18).ToString() + "*/" + (item.Width-22).ToString() + "* - 2бр.";
            sb.AppendLine(output);
            output = "Таван - " + item.Width.ToString() + "*/" + (item.Depth - 22).ToString() + "** - 1бр.";
            sb.AppendLine(output);
            output = "Цокъл - " + item.cokul.ToString() + "/" + (item.Width - 36).ToString() + "* - 1бр.";
            sb.AppendLine(output);
            output = "Рафт - " + (item.Width - 37).ToString() + "/" + (item.Depth - 32).ToString() + " - "+item.Shelfs.ToString()+"бр.";
            sb.AppendLine(output);
            output = "Врата - " + (item.Height-item.cokul-item.Kant).ToString() + kant.ToString()+kant.ToString()+"/" + ((item.Width - 3)-item.Kant).ToString()+ kant.ToString() + kant.ToString() + " - 1бр.";
            sb.AppendLine(output);

            return sb.ToString();
        }
    }
}
