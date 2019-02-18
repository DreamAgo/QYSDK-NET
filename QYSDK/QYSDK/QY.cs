using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
namespace QYSDK
{
   internal class QY
    {
        #region 常量
        internal readonly static int EVENT_IGNORE = 0;          //事件_忽略
        internal readonly static int EVENT_BLOCK = 1;           //事件_拦截
        internal readonly static int REQUEST_GROUPADD = 0;      //请求_群添加
        internal readonly static int REQUEST_GROUPINVITE = 1;   //请求_群邀请
        internal readonly static int REQUEST_ALLOW = 0;         //请求_通过
        internal readonly static int REQUEST_DENY = 1;          //请求_拒绝
        internal readonly static int LOG_DEBUG = 0;             // 调试       暗淡的灰色       DIMGRAY     6908265   #696969  105,105,105
        internal readonly static int LOG_INFO = 10;             // 信息       纯黑             BLACK       0         #000000  0,0,0
        internal readonly static int LOG_INFOSUCCESS = 11;      // 信息(成功) 深紫罗兰的蓝色   BLUEVIOLET  14822282  #8A2BE2  138,43,226
        internal readonly static int LOG_INFOFAIL = 12;         // 信息(失败) 棕色             BROWN       2763429   #A52A2A  165,42,42
        internal readonly static int LOG_INFORECV = 13;         // 信息(接收) 纯蓝             BLUE        16711680  #0000FF  0,0,255
        internal readonly static int LOG_INFOSEND = 14;         // 信息(发送) 纯绿             GREEN       32768     #008000  0,128,0
        internal readonly static int LOG_WARNING = 20;          // 警告       深橙色           DARKORANGE  36095     #FF8C00  255,140,0
        internal readonly static int LOG_ERROR = 30;            // 错误       深粉色           DEEPPINK    9639167   #FF1493  255,20,147
        internal readonly static int LOG_FATAL = 40;            // 致命错误   纯红             RED         255       #FF0000  255,0,0
        #endregion
        # region 表情
        internal readonly static int FACE_惊讶 = 0;
        internal readonly static int FACE_撇嘴 = 1;
        internal readonly static int FACE_色 = 2;
        internal readonly static int FACE_发呆 = 3;
        internal readonly static int FACE_得意 = 4;
        internal readonly static int FACE_流泪 = 5;
        internal readonly static int FACE_害羞 = 6;
        internal readonly static int FACE_闭嘴 = 7;
        internal readonly static int FACE_睡 = 8;
        internal readonly static int FACE_大哭 = 9;
        internal readonly static int FACE_尴尬 = 10;
        internal readonly static int FACE_发怒 = 11;
        internal readonly static int FACE_调皮 = 12;
        internal readonly static int FACE_呲牙 = 13;
        internal readonly static int FACE_微笑 = 14;
        internal readonly static int FACE_难过 = 15;
        internal readonly static int FACE_酷 = 16;
        internal readonly static int FACE_抓狂 = 18;
        internal readonly static int FACE_吐 = 19;
        internal readonly static int FACE_偷笑 = 20;
        internal readonly static int FACE_可爱 = 21;
        internal readonly static int FACE_白眼 = 22;
        internal readonly static int FACE_傲慢 = 23;
        internal readonly static int FACE_饥饿 = 24;
        internal readonly static int FACE_困 = 25;
        internal readonly static int FACE_惊恐 = 26;
        internal readonly static int FACE_流汗 = 27;
        internal readonly static int FACE_憨笑 = 28;
        internal readonly static int FACE_大兵 = 29;
        internal readonly static int FACE_奋斗 = 30;
        internal readonly static int FACE_咒骂 = 31;
        internal readonly static int FACE_疑问 = 32;
        internal readonly static int FACE_晕 = 34;
        internal readonly static int FACE_折磨 = 35;
        internal readonly static int FACE_衰 = 36;
        internal readonly static int FACE_骷髅 = 37;
        internal readonly static int FACE_敲打 = 38;
        internal readonly static int FACE_再见 = 39;
        internal readonly static int FACE_发抖 = 41;
        internal readonly static int FACE_爱情 = 42;
        internal readonly static int FACE_跳跳 = 43;
        internal readonly static int FACE_猪头 = 46;
        internal readonly static int FACE_拥抱 = 49;
        internal readonly static int FACE_蛋糕 = 53;
        internal readonly static int FACE_闪电 = 54;
        internal readonly static int FACE_炸弹 = 55;
        internal readonly static int FACE_刀 = 56;
        internal readonly static int FACE_足球 = 57;
        internal readonly static int FACE_便便 = 59;
        internal readonly static int FACE_咖啡 = 60;
        internal readonly static int FACE_饭 = 61;
        internal readonly static int FACE_玫瑰 = 63;
        internal readonly static int FACE_凋谢 = 64;
        internal readonly static int FACE_爱心 = 66;
        internal readonly static int FACE_心碎 = 67;
        internal readonly static int FACE_礼物 = 69;
        internal readonly static int FACE_太阳 = 74;
        internal readonly static int FACE_月亮 = 75;
        internal readonly static int FACE_强 = 76;
        internal readonly static int FACE_弱 = 77;
        internal readonly static int FACE_握手 = 78;
        internal readonly static int FACE_胜利 = 79;
        internal readonly static int FACE_飞吻 = 85;
        internal readonly static int FACE_怄火 = 86;
        internal readonly static int FACE_西瓜 = 89;
        internal readonly static int FACE_冷汗 = 96;
        internal readonly static int FACE_擦汗 = 97;
        internal readonly static int FACE_抠鼻 = 98;
        internal readonly static int FACE_鼓掌 = 99;
        internal readonly static int FACE_糗大了 = 100;
        internal readonly static int FACE_坏笑 = 101;
        internal readonly static int FACE_左哼哼 = 102;
        internal readonly static int FACE_右哼哼 = 103;
        internal readonly static int FACE_哈欠 = 104;
        internal readonly static int FACE_鄙视 = 105;
        internal readonly static int FACE_委屈 = 106;
        internal readonly static int FACE_快哭了 = 107;
        internal readonly static int FACE_阴险 = 108;
        internal readonly static int FACE_亲亲 = 109;
        internal readonly static int FACE_吓 = 110;
        internal readonly static int FACE_可怜 = 111;
        internal readonly static int FACE_菜刀 = 112;
        internal readonly static int FACE_啤酒 = 113;
        internal readonly static int FACE_篮球 = 114;
        internal readonly static int FACE_乒乓 = 115;
        internal readonly static int FACE_示爱 = 116;
        internal readonly static int FACE_瓢虫 = 117;
        internal readonly static int FACE_抱拳 = 118;
        internal readonly static int FACE_勾引 = 119;
        internal readonly static int FACE_拳头 = 120;
        internal readonly static int FACE_差劲 = 121;
        internal readonly static int FACE_爱你 = 122;
        internal readonly static int FACE_不 = 123;
        internal readonly static int FACE_好 = 124;
        internal readonly static int FACE_转圈 = 125;
        internal readonly static int FACE_磕头 = 126;
        internal readonly static int FACE_回头 = 127;
        internal readonly static int FACE_跳绳 = 128;
        internal readonly static int FACE_挥手 = 129;
        internal readonly static int FACE_激动 = 130;
        internal readonly static int FACE_街舞 = 131;
        internal readonly static int FACE_献吻 = 132;
        internal readonly static int FACE_左太极 = 133;
        internal readonly static int FACE_右太极 = 134;
        internal readonly static int FACE_双喜 = 136;
        internal readonly static int FACE_鞭炮 = 137;
        internal readonly static int FACE_灯笼 = 138;
        internal readonly static int FACE_发财 = 139;
        internal readonly static int FACE_K歌 = 140;
        internal readonly static int FACE_购物 = 141;
        internal readonly static int FACE_邮件 = 142;
        internal readonly static int FACE_帅 = 143;
        internal readonly static int FACE_喝彩 = 144;
        internal readonly static int FACE_祈祷 = 145;
        internal readonly static int FACE_爆筋 = 146;
        internal readonly static int FACE_棒棒糖 = 147;
        internal readonly static int FACE_喝奶 = 148;
        internal readonly static int FACE_下面 = 149;
        internal readonly static int FACE_香蕉 = 150;
        internal readonly static int FACE_飞机 = 151;
        internal readonly static int FACE_开车 = 152;
        internal readonly static int FACE_高铁左车头 = 153;
        internal readonly static int FACE_车厢 = 154;
        internal readonly static int FACE_高铁右车头 = 155;
        internal readonly static int FACE_多云 = 156;
        internal readonly static int FACE_下雨 = 157;
        internal readonly static int FACE_钞票 = 158;
        internal readonly static int FACE_熊猫 = 159;
        internal readonly static int FACE_灯泡 = 160;
        internal readonly static int FACE_风车 = 161;
        internal readonly static int FACE_闹钟 = 162;
        internal readonly static int FACE_打伞 = 163;
        internal readonly static int FACE_彩球 = 164;
        internal readonly static int FACE_钻戒 = 165;
        internal readonly static int FACE_沙发 = 166;
        internal readonly static int FACE_纸巾 = 167;
        internal readonly static int FACE_药 = 168;
        internal readonly static int FACE_手枪 = 169;
        internal readonly static int FACE_青蛙 = 170;
        #endregion
        /// <summary>
        /// 框架唯一标识
        /// </summary>
        internal static int AuthCode { get; set; }
        /// <summary>
        /// 协议类型 1 安卓 2 PC
        /// </summary>
        internal static int ProtocolType { get; set; }
        /// <summary>
        /// @某人(at) - 仅支持群
        /// </summary>
        /// <param name="QQID">-1 为全体</param>
        /// <param name="sp">默认为false At后添加空格，可使At更规范美观。如果不需要添加空格，请置本参数为true。</param>
        /// <returns>LQ_AT码</returns>
        public static string At(long QQID,bool sp=false)
        {
            string at= QQID == -1 ? "all" : QQID.ToString();
            return $"[@{at}]";
        }

