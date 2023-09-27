using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ООП_УП_ПТ3_Моника_Блажева_11е
{
    abstract class Property
    {
        //полета на класа
        protected string id; 
        protected double buildUpArea;
        protected string type;
        protected int numberOfFloors;
        protected string boss;
        
        //свойства на класа
        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public double BuildUpArea
        {
            get { return this.buildUpArea; }
            set { this.buildUpArea = value; }
        }
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public int NumberOfFloors
        {
            get { return this.numberOfFloors; }
            set { this.numberOfFloors = value; }
        }
        public string Boss
        {
            get { return this.boss; }
            set { this.boss = value; }
        }

        //конструктор на класа
        public Property(string i, double b, string t, int n, string bo)
        {
            this.ID = i;
            this.BuildUpArea = b;
            this.Type = t;
            this.NumberOfFloors = n;
            this.Boss = bo;
        }
        public virtual void SumBuiltUpArea() //виртуален метод, който смята площа
        {
            double area = BuildUpArea * NumberOfFloors;
            Console.WriteLine("the area is:{0:f2}", area);
        }
        public virtual void InfoPrintProperties() //виртуален метод, който изписва данните за имота
        {
            Console.WriteLine("{0}-/-{1}-/-{2}", ID, Type, NumberOfFloors);
        }
        public abstract void ShowBoss(); //абстрактен клас за шефа на имота
    }
}
