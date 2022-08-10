/**
 * 游戏战斗的启动数据
 */

using System.Collections.Generic;

namespace BattleSystem
{
    public class BattleParam
    {
        /// <summary>
        /// 随机数种子，用于在不同的客户端产生相同的随机数
        /// </summary>
        public int RandSeed = 0;
        /// <summary>
        /// 玩家列表
        /// </summary>
        public List<PlayerData> Players = new List<PlayerData>();
    }
}