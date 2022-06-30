﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace PKAR.Domain
{

    public interface IUserModel : INotifyPropertyChanged
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime BirthDate { get; set; }

        string Versicherungsart { get; set; }
        
    }
}