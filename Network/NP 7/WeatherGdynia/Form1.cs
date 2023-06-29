using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherGdynia;

namespace WeatherGdynia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpRequestMessage httpRequest = new HttpRequestMessage())
                {
                    httpRequest.Method = HttpMethod.Post;
                    httpRequest.RequestUri = new Uri(@"https://api.openweathermap.org/data/2.5/forecast?lat=54.52333035&lon=18.604027892041863&appid=66188ec445d9f392019caa0906b0d25b&units=metric");
                    HttpResponseMessage httpResponce = await httpClient.SendAsync(httpRequest);
                    string content = await httpResponce.Content.ReadAsStringAsync();
                    Root weatherGdynia = JsonSerializer.Deserialize<Root>(content);
                    label1.Text = weatherGdynia.city.name;
         

                    StringBuilder sb = new StringBuilder();
                    ChartValues<double> points = new ChartValues<double>();

                    foreach (var item in weatherGdynia.list)
                    {
                        sb.AppendLine(DateTime.Parse(item.dt_txt).ToLocalTime().ToString());
                        points.Add(item.main.temp);
                    }

                    string[] str = sb.ToString().Split('\r');
                    cartesianChart1.AxisX.Clear();

                    cartesianChart1.AxisX.Add(new Axis
                    {
                        Title = "Date",
                        Labels = str
                    });

                    cartesianChart1.Series.Clear();

 

                    cartesianChart1.Series = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Title = "Temperature",
                            Values = points,
                        }
                    };


                }
            }

        }
    }
}
