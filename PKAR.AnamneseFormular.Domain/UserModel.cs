using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PKAR.AnamneseFormular.Domain
{
    public class UserModel : IUserModel
    {
        public UserModel()
        {
            FirstName = string.Empty;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Versicherungsart { get ; set; }
        public string PhoneNumber { get; set ; }
        public string EmailAddress { get; set ; }
        public string WarumKommenSie { get;set; }

        public bool PeriodeAlle4Wochen { get;set; }
        public string PeriodeDasLetzteMal { get; set; }
        public bool PeriodeProbleme { get; set; }
        public string PeriodenProblemDauer { get; set; }
        public string PeriodenProblemStaerke { get; set; }
        public string PeriodenProblemSchmerzen { get; set; }
        public string Abstand2Blutungen { get; set; }



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

        public void WriteToFile(string userName)
        {
            var guidString = Guid.NewGuid().ToString().Replace("-", "");
            Directory.CreateDirectory(@$"C:\Users\{userName}\Desktop\TEMP)");
            File.WriteAllText(@$"C:\Users\{userName}\Desktop\TEMP\usermodel{guidString}.txt", ToString());
        }
    }
}
