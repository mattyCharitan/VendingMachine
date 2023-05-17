namespace VendingMachine.State
{
    public class Context
    {
        private StateClass currentState;

        public Context(StateClass initialState)
        {
            currentState = initialState;
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