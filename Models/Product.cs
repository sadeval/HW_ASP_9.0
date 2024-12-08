using System.ComponentModel.DataAnnotations;

namespace HW_ASP_9._0.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название обязательно.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Цена обязательна.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Цена должна быть положительным числом.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Категория обязательна.")]
        public string Category { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
