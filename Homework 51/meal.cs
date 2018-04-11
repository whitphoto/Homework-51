/********************************************************
*														*
*		Nathan Whitchurch								*
*		CIS 223 COMPUTER PROJECTS & APPLICATIONS    	*
*		Dr Whittle										*
*		Homework 5-2 Menu Program						*
*														*
********************************************************/


/********************************************************
*                                                       *
*       meal.cs                                         *
*                                                       *
********************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Homework_51
{
    public abstract class meal
    {

        string mealDesc;
        public string getMealDesc() { return mealDesc; }//public getter for private variable

        decimal mealPrice;
        public decimal getMealPrice() { return mealPrice; }//public getter for private variable
        public abstract char getMealType();
        public meal()
        { }//end default constructor

        public meal(string descIn, decimal priceIn)
        {
            this.mealDesc = descIn;
            this.mealPrice = priceIn;
        }//end overloaded constructor
    }//end meal parent class

    public class breakfast : meal

    {
        char mealType;
        public override char getMealType() { return mealType; }//public getter for private variable

        public breakfast()
        { }//end default constructor

        public breakfast(char typeIn, string descIn, decimal priceIn) : base(descIn, priceIn)
        //this overloaded constructor takes in three values, it passes two up to the parent 
        //constructor and uses a third to set the variable unique to the child classes
        {
            this.mealType = typeIn;
        }//end overloaded constructor



    }//end breakfast child class


    public class lunch : meal


    {
        char mealType;
        public override char getMealType() { return mealType; }//public getter for private variable
        public lunch()
        { }//end default constructor

        public lunch(char typeIn, string descIn, decimal priceIn) : base(descIn, priceIn)
        //this overloaded constructor takes in three values, it passes two up to the parent 
        //constructor and uses a third to set the variable unique to the child classes
        {
            this.mealType = typeIn;
        }



    }//end lunch child class

    public class dinner : meal

    {
        char mealType;
        public override char getMealType() { return mealType; }//public getter for private variable

        public dinner()
        { }//end default constructor

        public dinner(char typeIn, string descIn, decimal priceIn) : base(descIn, priceIn)
        //this overloaded constructor takes in three values, it passes two up to the parent 
        //constructor and uses a third to set the variable unique to the child classes
        {
            this.mealType = typeIn;
        }



    }//end dinner child class








}//end meal class




