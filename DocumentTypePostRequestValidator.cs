using FluentValidation;
using DocManager.Application.Contracts.Users.Request;
using DocManager.Application.Data.MySql.Repositories;
using DocManager.Application.Errors;
using DocManager.Application.Helpers;
using DocManager.Application.Contracts.Unity.Request;
using DocManager.Application.Contracts.DocumentType.Request;

namespace DocManager.Application.Validators
{
    public class DocumentTypePostRequestValidator: AbstractValidator<DocumentTypePostRequest>
    {
        public DocumentTypePostRequestValidator(DocumentTypeRepository repository)
        {
            RuleFor(contract => contract.internalId)
                .Must(_internalId => !string.IsNullOrEmpty(_internalId))
                .WithMessage(DocManagerErrors.DocumentType_Post_BadRequest_InternalId_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.Name)
                .Must(_name => !string.IsNullOrEmpty(_name))
                .WithMessage(DocManagerErrors.DocumentType_Post_BadRequest_Name_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.Description)
                .Must(_Description => !string.IsNullOrEmpty(_Description))
                .WithMessage(DocManagerErrors.DocumentType_Post_BadRequest_Description_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.Name)
                .Must(_name=> !string.IsNullOrEmpty(_name))
                .WithMessage(DocManagerErrors.DocumentType_Post_BadRequest_Name_Cannot_Be_Duplicated.Description());

            RuleFor(contract => contract.Name)
                .Must(name =>
                {
                    var nameExists = repository.DocumentTypeGetByIdAsync(name).Result;
                    return nameExists == null;
                })
                .WithMessage(DocManagerErrors.DocumentType_Post_BadRequest_Name_Cannot_Be_Duplicated.Description());

                RuleFor(contract => contract.Active)
                .Must(_active => !(_active == true || _active == false))
                .WithMessage(DocManagerErrors.DocumentType_Post_BadRequest_Active_Cannot_Be_Diferent_True_Or_False.Description());

            RuleFor(contract => contract.CreatedDate)
                .Must(_CreatedDate => !string.IsNullOrEmpty(_CreatedDate))
                .WithMessage(DocManagerErrors.DocumentType_Post_BadRequest_CreatedDate_Cannot_Be_Null_Or_Empty.Description());    

        




            
        }
    }
}
