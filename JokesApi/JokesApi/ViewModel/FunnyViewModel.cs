using JokesApi.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JokesApi.ViewModel
{
    public class FunnyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string joke;
        public Command gotoCmd { get; set; }

        public FunnyViewModel()
        {
            gotoCmd = new Command(gotojoke);
        }
        private void gotojoke(object obj)
        {
            GetJoke();
        }
        string Base_url = "https://sv443.net/jokeapi/v2/joke/Any?type=single";
        public async Task<Jokes> GetJoke()
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(Base_url);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();

                var json = JsonConvert.DeserializeObject<Jokes>(result);

                joke = json.joke.ToString();

                return json;

            }

            return null;
        }
    }
}
