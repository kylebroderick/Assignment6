using System;
namespace Bookstore.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        //math to find total number of pages
        public int TotalPages => (int)(Math.Ceiling((decimal)TotalNumItems / ItemsPerPage));

    }
}


