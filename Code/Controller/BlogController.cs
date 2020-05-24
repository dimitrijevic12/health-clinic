/***********************************************************************
 * Module:  BlogService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.BlogService
 ***********************************************************************/

using Model.Surveys;
using System;

namespace Controller
{
   public class BlogController : IBlogController
   {
      public Service.BlogService blogService;

        public Blog Create(Blog obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Blog obj)
        {
            throw new NotImplementedException();
        }

        public Blog Edit(Blog obj)
        {
            throw new NotImplementedException();
        }

        public Blog[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Blog GetBlogByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}