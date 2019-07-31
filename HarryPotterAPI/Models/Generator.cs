using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace HarryPotterAPI.Models
{
    public class Generator
    {
        public List<Character> RetrieveGryffindors()
        {

            string url = "http://hp-api.herokuapp.com/api/characters";

            using(var WebClient = new WebClient())
            {
                try
                {
                    var request = WebClient.DownloadString(url);
                    var response = JsonConvert.DeserializeObject<List<Character>>(request);
                    return response;
                }
                catch (Exception)
                {
                    throw;
                }
                
            }
            
        }

        public List<Character> RetrieveSlytherins()
        {

            string url = "http://hp-api.herokuapp.com/api/characters";

            using (var WebClient = new WebClient())
            {
                try
                {
                    var request = WebClient.DownloadString(url);
                    var response = JsonConvert.DeserializeObject<List<Character>>(request);
                    return response;
                }
                catch (Exception)
                {
                    throw;
                }

            }

        }

        public List<Character> RetrieveHufflepuffs()
        {

            string url = "http://hp-api.herokuapp.com/api/characters";

            using (var WebClient = new WebClient())
            {
                try
                {
                    var request = WebClient.DownloadString(url);
                    var response = JsonConvert.DeserializeObject<List<Character>>(request);
                    return response;
                }
                catch (Exception)
                {
                    throw;
                }

            }

        }

        public List<Character> RetrieveRavenclaws()
        {

            string url = "http://hp-api.herokuapp.com/api/characters";

            using (var WebClient = new WebClient())
            {
                try
                {
                    var request = WebClient.DownloadString(url);
                    var response = JsonConvert.DeserializeObject<List<Character>>(request);
                    return response;
                }
                catch (Exception)
                {
                    throw;
                }

            }

        }


        ////public List<Character> RetrieveSelect(bool check)
        ////{

        ////    string url = "http://hp-api.herokuapp.com/api/characters";
        ////    using (var WebClient = new WebClient())
        ////    {
        ////        var request = WebClient.DownloadString(url);
        ////        var response = JsonConvert.DeserializeObject<List<Character>>(request);

        ////        try
        ////        {
        ////            if (check == true)
        ////            {
        ////                var result = response.Where(n => n.Gender == "female").OrderBy(n => n.Name).ToList();
        ////                //var result = response.OrderBy(n => n.Name);
        ////                return result;
        ////            }
        ////            else
        ////            {
        ////                var result = response.ToList();
        ////                return result;
        ////            }

        ////        }
        ////        catch (Exception)
        ////        {
        ////            throw;
        ////        }

        ////    }

        ////}

    }
}
