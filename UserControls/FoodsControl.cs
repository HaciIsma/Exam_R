using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

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
            HttpClient client = new HttpClient();
            for (int i = pics.Items.Count; i < 20;)
            {
                string url = await client.GetStringAsync(new Uri("https://www.themealdb.com/api/json/v1/1/random.php"));
                var meals = JsonConvert.DeserializeObject<ResponseObject>(url);
                if (meals1.Count != 0)
                {
                    for (int k = 0; k < meals1.Count - 1; k++)
                    {
                        if (meals1[k].idMeal == meals[0].idMeal)
                        {
                            continue;
                        }
                    }
                }


                string str = meals[0].strMealThumb;
                using (var ms = new MemoryStream(await client.GetByteArrayAsync(new Uri(str))))
                {
                    Image img = Image.FromStream(ms);
                    pics.Items.Add("", img);
                }
                i++;
            }
        }

        private void pics_ItemClick(object sender, Manina.Windows.Forms.ItemClickEventArgs e)
        {

        }
    }
}
