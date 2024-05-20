namespace Anyar.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname {  get; set; }
        public string ImageUrl {  get; set; }
        public ICollection<Work>Works { get; set; }
         


    }
}
