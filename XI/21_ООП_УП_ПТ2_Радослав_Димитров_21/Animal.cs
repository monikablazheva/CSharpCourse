using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ООП_УП_ПТ2_Радослав_Димитров_21
{
    abstract class Animal
    {
        protected string name;
        protected string favouriteFood;
        protected string area;
        public Animal()
        {
            name = this.name;
            favouriteFood = this.favouriteFood;
            area = this.area;
        }
        protected string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        protected string FavouriteFood
        {
            get { return this.favouriteFood; }
            set { this.favouriteFood = value; }
        }
        protected string Area
        {
            get { return this.area; }
            set { this.area = value; }
        }


        public virtual string ExplainMyself()
        {
            string a = "";
            return a;
        }                  
    }
}
