namespace LabOne
{
    class Button : IClickable
    {
        protected string ButtonType { get; set; }
        protected bool State { get; private set; }

        public Button()
        {
            ButtonType = "Simple button";
        }

        public Button(bool state)
        {
            State = state;
            ButtonType = "Simple button";
        }

        public void Click()
        {
            State = !State;
        }

        public virtual string GetButtonType() => "Simple method: " + ButtonType;
        public bool GetState() => State;
    }
}
