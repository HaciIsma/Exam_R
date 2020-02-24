using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

namespace Exam_R.UserControls
{
    public partial class FoodsControl : UserControl
    {
        List<Meal> meals1 = new List<Meal>();
        public FoodsControl()
        {
            InitializeComponent();
            DownloadMeals();
        }
        private async void DownloadMeals()
        {
            for (int i = pics.Items.Count; i < 20; i++)
            {
                HttpClient client = new HttpClient();
                string url = await client.GetStringAsync(new Uri("https://www.themealdb.com/api/json/v1/1/random.php"));
                var meals = JsonConvert.DeserializeObject<ResponseObject>(url);

                if (meals1.Count != 0)
                {
                    for (int k = 0; k < meals1.Count - 1; k++)
                    {
                        if (meals1[k].strMeal == meals[0].strMeal)
                        {
                            DownloadMeals();
                            return;
                        }
                    }
                }

                string str = meals[0].strMealThumb;
                using (var ms = new MemoryStream(await client.GetByteArrayAsync(new Uri(str))))
                {
                    Image img = Image.FromStream(ms);
                    pics.Items.Add("", img);
                }
            }
        }
    }
}
