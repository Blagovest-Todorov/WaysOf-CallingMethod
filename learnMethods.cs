using System;

namespace Methods
{
    class learnMethods
    {

        static void PrintNumbers(int start = 0 , int end = 100)  //optional parameters with default 
            //values assigned at their declaration
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(" {0} ", i);
            }
        }
        
        
        static void Main(string[] args)
        {

            //Lets show some ways we to call the method PrintNumber();

            // PrintNumbers(); //calling the above method  way one --printitn all default declared values
            //PrintNumbers(15); //as we have passed one parameter of two available, it takes the start :
            //from this parameter value till the edn value of default value declaration---second way of valling
            //PrintNumbers(5,  15); //calling the method with two values as the declaration  is, third way of calling
            //PrintNumbers(start: 10, end: 20);///new way using  ":" to assign start -end values for a mehtod 
            //-forth way of calling a method 
            //PrintNumbers(start: 50, end: 100); --the sequence of the parameters is kept;
            //PrintNumbers(end: 50, start:18);//the sequence in parameters is not kept, 
            //but this is not importat becasue we have passed teh values to the concrete named parameters, VS knows;
            //PrintNumbers(end: 40);//Here we initialize only the end parameter---start param is the defaults one
            PrintNumbers(start: 10); //here missed the end parameter, then it takes teh defauls one


        }
    }
}
