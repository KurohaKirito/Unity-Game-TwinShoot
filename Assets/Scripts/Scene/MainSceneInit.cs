using Kuroha.Framework.Launcher;
using Kuroha.Framework.UI.Manager;
using UI.UI_Title;
using UnityEngine;

namespace Scene
{
    public class MainSceneInit : SceneInitializer
    {
        protected override void SceneInit()
        {
            Debug.Log("111");
            UIManager.Instance.Panel.Open<UI_Title_Controller>();
        }
    }
}
