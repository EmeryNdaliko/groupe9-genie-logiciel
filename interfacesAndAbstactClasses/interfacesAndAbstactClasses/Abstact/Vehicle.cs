using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesAndAbstactClasses.Abstact
{
    abstract class Vehicle
    {
        protected String Mark, Model, Color;

        public Vehicle(String model, String mark, String color)
        {
            this.Mark = mark;
            this.Model = model;
            this.Color = color;
        }

        public String nameMark
        {
            get
            {
                return Mark;
            }
            set
            {
                Mark = value;
            }
        }

        public String nameModel
        {
            get
            {
                return Model;
            }
            set
            {
                Model = value;
            }
        }

        public String nameColor
        {
            get
            {
                return Color;
            }
            set
            {
                Color = value;
            }
        }

        public abstract void showDetails(int choix,int id);

        public abstract void Add(int choix);
    }
}
