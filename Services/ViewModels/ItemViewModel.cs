using CreativeWizardry.Modules.ModuleStarter.Components;
using Newtonsoft.Json;

namespace CreativeWizardry.Modules.ModuleStarter.Services.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemViewModel
    {
        public ItemViewModel(Item t)
        {
            Id = t.ItemId;
            Name = t.ItemName;
            Description = t.ItemDescription;
            AssignedUser = t.AssignedUserId;
        }

        public ItemViewModel() { }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("assignedUser")]
        public int AssignedUser { get; set; }
       
    }
}