/***********************************************************************
 * Module:  IBlogService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IBlogService
 ***********************************************************************/

using System;

namespace Service
{
   public interface IBlogService : IService
   {
      Model.Surveys.Blog GetBlogByTitle(String title);
   }
}