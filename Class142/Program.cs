using System;
using Class142.Entities;
using Class142.Entities.Exceptions;

namespace Class142
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter date to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro: "+ e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Erro: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Format Erro: " + e.Message);
            }
        }
    }
}
