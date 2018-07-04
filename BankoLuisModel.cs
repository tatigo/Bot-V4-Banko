// <auto-generated>
// Code generated by LUISGen BankoLuisModel.json -cs AspNetCore_EchoBot_With_State.BankoLuisModel -o 
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Newtonsoft.Json;
using System.Collections.Generic;
namespace AspNetCore_EchoBot_With_State
{
    public class BankoLuisModel: Microsoft.Bot.Builder.Core.Extensions.IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            Balance, 
            None, 
            Transfer
        };
        public Dictionary<Intent, Microsoft.Bot.Builder.Ai.LUIS.IntentData> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] Account;

            // Built-in entities
            public Microsoft.Bot.Builder.Ai.LUIS.DateTimeSpec[] datetime;
            public Microsoft.Bot.Builder.Ai.LUIS.Money[] money;

            // Instance
            public class _Instance
            {
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Account;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] datetime;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] money;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public _Entities Entities;

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<BankoLuisModel>(JsonConvert.SerializeObject(result));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }

        public (Intent intent, double score) TopIntent()
        {
            Intent maxIntent = Intent.None;
            var max = 0.0;
            foreach (var entry in Intents)
            {
                if (entry.Value.Score > max)
                {
                    maxIntent = entry.Key;
                    max = entry.Value.Score;
                }
            }
            return (maxIntent, max);
        }
    }
}
