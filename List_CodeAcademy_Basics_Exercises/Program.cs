namespace List_CodeAcademy_Basics_Exercises
{

    //for more precise details for each exercise:  link below 

    //https://www.codecademy.com/courses/learn-c-sharp-lists-and-linq/lessons/csharp-lists/exercises/object-initialization
    internal class Program
    {
        static void Main(string[] args)
        {
            Exersice_H();

            Console.ReadKey();


        }

        public static void Exersice_A()
        {


            List<double> marathons = new List<double>();

            marathons.Add(144.07);
            marathons.Add(143.12);

            Console.WriteLine(marathons[1]);




        }
        public static void Exersice_B()
        {
            List<double> marathons = new List<double>
            {
               144.07,
               143.12,
               146.73,
               146.33
            };


            // Do not delete the code below
            double time = marathons[1];

            Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");



        }

        //Count and Contains
        public static void Exersice_C()
        {
            List<double> marathons = new List<double>
            {
                    144.07,
                    143.12,
                    146.73,
                    146.33
            };

            double numersMarathons = marathons.Count;

            Console.WriteLine(numersMarathons);

            marathons.Add(143.23);

            var a = marathons.Contains(143.23);

            Console.WriteLine(a);

            double numersMarathonsb = marathons.Count;
            Console.WriteLine(numersMarathonsb);

            // Do not delete the code below
            double time = marathons[1];

            Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");




        }

        //Removing
        public static void Exersice_D()
        {
            List<double> marathons = new List<double>
            {
                144.07,
                143.12,
                146.73,
                146.33

             };



            bool removed = marathons.Remove(143.12);

            //  Console.WriteLine(removed);
            // Console.WriteLine(marathons[1]);

            marathons.Clear();
        }
        public static void Exersice_E()
        {
            List<double> marathons = new List<double>
              {
                144.07,
                143.12,
                146.73,
                146.33
              };

            double futureWinner = marathons[0];
            marathons[3] = 143.23;

            Console.WriteLine("If you reached this point, there are no errors!");
            Console.WriteLine(marathons[3]);




        }

        //Working with Ranges

        /*
         Use GetRange() to get the first three elements in the marathons list.

         Store the result in a new list variable called topMarathons.
         
         
         
         */
        public static void Exersice_F()
        {
            List<double> marathons = new List<double>
              {
                    144.07,
                    143.12,
                    146.73,
                    146.33


              };


            //var topMarathons = marathons.GetRange(0,2);


            List<double> topMarathons = marathons.GetRange(0, 3);

            Console.WriteLine(topMarathons);


            foreach (var myMarathon in topMarathons)
            {

                Console.WriteLine(topMarathons);

            }
            






        }
        public static void Exersice_G()
        {
            List<string> runners = new List<string> { "Jemima Sumgong", "Tiki Gelana", "Constantina Tomescu", "Mizuki Noguchi" };
            Random rand = new Random();

            Console.WriteLine("In reverse chronological order, the gold medalists are...");

            // First loop
            for (int i = 0; i < runners.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {runners[i]}");
            }

            Console.WriteLine("\nPrinting runner bibs...");


            // Second loop
            foreach (string runner in runners)
            {

                // int id = rand.Next(100, 1000);
                //Console.WriteLine($"{id} : {i}");


                string name = runner.ToUpper();
                int id = rand.Next(100, 1000);
                Console.WriteLine($"{id} - {name}");

            }


        }

        //Add your city to the list, then use a foreach loop to print the whole list to the console.
        public static void Exersice_H()
        {

            {
                List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };

                citiesList.Add("Munich");


                foreach(string cities in citiesList)
                {

                    Console.WriteLine(cities);
                }



            }





        }
    }

}
















