using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NYTimes
{
    // This class implements and read the book API attibutes such as the author, the publisher etc.. 
    
    public class NYTimes : ObservableCollection<NYTimess>{

        private static NYTimes current = null;

        public static NYTimes Current {

            get {

                if (current == null) {

                    current = new NYTimes();

                    return current;
                }
            }
        }

        private NYTimes() {

            LoadData();
        }

        public async void LoadData() {

            string url = "http://api.nytimes.com/svc/books/v2/lists/hardcover-fiction.json?&offset=&sortby=&sortorder=&api-key=Flwe5Zy30VqegUA726XAojvF5nphOhbw";

            HttpResponseMessage response = await client.GetAsync(url);

            string jsonData = await response.Content.ReadAsStringAsync();

            JsonObject jsonObject = jsonObject.Parse(jsonData);

            var resultObject = jsonObject.GetObject();

            var result = resultObject["results"].GetArray();

            foreach (var item in result) {

                JsonObject bookdetails = item.GetObject().GetNamedValue("book details").GetArray()[0].GetObject();

                NYTimess book = new NYTimess();

                book.Title = bookdetails.GetNamedString("title");

                book.Description = bookdetails.GetNamedString("description");

                book.Author = bookdetails.GetNamedString("author");

                book.Price = bookdetails.GetNamedString("price");

                book.Publisher = bookdetails.GetNamedString("publisher");

                Add(book);


            }
        }
        
        
    }
}
