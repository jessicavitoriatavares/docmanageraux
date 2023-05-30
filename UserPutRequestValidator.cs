using FluentValidation;
using DocManager.Application.Contracts.Users.Request;
using DocManager.Application.Data.MySql.Repositories;
using DocManager.Application.Errors;
using DocManager.Application.Helpers;
using DocManager.Application.Contracts.DocumentType.Request;
using DocManager.Application.Contracts.UserRepository.Request;


namespace DocManager.Application.Validators
{
    public class UserPutRequestValidator : AbstractValidator<UserPutRequest>
    {
     public UserPutRequestValidator(UserRepository repository)
        {
            RuleFor(contract => contract.Email)
                .Must(email => !string.UserPutBadRequestUserNotFound(email))
                .WithMessage(Email_Put_BadRequest_User_Not_Found.Description());

            RuleFor(product => product.email)
                .Must(email =>
                {
                    var exists = repository.GetUserByEmail(email).Result;
                    return exists == null;
                })
                .WithMessage(SysManagerErrors.Product_Post_BadRequest_Name_Cannot_Be_Duplicated.Description());
            
        }
    }  
}