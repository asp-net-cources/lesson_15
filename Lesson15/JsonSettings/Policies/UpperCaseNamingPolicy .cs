using System.Text.Json;

namespace Lesson14.JsonSettings.Policies;

public class UpperCaseNamingPolicy : JsonNamingPolicy
{
    public override string ConvertName(string name) {
        return name.ToUpper();
    }
}
