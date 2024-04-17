using System.ComponentModel.DataAnnotations;

namespace PriscilaZuniga_WebCodeFirst.Models
{
    public class Burger
    {
        public int BurgerID { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }

        //Relacion de una hamburguesa con lista de promos
        public List<Promo>? Promo { get; set; }
        
        
    }
}
