using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ProCampaign.Models
{
    public class CrmData
    {
        public dynamic Data { get; set; }

        public CrmData()
        {
            Data = new ExpandoObject();
        }

        public void AddSetting(string key, object value)
        {
            var p = Data as IDictionary<string, object>;
            p[key] = value;
        }

        public T GetSetting<T>(string key)
        {
            var p = Data as IDictionary<string, object>;

            return p.ContainsKey(key) ? (T)p[key] : default;
        }
    }
}
