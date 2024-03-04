using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos;

namespace dotnetflix.Api.Extensions;

/* 
 * This class is responsible for calculating the price of a ticket based on the given parameters.
 * It takes into account the discount type, age, student status, senior status, cinema pass, Dutch spoken, weekday, holiday, and movie runtime.
 * The CalculatePrice method takes all these parameters and returns the final price of the ticket.
 */


public static class TicketPricingCalculator
{
	private const decimal BasePrice = 8.50M;

	public static decimal CalculatePrice(Discount discount, int age, bool isStudent, bool isSenior, bool isCinemaPass, bool isDutchSpoken, bool isWeekday, bool isHoliday, Movie movieRuntime)
	{
		decimal price = BasePrice;

		switch (discount)
		{
			case Discount.Children:
				// Discount: 1.50 (age < 11 + show < 18:00 + dutch spoken movies)
				if (age < 11 && movieRuntime.Runtime < 120 && isDutchSpoken)
					price -= 1.50M;
				break;
		
			case Discount.Students:
				// Discount: 1.50 (student pass + only valid on mon-thu)
				if (isStudent && isWeekday)
					price -= 1.50M;
				break;
			
			case Discount.Seniors:
				// Discount: 1.50 (senior pass + only valid on mon-thu excl. holidays)
				if (isSenior && isWeekday && !isHoliday)
					price -= 1.50M;
				break;
			
			case Discount.CinemaPass:
				// Discount: varies (MaDiWoDo ticket + only valid on mon-thu excl. holidays)
				if (isCinemaPass && isWeekday && !isHoliday)
				{
					// TO-DO: Implement CinemaPass discount
				}
				break;
			
			case Discount.None:
			
			default:
				// Default price: 8.50 or 9.00 if movie runtime > 120
				price = (movieRuntime.Runtime > 120) ? 9.0M : BasePrice;
				break;
		}
		return price;
	}
}