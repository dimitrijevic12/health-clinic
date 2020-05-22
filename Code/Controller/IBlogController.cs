/***********************************************************************
 * Module:  IBlogController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IBlogController
 ***********************************************************************/

using System;

namespace Controller
{
   public interface IBlogController : IController
   {
      Model.Surveys.Blog GetBlogByTitle(String title);
   }
}