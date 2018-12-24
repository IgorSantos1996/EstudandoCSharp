using System;
using TratamentoExcecoes02.Entities;
using TratamentoExcecoes02.Entities.Exceptions;
namespace TratamentoExcecoes02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());


                Reservation rese = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + rese.ToString());
                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation:");
                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                rese.updateDates(checkin, checkout);
                Console.WriteLine("Reservation " + rese);

                Console.ReadKey();
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation" + e.Message);
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
                Console.ReadKey();
            }

        }
    }
}
