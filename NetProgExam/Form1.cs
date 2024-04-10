using LiveCharts;
using LiveCharts.Wpf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NetProgExam.Weather;

namespace NetProgExam
{
    public partial class Form1 : Form
    {
        List<DateTime> time;
        List<double> temp;
        List<int> humidity;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Submit_Click(object sender, EventArgs e)
        {
            time = new List<DateTime>();
            temp = new List<double>();
            humidity = new List<int>();
            using(HttpClient client = new HttpClient())
            {
                string link = $@"https://api.openweathermap.org/data/2.5/onecall?lat={LatitudeTB.Text}&lon={LongitudeTB.Text}&exclude=current,minutely,daily,alerts&appid=ef5ebfda74903c4b21316165b1c7b5de&units=metric&lang=ua";
                HttpResponseMessage response = await client.GetAsync(link);
                string body = await response.Content.ReadAsStringAsync();
                Root data = JsonConvert.DeserializeObject<Root>(body);
                data.hourly.Select(d => new { time = new DateTime(1978, 1, 1).AddSeconds(d.dt), Temp = d.temp, humidity = d.humidity });
                foreach(var item in data.hourly)
                {
                    humidity.Add(item.humidity);
                }
                foreach(var item in data.hourly)
                {
                    temp.Add(item.temp);
                }
                foreach (var item in data.hourly)
                {
                    time.Add(new DateTime(1970, 1, 1).AddSeconds(item.dt));
                }
                List<string> shortDateString = time.ConvertAll(p => p.ToLongDateString() + p.ToShortDateString());
                TempChart.Series = new LiveCharts.SeriesCollection
                {
                        new LineSeries
                        {
                            Title = "Temperature",
                            Values = new ChartValues<double>(temp),
                            PointGeometry = null
                        }
                };
                HumChart.Series = new LiveCharts.SeriesCollection
                {
                        new LineSeries
                        {
                            Title = "Humidity",
                            Values = new ChartValues<int>(humidity),
                            PointGeometry = null
                        }
                    };

                TempChart.AxisX.Clear();
                TempChart.AxisX.Add(new Axis
                {
                    Title = "Time",
                    Labels = shortDateString
                });
                TempChart.AxisY.Clear();
                TempChart.AxisY.Add(new Axis
                {
                    Title = "Temperature",
                    LabelFormatter = val => $"{val}°C"
                });

                HumChart.AxisX.Clear();
                HumChart.AxisX.Add(new Axis
                {
                    Title = "Time",
                    Labels = shortDateString
                });
                HumChart.AxisY.Clear();
                List<string> HumString = new List<string>();
                foreach(var item in humidity)
                {
                    HumString.Add(item.ToString());
                }
                HumChart.AxisY.Add(new Axis
                {
                    Title = "Humidity",
                    Labels = HumString
                });
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
