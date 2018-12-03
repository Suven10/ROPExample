/// ===========================================
/// All the use cases or services in one place
/// ===========================================
module UseCases

    open CommonLibrary
    open DomainTypes

    let handleUpdateRequest<'Request> = 
        Validation.combinedValidation
        >> map Validation.canonicalizeEmail
        >> Logger.log
