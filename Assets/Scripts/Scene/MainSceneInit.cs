using Kuroha.Framework.Launcher;
using Kuroha.Framework.UI.Manager;
using UI.UI_Title;

namespace Scene
{
    public class MainSceneInit : SceneInitializer
    {
        protected override void SceneInit()
        {
            UIManager.Instance.Panel.Open<UI_Title_Controller>();
        }
    }
}
