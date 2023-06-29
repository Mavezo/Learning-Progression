using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NP_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpRequestMessage httpRequest = new HttpRequestMessage())
                {
                    httpRequest.Method = HttpMethod.Get;
                    httpRequest.RequestUri = new Uri("https://uk.wikipedia.org/wiki/HTTP");
                    HttpResponseMessage httpResponse = await client.SendAsync(httpRequest);
                    MessageBox.Show($"Status code: {httpResponse.StatusCode}, Reason Phrase: {httpResponse.ReasonPhrase}");
                    listBox1.Items.Clear();
                    foreach (var header in httpResponse.Headers)
                    {
                        foreach (string val in header.Value)
                        {
                            listBox1.Items.Add($"{header.Key}::{val}");

                        }
                    }
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    textBox1.Text = content;

                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpRequestMessage httpRequest = new HttpRequestMessage())
                {
                    httpRequest.Method = HttpMethod.Get;
                    httpRequest.RequestUri = new Uri("https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=5");
                    HttpResponseMessage httpResponse = await client.SendAsync(httpRequest);
                    MessageBox.Show($"Status code: {httpResponse.StatusCode}, Reason Phrase: {httpResponse.ReasonPhrase}");
                    listBox1.Items.Clear();
                    foreach (var header in httpResponse.Headers)
                    {
                        foreach (string val in header.Value)
                        {
                            listBox1.Items.Add($"{header.Key}::{val}");

                        }
                    }
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    textBox1.Text = content;

                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpRequestMessage httpRequest = new HttpRequestMessage())
                {
                    httpRequest.Method = HttpMethod.Get;
                    httpRequest.RequestUri = new Uri("https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=5");
                    HttpResponseMessage httpResponse = await client.SendAsync(httpRequest);
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    List<ExchangeRate>? rates = JsonSerializer.Deserialize<List<ExchangeRate>>(content);
                    
                    
                    textBox1.Text = content;
                    comboBox1.DataSource = null;
                    comboBox1.DisplayMember = nameof(ExchangeRate.ccy);
                    comboBox1.DataSource = rates; 
                    //1:16:33
                }
            }
        }
    }
}