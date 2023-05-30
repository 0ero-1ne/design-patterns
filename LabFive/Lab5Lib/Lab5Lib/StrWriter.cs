namespace Lab5Lib
{
    public class StrWriter : IWriter
    {
        public string? Save(string? message)
        {
            if (message is null)
            {
                return "";
            }

            return message;
        }
    }
}