using System;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var feedback = false;
            var quantity = 0;
            var price = 0.0;
            var end = 'q';
            var name = " ";
            var deci = 0.0m;
            var product = " ";
            var str="";
            
            Console.WriteLine("Enter the your name ");
            name = Console.ReadLine();
do{
            Console.WriteLine("Enter the product you want to buy ");
            product = Console.ReadLine();
            
            Console.WriteLine("Enter the quantity ");
            quantity = Convert.ToInt32(Console.ReadLine());
            if(quantity<0){
Console.WriteLine("Invalid quantity ");
            }
            switch(product){
                case "T-shirt":
                price = 100;
                Console.WriteLine($"The price of T-shirt is {price*quantity}");
                break;
                case "pant":
                price = 150;
                Console.WriteLine($"The price of pant is {price*quantity}");
                break;
                case "hat":
                price = 125;
                Console.WriteLine($"The price of hat is {price*quantity}");
                break;

                default :
                Console.WriteLine("Please enter valid product");
                break;

            }

Console.WriteLine("Enter q to exit");
end = Convert.ToChar(Console.ReadLine());
}
while(end!='q');
Console.WriteLine("Do you like this app?");
str=Console.ReadLine();
if(str=="yes")
{
    feedback=true;
}
Console.WriteLine("Thank you!");





        }
    }
}
