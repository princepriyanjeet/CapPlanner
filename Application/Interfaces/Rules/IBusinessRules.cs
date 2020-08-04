using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Rules
{
    public interface IBusinessRules
    {
        string ErrorMessage { get; set; }
        void ExecuteRules();
    }
}
