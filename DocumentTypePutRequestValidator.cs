using FluentValidation;
using DocManager.Application.Contracts.Users.Request;
using DocManager.Application.Data.MySql.Repositories;
using DocManager.Application.Errors;
using DocManager.Application.Helpers;
using DocManager.Application.Contracts.Unity.Request;
using DocManager.Application.Contracts.DocumentType.Request;

namespace DocManager.Application.Validators
{
    public class DocumentTypePutRequestValidator: AbstractValidator<DocumentTypePutRequest>
    {
       public UserPostRequestValidator(UserRepository repository)
        {
              RuleFor(contract => contract.Name)
                .Must(_name => !string.IsNullOrEmpty(_name))
                .WithMessage(DocManagerErrors.DocumentType_Put_BadRequest_Name_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.Active)
                .Must(_active => !(_active == true || _active == false))
          .WithMessage(DocManagerErrors.DocumentType_Put_BadRequest_Active_Cannot_Be_Diferent_True_Or_False.Description());

           
        }
    }
}
