namespace VendingMachine.State
{
    public class Purchase
    {
        

        public StateClass currentState;
        public Product product { get; set; }


        public Purchase()
        {
        }

        public void SetState(StateClass state)
        {
            currentState = state;
        }
    
          
}
}