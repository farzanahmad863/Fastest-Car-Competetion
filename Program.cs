using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Fastest_car
{   
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.           
                using (StreamReader sr = new StreamReader("cars.txt"))
                {
                    string[] firstLine = sr.ReadLine().Split(";");//reading first line from text file which has headings not values
                    Console.WriteLine(firstLine[0].PadRight(20) + firstLine[1].PadRight(20) + firstLine[2] + Environment.NewLine) ;
                    string line;
                    List<Car> carsList = new List<Car>();//List to save car objects 
                    string[] tempObj;//stores every line string from file in this array. 
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        tempObj = line.Split(";");
                        carsList.Add(new Car(tempObj[0].Trim(), tempObj[1].Trim(), Int32.Parse(tempObj[2].Trim())));
                    }
                    var query = from car in carsList  //using linq, to query for the price to be in ascending order
                                orderby car.Price ascending
                                select car;
                    foreach(var car in query){
                        Console.WriteLine(car.Brand.PadRight(20)+car.Model.PadRight(20)+car.Price);
                    };
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            //just to let the console stay open
            Console.ReadLine();
        }
    }
}