        /// <summary>
        /// QQ表情
        /// </summary>
        /// <param name="id">表情ID</param>
        /// <returns></returns>
        public static string Face(int id)
        {
            return $"[LQ: face, id ={id}]";
        }
        /// <summary>
        /// 发送本地图片，请填写全路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string localImage(string path)
        {
            return $"[LQ:image,path={EnMsg(path,true)}]";
        }
        /// <summary>
        /// 发送网络图片，请填写全路径
        /// </summary>
        /// <param name="url">链接</param>
        /// <returns></returns>
        public static string webImage(string url)
        {
            return $"[LQ:url,path={EnMsg(url, true)}]";
        }
        /// <summary>
        /// 发送本地图片闪照(flashpic)，请填写全路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string localFlashpicImage(string path)
        {
            return $"[LQ:flashpic,path={EnMsg(path, true)}]";
        }

        /// <summary>
        /// 发送本地语音，请填写全路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string localVoice(string path)
        {
            return $"[LQ:record,path={EnMsg(path, true)}]";
        }
        /// <summary>
        /// 文本转义
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="p">逗号转义</param>
        /// <returns></returns>
        public static string EnMsg(string msg,bool p = false)
        {
            string tmp = msg;
            if (p) tmp.Replace(",", "&#44;");
            tmp=tmp.Replace("&", "&amp;").Replace("[", "&#91;").Replace("]", "&#93");
            return tmp;
        }
        /// <summary>
        /// 文本反转义
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static string DeMsg(string msg)
        {
            string tmp = msg;
            tmp = tmp.Replace("&amp;", "&").Replace("&#91;", "[" ).Replace("&#93", "]" ).Replace(",", "&#44;");
            return tmp;
        }
        ///<summary>
        ///编码
        ///</summary>
        ///<param name="pbBinary"> 需要转换的数据</param>
        ///<param name="cbBinary"> 数据长度</param>
        ///<param name="dwFlags"> 解码标志</param>
        ///<param name="pszString"> 数据缓存</param>
        ///<param name="pcchString"> 返回长度</param>
        public static bool CryptBinaryToStringA(ref byte[] pbBinary, int cbBinary, int dwFlags, ref byte[] pszString, ref int pcchString)
        {
           return QYAPI.CryptBinaryToStringA(ref pbBinary, cbBinary, dwFlags,ref  pszString, ref pcchString);
        }
        ///<summary>
        ///
        ///</summary>
        ///<param name="pszString"></param>
        ///<param name="cchString"></param>
        ///<param name="pbBinary"></param>
        ///<param name="pcbBinary"></param>
        ///<param name="pdwSkip"> 0</param>
        ///<param name="pdwFlags"> 0</param>
        public static bool CryptStringToBinaryA(ref string pszString, ref int cchString, int dwFlags, ref byte[] pbBinary, ref int pcbBinary, int pdwSkip, int pdwFlags)
        {
            return QYAPI.CryptStringToBinaryA(ref pszString, ref cchString, dwFlags, ref pbBinary, ref pcbBinary, pdwSkip, pdwFlags);
        }
        ///<summary>
        ///v2018 /取应用目录 
        ///</summary>
        public static string getAppDirectory()
        {
          return  QYAPI.QY_getAppDirectory(AuthCode);
        }
        ///<summary>
        ///v2018 /取登录昵称
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        public static string getLoginNick( long QQID)
        {
            return QYAPI.QY_getLoginNick(AuthCode, QQID);
        }
        ///<summary>
        ///v2018 /取登录QQ列表
        ///</summary>
        public static string getLoginQQList()
        {
            return QYAPI.QY_getLoginQQList(AuthCode);
        }
        ///<summary>
        ///v2018 /取Cookies /慎用, 此接口需要严格授权
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        public static string getCookies( long QQID)
        {
            return QYAPI.QY_getCookies(AuthCode,QQID);
        }
        ///<summary>
        ///v2018 /取CsrfToken /慎用, 此接口需要严格授权
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        public static int getCsrfToken( long QQID)
        {
            return QYAPI.QY_getCsrfToken(AuthCode, QQID);
        }
        ///<summary>
        ///v2018 /发送名片点赞
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="QQUin"> 目标QQ</param>
        public static int sendLikeFavorite( long QQID, long QQUin)
        {
            return QYAPI.QY_sendLikeFavorite(AuthCode, QQID, QQUin);
        }
        ///<summary>
        ///v2018 置移除群员 *需要管理员权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="QQUin"> QQ号</param>
        ///<param name="RejectAddRequest"> 不再接收此人加群申请，请慎用</param>
        public static int setGroupMembersKick( long QQID, long dwGroupCode, long QQUin, int RejectAddRequest)
        {
            return QYAPI.QY_setGroupMembersKick(AuthCode, QQID, dwGroupCode, QQUin, RejectAddRequest);
        }
        ///<summary>
        ///v2018 置全群禁言*需要管理员权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="GroupSwitch"> 开关</param>
        public static int setGroupWholeBanSpeak( long QQID, long dwGroupCode, int GroupSwitch)
        {
            return QYAPI.QY_setGroupWholeBanSpeak(AuthCode, QQID, dwGroupCode, GroupSwitch);
        }
        ///<summary>
        ///v2018 置群员禁言*需要管理员权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="TimeStamp"> 禁言的时间，单位为分。如果要解禁，这里填写0</param>
        public static int setGroupMembersBanSpeak( long QQID, long dwGroupCode, long QQUin, long TimeStamp)
        {
            return QYAPI.QY_setGroupMembersBanSpeak(AuthCode, QQID, dwGroupCode, QQUin, TimeStamp);
        }
        ///<summary>
        ///v2018 置群成员昵称*需要管理员权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="NewName"> 新昵称</param>
        public static int setModifyGroupMemberCard( long QQID, long dwGroupCode, long QQUin, string NewName)
        {
            return QYAPI.QY_setModifyGroupMemberCard(AuthCode,QQID, dwGroupCode, QQUin, NewName);
        }
        ///<summary>
        ///v2018 置禁止群匿名*需要管理员权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="GroupSwitch"> 开关</param>
        public static int setGroupAnonymousBan( long QQID, long dwGroupCode, int GroupSwitch)
        {
            return QYAPI.QY_setGroupAnonymousBan(AuthCode, QQID, dwGroupCode, GroupSwitch);
        }
        ///<summary>
        ///v2018 置群管理*需要群主权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="Switch"> 设置/取消</param>
        public static int setGroupAdmini( long QQID, long dwGroupCode, long QQUin, int Switch)
        {
            return QYAPI.QY_setGroupAdmini(AuthCode, QQID, dwGroupCode, QQUin, Switch);
        }
        ///<summary>
        ///v2018 置群成员专属头衔*需要群主权限 *仅安卓QQ协议支持
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="specialTitle"> 头衔 //如果要删除，这里填空</param>
        ///<param name="expireTime"> 专属头衔有效期，单位为秒。如果永久有效，这里填写-1</param>
        public static int setGroupSpecialTitle( long QQID, long dwGroupCode, long QQUin, string specialTitle, int expireTime)
        {
            return QYAPI.QY_setGroupSpecialTitle(AuthCode, QQID, dwGroupCode, QQUin, specialTitle, expireTime);
        }
        ///<summary>
        ///v2018 置群临时会话开关*需要群主权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="Switch"> 开关</param>
        public static int setGroupPrivateSession( long QQID, long dwGroupCode, int Switch)
        {
            return QYAPI.QY_setGroupPrivateSession(AuthCode, QQID, dwGroupCode, Switch);
        }
        ///<summary>
        ///v2018 置群成员发起多人聊天开关*需要群主权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="Switch"> 开关</param>
        public static int setGroupManyPeopleChat( long QQID, long dwGroupCode, int Switch)
        {
            return QYAPI.QY_setGroupManyPeopleChat(AuthCode, QQID, dwGroupCode, Switch);
        }
        ///<summary>
        ///v2018 置退出群
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="Switch"> 退出自己创建的群时使用,是否解散群</param>
        public static int setExitGroupChat( long QQID, long dwGroupCode, int Switch)
        {
            return QYAPI.QY_setExitGroupChat(AuthCode, QQID, dwGroupCode, Switch);
        }
        ///<summary>
        ///v2018 置退出讨论组
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="Discussid"> 目标讨论组</param>
        public static int setExitDiscussChat( long QQID, long Discussid)
        {
            return QYAPI.QY_setExitDiscussChat(AuthCode, QQID, Discussid);
        }
        ///<summary>
        ///v2018 置移除讨论组成员*需要创建者权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="Discussid"> 目标讨论组</param>
        ///<param name="QQUin"> QQ号</param>
        public static int setDiscussMembersKick( long QQID, long Discussid, long QQUin)
        {
            return QYAPI.QY_setDiscussMembersKick(AuthCode, QQID, Discussid, QQUin);
        }
        ///<summary>
        ///v2018 置群匿名禁言 禁言后无法解除*需要管理员权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="AnonHead"> 匿名用户的头像标识</param>
        ///<param name="AnonID"> 匿名用户Token</param>
        ///<param name="AnonNick"> 匿名名称</param>
        ///<param name="TimeStamp"> 禁言的时间，单位为秒。禁言后无法解除</param>
        public static int setGroupAnonymousBanSpeak( long QQID, long dwGroupCode, int AnonHead, string AnonID, string AnonNick, long TimeStamp)
        {
            return QYAPI.QY_setGroupAnonymousBanSpeak(AuthCode, QQID, dwGroupCode, AnonHead, AnonID, AnonNick, TimeStamp);
        }
        ///<summary>
        ///v2018 置处理好友添加请求
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="ResponseFlag"> 请求事件收到的"反馈标识"参数</param>
        ///<param name="RequestFlag"> #请求_通过 或 #请求_拒绝</param>
        ///<param name="Remarks"> 添加后的好友备注</param>
        public static int setFriendAddRequest( long QQID, string ResponseFlag, int RequestFlag, string Remarks)
        {
            return QYAPI.QY_setFriendAddRequest(AuthCode, QQID, ResponseFlag, RequestFlag, Remarks);
        }
        ///<summary>
        ///v2018 置处理群添加请求
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="ResponseFlag"> 请求事件收到的"反馈标识"参数</param>
        ///<param name="RequestType"> 根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请</param>
        ///<param name="RequestFlag"> #请求_通过 或 #请求_拒绝</param>
        ///<param name="Reason"> 操作理由，仅 #请求_群添加 且 #请求_拒绝 时可用</param>
        public static int setGroupAddRequest( long QQID, string ResponseFlag, int RequestType, int RequestFlag, string Reason)
        {
            return QYAPI.QY_setGroupAddRequest(AuthCode, QQID, ResponseFlag, RequestFlag, RequestFlag, Reason);
        }
        ///<summary>
        ///v2018 置致命错误提示
        ///</summary>

