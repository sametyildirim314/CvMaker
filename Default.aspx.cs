using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Configuration;
using System.Web;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace CVapp
{
    public partial class Default : System.Web.UI.Page
    {
        private readonly string PUBLISHER_ID = ConfigurationManager.AppSettings["IndeedPublisherID"];
        private readonly string API_URL = ConfigurationManager.AppSettings["IndeedApiUrl"];

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SearchJobs("software developer", "Turkey");
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text.Trim();
            string location = txtLocation.Text.Trim();
            SearchJobs(keyword, location);
        }

        private async void SearchJobs(string keyword, string location)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // Indeed API parametreleri
                    var parameters = new Dictionary<string, string>
                    {
                        {"publisher", PUBLISHER_ID},
                        {"q", HttpUtility.UrlEncode(keyword)},
                        {"l", HttpUtility.UrlEncode(location)},
                        {"format", "json"},
                        {"v", "2"},
                        {"limit", "10"},
                        {"sort", "date"}
                    };

                    // Query string oluştur
                    var queryString = string.Join("&", parameters.Select(x => $"{x.Key}={x.Value}"));
                    var url = $"{API_URL}?{queryString}";

                    // API çağrısı yap
                    var response = await client.GetStringAsync(url);
                    var jsonResponse = JObject.Parse(response);

                    // Sonuçları dönüştür
                    var jobs = new List<JobListing>();
                    foreach (var result in jsonResponse["results"])
                    {
                        jobs.Add(new JobListing
                        {
                            Title = (string)result["jobtitle"],
                            Company = (string)result["company"],
                            Location = (string)result["formattedLocation"],
                            Description = (string)result["snippet"],
                            Salary = (string)result["formattedRelativeTime"],
                            PostedDate = (string)result["formattedRelativeTime"],
                            Url = (string)result["url"]
                        });
                    }

                    JobsRepeater.DataSource = jobs;
                    JobsRepeater.DataBind();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Indeed API Hatası: {ex.Message}");
                // Hata durumunda kullanıcıya bilgi ver
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage",
                    $"alert('İş ilanları yüklenirken bir hata oluştu: {ex.Message}');", true);
            }
        }
    }

    public class JobListing
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Salary { get; set; }
        public string PostedDate { get; set; }
        public string Url { get; set; }
    }
}