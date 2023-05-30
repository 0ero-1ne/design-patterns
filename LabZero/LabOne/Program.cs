using System;

namespace LabOne
{
    class Program
    {
        static void Main()
        {
            Button button = new Button(true);
            Console.WriteLine(button.GetState());
            button.Click();
            Console.WriteLine(button.GetState());
            Console.WriteLine(button.GetButtonType() + "\n");

            RadioButton radioButton = new RadioButton();
            Console.WriteLine(radioButton.GetButtonType());
            Console.WriteLine(radioButton.GetState());
            radioButton.Click();
            Console.WriteLine(radioButton.GetState());
        }
    }
}
