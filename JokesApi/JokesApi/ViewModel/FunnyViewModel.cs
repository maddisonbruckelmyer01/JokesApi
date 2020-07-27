using JokesApi.Model;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JokesApi.ViewModel
{
    public class FunnyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Command gotoCmd { get; set; }

        private Jokes jokes;

        public FunnyViewModel()
        {
            gotoCmd = new Command(gotojoke);

            jokes = new Jokes();
        }
        private void gotojoke(object obj)
        {
            GetJoke();
        }
        string Base_url = "https://sv443.net/jokeapi/v2/joke/Any";

        public async Task<Jokes> GetJoke()
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(Base_url);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();

                var jokes = JsonConvert.DeserializeObject<Jokes>(result);

                return jokes;
            }

            return null;
        }
    }
}
