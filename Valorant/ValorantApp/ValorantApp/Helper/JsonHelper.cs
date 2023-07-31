using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ValorantApp.Model;

namespace ValorantApp.Helper
{
    public class JsonHelper
    {
        public static void SaveUsersToJson(List<User> users)
        {
            if (!Directory.Exists($"{Directory.GetCurrentDirectory()}\\data"))
            {
                Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}\\data");
            }

            var json = JsonSerializer.Serialize(users); //convierte lista en tipo json
            File.WriteAllText($"{Directory.GetCurrentDirectory()}\\data\\users.json", json);
        }
    }
}
