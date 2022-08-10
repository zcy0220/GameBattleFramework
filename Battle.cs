/**
 * 战斗启动入口
 */

namespace BattleSystem
{
    public class Battle
    {
        /// <summary>
        /// 全局游戏战斗上下文，保存战斗全局参数
        /// </summary>
        private BattleContext _context;
        /// <summary>
        /// 运行控制参数
        /// </summary>
        private bool _isRunning = false;

        /// <summary>
        /// 开始战斗
        /// </summary>
        /// <param name="param"></param>
        public void Start(BattleParam param)
        {
            _context = new BattleContext();
            _context.LauncherParam = param;
            _context.CurrentFrameIndex = 0;
        }

        /// <summary>
        /// 帧逻辑驱动
        /// </summary>
        public void UpdateFrame()
        {
            if (!_isRunning) return;


            UnityEngine.Debug.Log("测试123123");
        }
    }
}