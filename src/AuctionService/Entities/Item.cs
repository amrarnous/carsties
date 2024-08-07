using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities;

[Table("items")]
public class Item
{
    public Guid Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int Mileage { get; set; }
    public string ImageUrl { get; set; }
    [ForeignKey("AuctionId")]
    public Auction Auction { get; set; }
    public Guid AucitonId { get; set; }
}
