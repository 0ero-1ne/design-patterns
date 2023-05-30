namespace LabOne
{
    class RadioButton : Button
    {
        public RadioButton()
        {
            ButtonType = "Radio button";
        }

        public RadioButton(bool state) : base(state)
        {
            ButtonType = "Radio button";
        }

        public override string GetButtonType() => "Overrided method: " + ButtonType;
    }
}
