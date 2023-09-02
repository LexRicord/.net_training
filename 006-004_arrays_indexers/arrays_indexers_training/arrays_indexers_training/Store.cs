using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace arrays_indexers_training
{
    internal class Store
    {
        private Article[] articles;

        public Store(int size)
        {
            articles = new Article[size];
        }

        public void addArticle(Article article, int index)
        {
            if (index >= 0 && index < articles.Length)
            {
                articles[index] = article;
            }
        }

        public void displayArticleByIndex(int index)
        {
            if (articles[index] != null || index >= 0 || index < articles.Length)
            {
                articles[index].displayInfo();
            }
            else
            {
                Console.WriteLine("Toвара с таким названием не существует");
            }
        }

        public void displayArticleByName(string productName)
        {
            bool foundArticle = false;
            foreach (Article article in articles)
            {
                if (article != null && article.getProductName() == productName)
                {
                    article.displayInfo();
                    foundArticle = true;
                    break;
                }
            }
            if (foundArticle == false)
            {
                Console.WriteLine("Товар с таким названием не найден");
            }
        }
    }
}
