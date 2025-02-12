using System.ComponentModel.DataAnnotations;

namespace cursce.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Year { get; set; } = 2025;
        public string CauseOfDeath { get; set; } = "Сердечный приступ";
        public bool IsLegend { get; set; } = false;
    }
}
