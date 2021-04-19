using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();//May, June, July, August, September or October
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;
            double totalApartmentPrice = 0;
            double totalStudioPrice = 0;
            double discount = 0;
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    if (nights > 7 && nights <= 14)
                    {
                        studioPrice = studioPrice - (studioPrice * 0.05);
                    }
                    else if (nights > 14)
                    {
                        studioPrice = studioPrice - (studioPrice * 0.3);
                        apartmentPrice = apartmentPrice - (apartmentPrice * 0.1);
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.2;
                    apartmentPrice = 68.7;
                    if (nights > 14)
                    {
                        studioPrice = studioPrice - (studioPrice * 0.2);
                        apartmentPrice = apartmentPrice - (apartmentPrice * 0.1);
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    if (nights > 14)
                    {
                        apartmentPrice = apartmentPrice - (apartmentPrice * 0.1);
                    }
                    break;
            }
            totalApartmentPrice = apartmentPrice * nights;
            totalStudioPrice = studioPrice * nights;
            Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        }
    }
}
