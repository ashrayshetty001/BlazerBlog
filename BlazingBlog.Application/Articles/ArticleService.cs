using BlazingBlog.Domain.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazingBlog.Application.Articles
{
    public class ArticleService : IArticleService
    {
        public List<Article> GetAllArticles()
        {
            return new List<Article>
            {
                new Article
                {
                    Id = 1,
                    Title="First Article",
                    Content="This is my First Article"
                },new Article
                {
                    Id = 2,
                    Title="Second Article",
                    Content="This is my Second Article"
                }
            };
        }
    }
}
