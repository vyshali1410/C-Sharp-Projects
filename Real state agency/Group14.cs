using System;

namespace Group4
{
    //Impementation of Address class
    class Address
    {
        //Create  Private Datafields(street,city,province,zipcode) 
        private string street;
        private string city;
        private string province;
        private string zipcode;

        //Create a class constructor for the Address class
        public Address()
        {
            //set the default values for street ,city,province,zipcode
            street = "eglinton avenue east";
            city = "scarborough";
            province = "ontario";
            zipcode = "M1J2G3";
        }

        //Create a class constructor with parameters 
        public Address(string street, string city, string province, string zipcode)
        {
            // refering to current instance 
            this.street = street;
            this.city = city;
            this.province = province;
            this.zipcode = zipcode;
        }

        //Tostring method to return the details of address.
        public override string ToString() => String.Format("\nAddress\nStreet :{0} \nCity :{1} \nState : {2} \nZipCode : {3} \n", street, city, province, zipcode);

    }

    //Implementation of class Residence
    class Residence
    {
        //Create Private Data fields(bedroom,bathrooms,price,Squarefeet,yearbuilt)
        private int bedroom;
        private int bathrooms;
        private int price;
        private int Squarefeet;
        private int yearbuilt;

        //Residence HAS-A Address
        public Address address;

        //Create a class constructor for Residence class with default values
        public Residence()
        {
            this.bedroom = 2;
            this.bathrooms = 2;
            this.price = 3000;
            this.Squarefeet = 1200;
            this.yearbuilt = 2019;
        }

        //Create a class constructor for Residence class with parameters
        public Residence(int bedroom, int bathrooms, int price, int Squarefeet, int yearbuilt, Address address)
        {
            //refering to current instance
            this.bedroom = bedroom;
            this.bathrooms = bathrooms;
            this.price = price;
            this.Squarefeet = Squarefeet;
            this.yearbuilt = yearbuilt;
            this.address = address;

        }
        // calculatecommision method which returns the commission percentage 
        public int CalculateCommission() => this.price * 2 / 100;
        //ToString method to print the details of Residence and Address class.
        public override string ToString() => $"\nBedroom : {bedroom} \nBathroom: {bathrooms} \nPrice : ${price}\nSquarefeet : {Squarefeet}\nYear Built : {yearbuilt}";
    }

    //Implemented Realestate class for the main method
    class Realestate
    {

        //main method for prompting User the details 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Street :");
            string streetName = Console.ReadLine();

            Console.WriteLine("Enter City :");
            string cityName = Console.ReadLine();

            Console.WriteLine("Enter Province:");
            string stateName = Console.ReadLine();

            Console.WriteLine("Enter ZipCode:");
            string zipNum = Console.ReadLine();

            //Creates an Instance for Address class
            Address testaddress = new Address(streetName, cityName, stateName, zipNum);
            //display the details of Address by calling ToString method in Address class.
            Console.WriteLine(testaddress.ToString());

            Console.WriteLine("Enter number of Bedroom :");
            int bedroomnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of Bathroom :");
            int bathroomnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter price:");
            int pricenum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Squarefeet:");
            int sqft = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Year Built:");
            int year = Convert.ToInt32(Console.ReadLine());

            //Creates an Instance for Residence class
            Residence testResidence = new Residence(bedroomnum, bathroomnum, pricenum, sqft, year, testaddress);

            //display the details by calling ToString method in Residence class.
            Console.WriteLine(testResidence.ToString());

        }

    }
}
