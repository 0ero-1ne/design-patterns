using System.Security.Cryptography;
using System.Text;

namespace Lab5Lib
{
    public class DecSHA512 : Decorator
    {
        public DecSHA512(IWriter writer) : base(writer) { }

        public override string? Save(string? message)
        {
            using (var sha512 = SHA512.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(message!);
                byte[] hashBytes = sha512.ComputeHash(inputBytes);

                return writer!.Save(message + Constant.Delimiter + Convert.ToBase64String(hashBytes));
            }
        }
    }
}