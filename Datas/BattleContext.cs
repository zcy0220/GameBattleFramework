/**
 * 单局游戏战斗中的上下文数据
 * 保存战斗全局参数
 */

namespace BattleSystem
{
    public class BattleContext
    {
        /// <summary>
        /// 战斗启动参数
        /// </summary>
        public BattleParam LauncherParam;
        /// <summary>
        /// 当前执行到的帧数
        /// </summary>
        public int CurrentFrameIndex = 0;
    }
}