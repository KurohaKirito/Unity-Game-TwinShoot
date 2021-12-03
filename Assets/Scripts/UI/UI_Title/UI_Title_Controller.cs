using Kuroha.Framework.UI.Panel;

namespace UI.UI_Title
{
    public class UI_Title_Controller : UIPanelController
    {
        private UI_Title_View View => baseView as UI_Title_View;
        
        /// <summary>
        /// 初始化
        /// </summary>
        public sealed override void Init(in UIPanelView view, in string prefabName)
        {
            base.Init(view, prefabName);
            
            Reset();
        }
    }
}
