namespace LabTwo
{
    interface I1
    {
        int PropertyI1 { get; set; }
        int Sum(int a, int b);
        event PrintMessage Messaged;
        string this [int index] { get; set; }
    }
}