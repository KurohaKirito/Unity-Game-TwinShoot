using Kuroha.Framework.Launcher;
using Kuroha.Framework.UI.Manager;
using UI.UI_Title;

namespace Scene
{
    public class GameLauncher : Launcher
    {
        protected void OnStart()
        {
            UIManager.Instance.Panel.Open<UI_Title_Controller>();
        }
    }
}
