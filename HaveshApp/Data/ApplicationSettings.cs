using System.ComponentModel.DataAnnotations.Schema;

namespace ShokouhApp.Data;

public partial class ApplicationSettings
{
    [NotMapped]
    public static string CurrentTermId => nameof(CurrentTermId);

    [NotMapped]
    public static string PreRegistrationTermId => nameof(PreRegistrationTermId);

    [NotMapped]
    public Dictionary<string, int> SettingsKeyCat { get; set; } = new()
    {
        [CurrentTermId] = 3,
        [PreRegistrationTermId] = 4,
    };
}



public partial class ApplicationSettings
{
    public int Id { get; set; }

    public int SettingCategoryFk{ get; set; }

    [ForeignKey(nameof(SettingCategoryFk))]
    public ApplicationSettingsCategory SettingsCategory { get; set; }

    public string SettingKey { get; set; }
    public string SettingValue { get; set; }
}



public class ApplicationSettingsCategory
{
    public int Id { get; set; }
    [ForeignKey(nameof(Id))]
    public int? ParentCategoryFk { get; set; }
    public string CategoryTitle { get; set; }

}

