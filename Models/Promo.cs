namespace PriscilaZuniga_WebCodeFirst.Models
{
    public class Promo
    {
        public int PromoID { get; set; }
        public string? Description { get; set; }
        public DateTime FechaPromo { get; set; }


        //Definicion de clave foranea
        public int BurgerID { get; set; }

        //Definicion de una propiedad
        public Burger? Burger { get; set; }



    }
}
