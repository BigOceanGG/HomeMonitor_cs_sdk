using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ocean.sdk.error;
using ocean.sdk.entity;
using ocean.sdk.utils;
using Newtonsoft.Json;

namespace ocean.sdk
{
    public class Application
    {
        public string NodeUrl { get; }

        public Application(string nodeUrl)
        {
            this.NodeUrl = nodeUrl;
        }

        public ApplicationResp FindAppInfo(string id)
        {
            string url = string.Format("{0}/manager/app/findAppInfo?id={1}", NodeUrl, id);
            return this.CallChainAPI<ApplicationResp>(url);
        }

        private T CallChainAPI<T>(string url)
        {
            string json = HttpHelper.Get(url);
            return ParseResponse<T>(json);
        }

        private T CallChainAPI<T>(string url, string jsonData)
        {
            string json = HttpHelper.Post(url, jsonData);
            return ParseResponse<T>(json);
        }

        private T ParseResponse<T>(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception e)
            {
                throw ApiError.FromJson(json);
            }
        }
    }
}
