using Microsoft.AspNetCore.Components;

namespace FirstBlazorServerApp.BaseComponents
{
    public class DateTimeBaseComponent : ComponentBase
    {
        public DateTime dateTime { get; set; } = DateTime.Now;
    }
}
