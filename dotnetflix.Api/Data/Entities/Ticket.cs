﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using dotnetflix.Models.Dtos;

namespace dotnetflix.Api.Data.Entities;

public class Ticket
{
    // TICKET
    [Required]
    public int Id { get; set; }
	
    // MOVIE
    [Required]
	[ForeignKey(nameof(Movie.Id))]
	public int MovieId { get; set; }
    public string MovieName { get; set; }
	public int MovieRuntime { get; set; }

	// SHOW
	[Required]
	[ForeignKey(nameof(Show.Id))]
	public int ShowId { get; set; }
	public DateTime ShowDate { get; set; }
	public DateTime ShowTime { get; set; }
    [Required]
    public float BasePrice { get; set; }
	public Discount Discount { get; set; }

	// THEATER
	[Required]
	[ForeignKey(nameof(Theater.Id))]
	public int TheaterId { get; set; }

    // SEAT
    [Required]
	[ForeignKey(nameof(SeatId))]
	public int SeatId { get; set; }
	[Required]
	public int Row { get; set; }
}
