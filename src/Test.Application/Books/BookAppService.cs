﻿using System;
using Test.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Test.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = TestPermissions.Books.Default;
        GetListPolicyName = TestPermissions.Books.Default;
        CreatePolicyName = TestPermissions.Books.Create;
        UpdatePolicyName = TestPermissions.Books.Edit;
        DeletePolicyName = TestPermissions.Books.Delete;
    }
}