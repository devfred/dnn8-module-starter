using DotNetNuke.Entities.Users;
using Newtonsoft.Json;

namespace CreativeWizardry.Modules.ModuleStarter.Services.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class UserViewModel
    {
        public UserViewModel(UserInfo t)
        {
            Id = t.UserID;
            Name = t.DisplayName;
        }

        public UserViewModel() { }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}