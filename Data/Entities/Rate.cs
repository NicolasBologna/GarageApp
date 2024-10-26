using System.ComponentModel.DataAnnotations;

public class Rate
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    [Range(0, double.MaxValue)]
    public double Value { get; set; } = 0;
}
