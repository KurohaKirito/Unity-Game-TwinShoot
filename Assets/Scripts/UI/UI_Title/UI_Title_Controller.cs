using Kuroha.Framework.UI.Panel;
using Kuroha.Util.RunTime;

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

        public override void Reset()
        {
            base.Reset();
            
            UGUIButtonUtil.AddListener(View.startGame, () =>
            {
                DebugUtil.Log("点击了开始游戏按钮!", null, "green");
            });
        }
    }
}
