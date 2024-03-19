namespace Tema2Console
{
    public class Order
    {
        public OrderType Type { get; set; }

        #region Room Order
        public int Quantity { get; set; }  
        public decimal Price { get; set; }   
        public string ReservationDate { get; set; }  
        //public string Name { get; set; }   
        //public string ServingDate { get; set; }    
        #endregion
        
        #region Product Order
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }      
        public decimal ProductPrice { get; set; }
        #endregion
        
        #region Breakfast Order
        public int BreakfastQuantity { get; set; }
        public int BreakfastPrice { get; set; }
        public string BreakfastServingDate { get; set; }
        #endregion
        
        #region LunchOrder
        public int LunchQuantity { get; set; }
        public int LunchPrice { get; set; }
        public string LunchServingDate { get; set; }
        #endregion
        
        #region Dinner Order
        public int DinnerQuantity { get; set; }
        public int DinnerPrice { get; set; }
        public string DinnerServingDate { get; set; }
        #endregion
        
    }
}
