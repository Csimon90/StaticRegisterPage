
using Newtonsoft; 

public class SearchResults
    {
        [JsonProperty("count")]
        public int Count {get; set;}

        [JsonProperty("next")]
        public int Count {get; set;}

        [JsonProperty("previous")]
        public int Count {get; set;}

        [JsonProperty("results")]
        public List<T> Results {get; set;}

    }
