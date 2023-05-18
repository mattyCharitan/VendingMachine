namespace VendingMachine.State
{
    public class Purchase
    {
        private StateClass currentState;

        public Purchase()
        {
        }

        public void SetState(StateClass state)
        {
            currentState = state;
        }

        public void Choose()
        {
            currentState.choose();
        }

        public void Package()
        {
            currentState.package();
        }

        public void Pay()
        {
            currentState.pay();
        }

        public void Cancel()
        {
            currentState.cancel();
        }
    }
}