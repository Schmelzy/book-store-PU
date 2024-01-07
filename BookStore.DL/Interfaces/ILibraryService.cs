using BookStore.Models.Models;
using BookStore.Models.Requests;
using BookStore.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Interfaces
{
    public interface ILibraryService

    {
        GetAllBooksByAuthorResponse?
            GetAllBooksByAuthorAfterDate(GetAllBooksByAuthorRequest request);

    }
}
