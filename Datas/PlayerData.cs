/**
 * 玩家数据
 */

namespace BattleSystem
{
    public class PlayerData
    {
        /// <summary>
        /// 单局战斗中玩家分配到的唯一Id，只在单局有效
        /// </summary>
        public int Id;
        /// <summary>
        /// 玩家的队伍Id
        /// </summary>
        public int TeamId;
        /// <summary>
        /// 玩家对应的用户Id
        /// </summary>
        public int UserId;
        /// <summary>
        /// 用户名称
        /// </summary>
        public string Name;
    }
}