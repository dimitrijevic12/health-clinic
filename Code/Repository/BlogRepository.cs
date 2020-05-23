/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.Surveys;
using System;

namespace Repository
{
   public class BlogRepository : IBlogRepository
   {
      private String Path;

        public bool CloseFile(string path)
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

        public Blog GetBlog(string title)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public Blog Save(Blog obj)
        {
            throw new NotImplementedException();
        }
    }
}