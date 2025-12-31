using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.constructors
{
    internal class HotelBooking
    {
            public string GuestName;
            public string RoomType;
            public int Nights;

            // Default constructor
            public HotelBooking()
            {
                GuestName = "Navya";
                RoomType = "Standard";
                Nights = 2;
            }

            // Parameterized constructor
            public HotelBooking(string guestName, string roomType, int nights)
            {
                GuestName = guestName;
                RoomType = roomType;
                Nights = nights;
            }

            // Copy constructor
            public HotelBooking(HotelBooking other)
            {
                GuestName = other.GuestName;
                RoomType = other.RoomType;
                Nights = other.Nights;
            }

            public static void Main(string[] args)
            {
                HotelBooking b1 = new HotelBooking();
                Console.WriteLine("Guest: " + b1.GuestName);
                Console.WriteLine("Room: " + b1.RoomType);
                Console.WriteLine("Nights: " + b1.Nights);

                HotelBooking b2 = new HotelBooking("vansh", "Deluxe", 4);
                Console.WriteLine("Guest: " + b2.GuestName);
                Console.WriteLine("Room: " + b2.RoomType);
                Console.WriteLine("Nights: " + b2.Nights);

                HotelBooking b3 = new HotelBooking(b2);
                Console.WriteLine("Copied Guest: " + b3.GuestName);
                Console.WriteLine("Copied Room: " + b3.RoomType);
                Console.WriteLine("Copied Nights: " + b3.Nights);
            }
        }
    }



