using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using InventaryMangement;
using Newtonsoft.Json;

namespace InventoryManagement
{
    public class FetchInventoryDetails
    {

        public Details Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();

                    return JsonConvert.DeserializeObject<Details>(json);

                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }
}

