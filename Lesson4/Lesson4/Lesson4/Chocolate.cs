using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Chocolate
    {
        private string title;
        private string production;
        private int weightGramm;
        private string kind;
        private int percentCocoa;
        private DateTime dateDeadline;// deadline for implementation


        //private int count;
        public Chocolate()
        {

        }

        public Chocolate(string title, string production, int weightGramm, string kind, int percentCocoa, DateTime dateDeadline)
        {
            Title = title;
            Production = production;
            WeightGramm = weightGramm;
            Kind = kind;
            PercentCocoa = percentCocoa;
            DateDeadline = dateDeadline;
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    title = value;
                }
                else
                    PrintMessage("Title", value.ToString());
            }
        }

        public int WeightGramm
        {
            get { return weightGramm; }
            set
            {
            //    if (value < 0)//&& !int.TryParse(value, out int rezult)
            //    {
                    weightGramm = value;
            //    }
            //    else
            //        PrintMessage("Weight gramm", value.ToString());
            }
        }


        public string Production
        {
            get { return production; }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    production = value;
                }
                else
                    PrintMessage("Production", value.ToString());
            }
        }


        public string Kind { get; set; } = "Milk";


        public int PercentCocoa
        {
            get { return percentCocoa; }
            private set
            {
                if (value > 0)//&& !int.TryParse(value, out int rezult)
                {
                    percentCocoa = value;
                }
                else
                    PrintMessage("% cocoa", value.ToString());
            }
        }
        public DateTime DateDeadline { get; }

               
        public int GetProdExpiration(out bool IsExpire)//
        {
            IsExpire=false;
            TimeSpan daysForEnd = DateDeadline-DateTime.Now ;
            if (daysForEnd.Days <= 0)
            {
                IsExpire = true;
            }

            return daysForEnd.Days;
        }

        public override string ToString()
        {
            return $"Title: {Title} Producer: {Production} Weight(gramm): {WeightGramm} Kind: {Kind} " +
                $"%Cocoa: {PercentCocoa}  EndDateOfRealise: {DateDeadline.ToShortDateString()}";
        }

        public void PrintMessage(string propertyName, string value)
        {
            Console.WriteLine($"{propertyName} {value} is invalid.Try again.");
        }

        public string this[string propname]
        {
            get
            {
                switch (propname)
                {
                    case "Title": return  title;
                    case "Production": return production;
                    case "WeightGramm": return weightGramm.ToString();
                    case "Kind": return kind;
                    case "%cocoa": return percentCocoa.ToString();
                    case "DateDeadline": return dateDeadline.ToString();
                    default: return null;
                }
            }
            set
            {
                switch (propname)
                {
                    case "Title":
                        title = value;
                        break;
                    case "Production":
                        production = value;
                        break;
                    case "WeightGramm":
                        weightGramm = int.Parse(value);
                        break;
                    case "Kind":
                        kind = value;
                        break;
                    case "%cocoa":
                        percentCocoa = int.Parse(value);
                        break;
                    case "DateDeadline":
                        dateDeadline = DateTime.Parse(value);
                        break;
                }
            }
        }
    }
}

