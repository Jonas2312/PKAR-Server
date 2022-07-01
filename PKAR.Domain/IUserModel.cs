using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace PKAR.Domain
{

    public interface IUserModel : INotifyPropertyChanged
    {
        void WriteToFile();
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime BirthDate { get; set; }

        string Versicherungsart { get; set; }

        string PhoneNumber { get; set; }
        string EmailAddress { get; set; }

        string WarumKommenSie { get; set; }
        bool PeriodeAlle4Wochen { get; set; }
        string PeriodeDasLetzteMal { get; set; }
        bool PeriodeProbleme { get; set; }
        string PeriodenProblemDauer { get; set; }
        string PeriodenProblemStaerke { get; set; }
        string PeriodenProblemSchmerzen { get; set; }
        string Abstand2Blutungen { get; set; }

    }
}