        public static int setFatal( string error)
        {
            return QYAPI.QY_setFatal(AuthCode, error);
        }
        ///<summary>
        ///v2018 取群成员名片
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群 //群号</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="nocache"> 默认假/使用缓存 真/不使用缓存</param>
        public static string getGroupMemberCard( long QQID, long dwGroupCode, long QQUin, bool nocache)
        {
            return QYAPI.QY_getGroupMemberCard(AuthCode, QQID, dwGroupCode, QQUin, nocache);
        }
        ///<summary>
        ///v2018 取群管理组 /包括群主
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群 //群号</param>
        public static string getGroupAdminList( long QQID, long dwGroupCode)
        {
            return QYAPI.QY_getGroupAdminList(AuthCode, QQID, dwGroupCode);
        }
        ///<summary>
        ///v2018 取群信息/资料
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群 //群号</param>
        public static string getGroupInfo( long QQID, long dwGroupCode)
        {
            return QYAPI.QY_getGroupInfo(AuthCode, QQID, dwGroupCode);
        }
        ///<summary>
        ///v2018 取QQ信息/资料
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="QQUin"> 目标QQ</param>
        public static string getSummaryInfo( long QQID, long QQUin)
        {
            return QYAPI.QY_getSummaryInfo(AuthCode, QQID, QQUin);
        }
        ///<summary>
        ///v2018 发送好友消息
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="Msg"> 消息内容</param>
        public static int sendFriendMsg( long QQID, long QQUin, string Msg)
        {
            return QYAPI.QY_sendFriendMsg(AuthCode, QQID, QQUin, Msg);
        }
        ///<summary>
        ///v2018 发送群消息
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群号</param>
        ///<param name="Msg"> 消息内容</param>
        public static int sendGroupMsg( long QQID, long dwGroupCode, string Msg)
        {
            return QYAPI.QY_sendGroupMsg(AuthCode, QQID, dwGroupCode, Msg);
        }
        ///<summary>
        ///v2018 发送群临时消息
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群号</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="Msg"> 消息内容</param>
        public static int sendGroupTmpMsg( long QQID, long dwGroupCode, long QQUin, string Msg)
        {
            return QYAPI.QY_sendGroupTmpMsg(AuthCode, QQID,dwGroupCode, QQUin, Msg);
        }
        ///<summary>
        ///v2018 发送讨论组消息
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="DiscussID"> 目标讨论组号</param>
        ///<param name="Msg"> 消息内容</param>
        public static int sendDiscussMsg( long QQID, long DiscussID, string Msg)
        {
            return QYAPI.QY_sendDiscussMsg(AuthCode, QQID, DiscussID, Msg);
        }
        ///<summary>
        ///v2018 发送讨论组临时消息
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="DiscussID"> 目标讨论组号</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="Msg"> 消息内容</param>
        public static int sendDiscussTmpMsg( long QQID, long DiscussID, long QQUin, string Msg)
        {
            return QYAPI.QY_sendDiscussTmpMsg(AuthCode, QQID, DiscussID, QQUin, Msg);
        }
        ///<summary>
        ///v2018 编码Utf8到Ansi
        ///</summary>
        public static string setEncodeUtf8ToAnsi( string Content)
        {
            return QYAPI.QY_setEncodeUtf8ToAnsi(AuthCode, Content);
        }
        ///<summary>
        ///v2018 编码Ansi到Utf8
        ///</summary>
        public static string setEncodeAnsiToUtf8( string Content)
        {
            return QYAPI.QY_setEncodeAnsiToUtf8(AuthCode, Content);
        }
        ///<summary>
        ///v2018 根据域名取cookie 慎用, 此接口需要严格授权
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="Domain"> http://qun.qq.com 或 http://qun.qzone.qq.com 留空默认取http://qun.qq.com域登录跳转成功后的cookie</param>
        public static string getDomainCookie( long QQID, string Domain)
        {
            return QYAPI.QY_getDomainCookie(AuthCode, QQID, Domain);
        }
        ///<summary>
        ///v2018 取群列表
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        public static string getGroupList( long QQID)
        {
            return QYAPI.QY_getGroupList(AuthCode, QQID);
        }
        ///<summary>
        ///v2018 取好友列表
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        public static string getFriendList( long QQID)
        {
            return QYAPI.QY_getFriendList(AuthCode, QQID);
        }
        ///<summary>
        ///v2018 取群成员列表
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群 //群号</param>
        public static string getGroupMemberList( long QQID, long dwGroupCode)
        {
            return QYAPI.QY_getGroupMemberList(AuthCode, QQID, dwGroupCode);
        }
        ///<summary>
        ///v2018 置消息撤回
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        public static int setMessageSvcMsgWithDraw( long QQID, string MsgInfo)
        {
            return QYAPI.QY_setMessageSvcMsgWithDraw(AuthCode, QQID, MsgInfo);
        }
        ///<summary>
        ///v2018 置添加群
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群 //群号</param>
        ///<param name="AdditionalMsg"> 附加消息</param>
        public static int setAddGroup( long QQID, long dwGroupCode, string AdditionalMsg)
        {
            return QYAPI.QY_setAddGroup(AuthCode, QQID, dwGroupCode, AdditionalMsg);
        }
        ///<summary>
        ///v2018 加入运行日志
        ///</summary>

        public static int addLog( long QQID, int level, string et, string msg)
        {
            return QYAPI.QY_addLog(AuthCode, QQID, level, et, msg);
        }
        ///<summary>
        ///v2018 取框架名
        ///</summary>
        public static string getFrameName()
        {
            return QYAPI.QY_getFrameName(AuthCode);
        }

    }
}
