using System.ComponentModel;

namespace DocManager.Application.Errors
{
    public enum DocManagerErrors
    {
        #region User
        [Description("Necessário informar a propriedade (Username)")]
        User_Post_BadRequest_UserName_Cannot_Be_Null_Or_Empty,

        [Description("Necessário informar a propriedade (Email)")]
        User_Post_BadRequest_Email_Cannot_Be_Null_Or_Empty,

        [Description("Necessário informar a propriedade (Password)")]
        User_Post_BadRequest_Password_Cannot_Be_Null_Or_Empty,

        [Description("Ja existe um usuário cadastraco com esse e-mail")]
        User_Post_BadRequest_Email_Cannot_Be_Duplicated,

        [Description("Usuário ou e-mail inválido ou inexistente")]
        User_Put_BadRequest_User_Not_Found,
        #endregion 



        #region documentType
        [Description("É necessário colocar um número para o id")]
        documentType_Post_BadRequest_Id_Cannot_Be_Null_Or_Empty,
        [Description("É necessário colocar um nome para o tipo do documento")]
        documentType_Post_BadRequest_Name_Cannot_Be_Null_Or_Empty,
        [Description("É necessário colocar um nome para o tipo do documento")]
        documentType_Put_BadRequest_Name_Cannot_Be_Null_Or_Empty,
        [Description("Já existe um tipo de documento com esse nome")]
        documentType_Post_BadRequest_Name_Cannot_Be_Duplicated,
        [Description("É necessário colocar uma descrição para o documento")]
        documentType_Post_BadRequest_Description_Cannot_Be_Null_Or_Empty,
        [Description("É necessário informar se o tipo do documento está ativo ou inativo")]
        documentType_Put_BadRequest_Active_Cannot_Be_Diferent_True_Or_False,
        [Description("É necessário colocar a data de criação do tipo de documento")]
        documentType_Post_BadRequest_CreatedDate_Cannot_Be_Null_Or_Empty,
        [Description("Esse tipo de documento não pode ser excluído pois está sendo referenciado em um documento")]"
        documentType_Delete_BadRequest_Name_This_document_type_cannot_be_deleted_as_it_is_being_referenced_in_a_document,

        #endregion

        #region documentPartners
        [Description("É necessário colocar um número para o id  do associado")]
        documentPartners_Post_BadRequest_Id_Cannot_Be_Null_Or_Empty,
        [Description("É necessário colocar o nome do associado")]
        documentPartners_Post_BadRequest_Name_Cannot_Be_Null_Or_Empty,
        [Description("É necessário colocar uma descrição para o documento")]
        documentPartners_Post_BadRequest_Description_Cannot_Be_Null_Or_Empty,
        [Description("É necessário informar se o associado está ativo ou inativo")]
        documentPartners_Put_BadRequest_Active_Cannot_Be_Diferent_True_Or_False,
        [Description("É necessário colocar a data de inicio da parceria")]
        documentPartners_Post_BadRequest_CreatedDate_Cannot_Be_Null_Or_Empty,

        #endregion


        #region documents
         [Description("É necessário colocar um número para o id")]
        documents_Post_BadRequest_Id_Cannot_Be_Null_Or_Empty,
        [Description("É necessário inserir um titulo para o documento")]
        documents_Post_BadRequest_Title_Cannot_Be_Null_Or_Empty,
        [Description("É necessário inserir o id da parceria")]
        documents_Post_BadRequest_DocumentPartnersId_Cannot_Be_Null_Or_Empty,
        [Description("É necessário colocar uma descrição para o documento")]
        documents_Post_BadRequest_Description_Cannot_Be_Null_Or_Empty,
        [Description("É necessário colocar o tipo do documento")]
        documents_Post_BadRequest_DocumentTypeId_Cannot_Be_Null_Or_Empty,
        [Description("É necessário colocar a url do documento")]
        documents_Post_BadRequest_Url_Cannot_Be_Null_Or_Empty,
        [Description("É necessário colocar a data de vigencia do documento")]
        documents_Post_BadRequest_Validity_Cannot_Be_Null_Or_Empty,
        [Description("É necessário informar se o documento está ativo ou inativo")]
        documents_Put_BadRequest_Active_Cannot_Be_Diferent_True_Or_False,
        [Description("É necessário colocar a data de criação do registro")]
        documents_Post_BadRequest_CreationDate_Cannot_Be_Null_Or_Empty,
        [Description("O documento é inválido ou inexistente")]
        documents_Delete_BadRequest_Id_Is_Invalid_Or_Inexistent,

        #endregion

    }
}
