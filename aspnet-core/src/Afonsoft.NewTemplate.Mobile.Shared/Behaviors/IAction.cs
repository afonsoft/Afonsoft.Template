using Xamarin.Forms.Internals;

namespace Afonsoft.NewTemplate.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}