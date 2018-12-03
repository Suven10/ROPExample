/// ===========================================
/// Database functions
/// ===========================================
module CustomerRepository

    open CommonLibrary 
    open DomainTypes

    let updateDatabase input =
       ()   // dummy dead-end function for now

    // new function to handle exceptions
    let updateDatebaseStep<'obj> = 
        tryCatch (tee updateDatabase) (fun ex -> ex.Message)
