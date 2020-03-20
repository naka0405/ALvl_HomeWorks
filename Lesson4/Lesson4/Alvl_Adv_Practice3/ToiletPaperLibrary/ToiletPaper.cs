using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public static class ToiletPaperKeeper
    {
        public static List<ToiletPaper> Papers = new List<ToiletPaper>();

        public static void Add(ToiletPaper paper)
        {
            Papers.Add(paper);
        }
    }

    public class ToiletPaper
    {
        public ToiletPaper(string manufacturerName, double length,
            double density, Vtulka internalVtulka = null)
        {
            ManufacturerName = manufacturerName;
            Length = length;
            Density = density;
            InternalVtulka = internalVtulka;
        }

        public double Length { get; private set; }
        public string ManufacturerName { get; }

        public double Density { get; }

        public double RollRadios
        {
            get
            {
                if (this.InternalVtulka == null)
                {
                    return Math.Sqrt(Length * Density / Math.PI);
                }

                return Math.Sqrt(this.Length * Density / Math.PI + Math.Pow(InternalVtulka.Radios, 2));
            }
        }

        public Vtulka InternalVtulka { get; }

        public void Use(double useLength)
        {
            this.Length -= useLength;
        }

        //
        public override string ToString()
        {
            return $"roll {ManufacturerName}: length - {Length}, roll radios - {RollRadios:F5}";
        }

        public class Vtulka
        {
            public Vtulka(double radios, string material)
            {
                Radios = radios;
                Material = material;
            }

            public double Radios { get; }

            public string Material { get; }
        }
    }

