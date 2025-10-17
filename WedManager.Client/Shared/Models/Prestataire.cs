using System;

namespace WedManager.Client.Shared.Models
{
    public class Prestataire
{
    public int Id { get; set; }
    public string Nom { get; set; } = null!;
    public string Type { get; set; } = null!;
    public string? Telephone { get; set; } = null!;
    public string? Email { get; set; }
    public string? Tarif { get; set; }
    public bool IsAvailable { get; set; }
    public string? Description { get; set; }
}
}
