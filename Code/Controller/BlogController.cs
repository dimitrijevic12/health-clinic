/***********************************************************************
 * Module:  BlogService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.BlogService
 ***********************************************************************/

using Model.Surveys;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class BlogController : IBlogController
   {
        private static BlogController instance = null;

        private BlogController()
        {
        }

        public static BlogController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BlogController();
                }
                return instance;
            }
        }
        public Blog GetBlogByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Delete(Blog obj)
        {
            throw new NotImplementedException();
        }

        public Blog Create(Blog obj)
        {
            throw new NotImplementedException();
        }

        public Blog Edit(Blog obj)
        {
            throw new NotImplementedException();
        }

    }
}