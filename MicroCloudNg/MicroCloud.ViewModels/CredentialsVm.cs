using FluentValidation.Attributes;
using MicroCloud.ViewModels.Validations;

namespace MicroCloud.ViewModels
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsVm
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
