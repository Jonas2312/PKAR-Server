using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PKAR.Domain
{
    public class UserModel : IUserModel
    {
        public UserModel()
        {

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Versicherungsart { get ; set; }
        public string PhoneNumber { get; set ; }
        public string EmailAddress { get; set ; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public override string ToString()
        {
            return      $"First name: {FirstName} | Last name: {LastName} | Versicherungsart: {Versicherungsart} | "
                    +   $"EmailAddress: {EmailAddress} | PhoneNumber: {PhoneNumber}";
        }

        public void WriteToFile()
        {
            var guidString = Guid.NewGuid().ToString().Replace("-","");
            File.WriteAllText(@$"C:\Users\jonas\Desktop\TEMP\usermodel{guidString}.txt", ToString());
        }
    }
}
