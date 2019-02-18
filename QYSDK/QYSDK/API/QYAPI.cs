using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace QYSDK
{
  public  class QYAPI
    {
        ///<summary>
        ///编码
        ///</summary>
        ///<param name="pbBinary"> 需要转换的数据</param>
        ///<param name="cbBinary"> 数据长度</param>
        ///<param name="dwFlags"> 解码标志</param>
        ///<param name="pszString"> 数据缓存</param>
        ///<param name="pcchString"> 返回长度</param>
        [DllImport("Crypt32.dll", EntryPoint = "CryptBinaryToStringA")]
        public static extern bool CryptBinaryToStringA(ref byte[] pbBinary, int cbBinary, int dwFlags, ref byte[] pszString, ref int pcchString);
        ///<summary>
        ///
        ///</summary>
        ///<param name="pszString"></param>
        ///<param name="cchString"></param>
        ///<param name="pbBinary"></param>
        ///<param name="pcbBinary"></param>
        ///<param name="pdwSkip"> 0</param>
        ///<param name="pdwFlags"> 0</param>
        [DllImport("Crypt32.dll", EntryPoint = "CryptStringToBinaryA")]
        public static extern bool CryptStringToBinaryA(ref string pszString, ref int cchString, int dwFlags, ref byte[] pbBinary, ref int pcbBinary, int pdwSkip, int pdwFlags);
        ///<summary>
        ///v2018 /取应用目录 
        ///</summary>

        [DllImport("QYOffer.dll", EntryPoint = "QY_getAppDirectory")]
        public static extern string QY_getAppDirectory(int AuthCode);
        ///<summary>
        ///v2018 /取登录昵称
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_getLoginNick")]
        public static extern string QY_getLoginNick(int AuthCode, long QQID);
        ///<summary>
        ///v2018 /取登录QQ列表
        ///</summary>
        [DllImport("QYOffer.dll", EntryPoint = "QY_getLoginQQList")]
        public static extern string QY_getLoginQQList(int AuthCode);
        ///<summary>
        ///v2018 /取Cookies /慎用, 此接口需要严格授权
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_getCookies")]
        public static extern string QY_getCookies(int AuthCode, long QQID);
        ///<summary>
        ///v2018 /取CsrfToken /慎用, 此接口需要严格授权
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_getCsrfToken")]
        public static extern int QY_getCsrfToken(int AuthCode, long QQID);
        ///<summary>
        ///v2018 /发送名片点赞
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="QQUin"> 目标QQ</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_sendLikeFavorite")]
        public static extern int QY_sendLikeFavorite(int AuthCode, long QQID, long QQUin);
        ///<summary>
        ///v2018 置移除群员 *需要管理员权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="QQUin"> QQ号</param>
        ///<param name="RejectAddRequest"> 不再接收此人加群申请，请慎用</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setGroupMembersKick")]
        public static extern int QY_setGroupMembersKick(int AuthCode, long QQID, long dwGroupCode, long QQUin, int RejectAddRequest);
        ///<summary>
        ///v2018 置全群禁言*需要管理员权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="GroupSwitch"> 开关</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setGroupWholeBanSpeak")]
        public static extern int QY_setGroupWholeBanSpeak(int AuthCode, long QQID, long dwGroupCode, int GroupSwitch);
        ///<summary>
        ///v2018 置群员禁言*需要管理员权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="TimeStamp"> 禁言的时间，单位为分。如果要解禁，这里填写0</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setGroupMembersBanSpeak")]
        public static extern int QY_setGroupMembersBanSpeak(int AuthCode, long QQID, long dwGroupCode, long QQUin, long TimeStamp);
        ///<summary>
        ///v2018 置群成员昵称*需要管理员权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="NewName"> 新昵称</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setModifyGroupMemberCard")]
        public static extern int QY_setModifyGroupMemberCard(int AuthCode, long QQID, long dwGroupCode, long QQUin, string NewName);
        ///<summary>
        ///v2018 置禁止群匿名*需要管理员权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="GroupSwitch"> 开关</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setGroupAnonymousBan")]
        public static extern int QY_setGroupAnonymousBan(int AuthCode, long QQID, long dwGroupCode, int GroupSwitch);
        ///<summary>
        ///v2018 置群管理*需要群主权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="Switch"> 设置/取消</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setGroupAdmini")]
        public static extern int QY_setGroupAdmini(int AuthCode, long QQID, long dwGroupCode, long QQUin, int Switch);
        ///<summary>
        ///v2018 置群成员专属头衔*需要群主权限 *仅安卓QQ协议支持
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="specialTitle"> 头衔 //如果要删除，这里填空</param>
        ///<param name="expireTime"> 专属头衔有效期，单位为秒。如果永久有效，这里填写-1</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setGroupSpecialTitle")]
        public static extern int QY_setGroupSpecialTitle(int AuthCode, long QQID, long dwGroupCode, long QQUin, string specialTitle, int expireTime);
        ///<summary>
        ///v2018 置群临时会话开关*需要群主权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="Switch"> 开关</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setGroupPrivateSession")]
        public static extern int QY_setGroupPrivateSession(int AuthCode, long QQID, long dwGroupCode, int Switch);
        ///<summary>
        ///v2018 置群成员发起多人聊天开关*需要群主权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="Switch"> 开关</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setGroupManyPeopleChat")]
        public static extern int QY_setGroupManyPeopleChat(int AuthCode, long QQID, long dwGroupCode, int Switch);
        ///<summary>
        ///v2018 置退出群
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="Switch"> 退出自己创建的群时使用,是否解散群</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setExitGroupChat")]
        public static extern int QY_setExitGroupChat(int AuthCode, long QQID, long dwGroupCode, int Switch);
        ///<summary>
        ///v2018 置退出讨论组
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="Discussid"> 目标讨论组</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setExitDiscussChat")]
        public static extern int QY_setExitDiscussChat(int AuthCode, long QQID, long Discussid);
        ///<summary>
        ///v2018 置移除讨论组成员*需要创建者权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="Discussid"> 目标讨论组</param>
        ///<param name="QQUin"> QQ号</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setDiscussMembersKick")]
        public static extern int QY_setDiscussMembersKick(int AuthCode, long QQID, long Discussid, long QQUin);
        ///<summary>
        ///v2018 置群匿名禁言 禁言后无法解除*需要管理员权限
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群</param>
        ///<param name="AnonHead"> 匿名用户的头像标识</param>
        ///<param name="AnonID"> 匿名用户Token</param>
        ///<param name="AnonNick"> 匿名名称</param>
        ///<param name="TimeStamp"> 禁言的时间，单位为秒。禁言后无法解除</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setGroupAnonymousBanSpeak")]
        public static extern int QY_setGroupAnonymousBanSpeak(int AuthCode, long QQID, long dwGroupCode, int AnonHead, string AnonID, string AnonNick, long TimeStamp);
        ///<summary>
        ///v2018 置处理好友添加请求
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="ResponseFlag"> 请求事件收到的“反馈标识”参数</param>
        ///<param name="RequestFlag"> #请求_通过 或 #请求_拒绝</param>
        ///<param name="Remarks"> 添加后的好友备注</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setFriendAddRequest")]
        public static extern int QY_setFriendAddRequest(int AuthCode, long QQID, string ResponseFlag, int RequestFlag, string Remarks);
        ///<summary>
        ///v2018 置处理群添加请求
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="ResponseFlag"> 请求事件收到的“反馈标识”参数</param>
        ///<param name="RequestType"> 根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请</param>
        ///<param name="RequestFlag"> #请求_通过 或 #请求_拒绝</param>
        ///<param name="Reason"> 操作理由，仅 #请求_群添加 且 #请求_拒绝 时可用</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setGroupAddRequest")]
        public static extern int QY_setGroupAddRequest(int AuthCode, long QQID, string ResponseFlag, int RequestType, int RequestFlag, string Reason);
        ///<summary>
        ///v2018 置致命错误提示
        ///</summary>

        [DllImport("QYOffer.dll", EntryPoint = "QY_setFatal")]
        public static extern int QY_setFatal(int AuthCode, string 错误信息);
        ///<summary>
        ///v2018 取群成员名片
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群 //群号</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="不使用缓存"> 默认假/使用缓存 真/不使用缓存</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_getGroupMemberCard")]
        public static extern string QY_getGroupMemberCard(int AuthCode, long QQID, long dwGroupCode, long QQUin, bool nocache);
        ///<summary>
        ///v2018 取群管理组 /包括群主
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群 //群号</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_getGroupAdminList")]
        public static extern string QY_getGroupAdminList(int AuthCode, long QQID, long dwGroupCode);
        ///<summary>
        ///v2018 取群信息/资料
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群 //群号</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_getGroupInfo")]
        public static extern string QY_getGroupInfo(int AuthCode, long QQID, long dwGroupCode);
        ///<summary>
        ///v2018 取QQ信息/资料
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="QQUin"> 目标QQ</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_getSummaryInfo")]
        public static extern string QY_getSummaryInfo(int AuthCode, long QQID, long QQUin);
        ///<summary>
        ///v2018 发送好友消息
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="Msg"> 消息内容</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_sendFriendMsg")]
        public static extern int QY_sendFriendMsg(int AuthCode, long QQID, long QQUin, string Msg);
        ///<summary>
        ///v2018 发送群消息
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群号</param>
        ///<param name="Msg"> 消息内容</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_sendGroupMsg")]
        public static extern int QY_sendGroupMsg(int AuthCode, long QQID, long dwGroupCode, string Msg);
        ///<summary>
        ///v2018 发送群临时消息
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群号</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="Msg"> 消息内容</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_sendGroupTmpMsg")]
        public static extern int QY_sendGroupTmpMsg(int AuthCode, long QQID, long dwGroupCode, long QQUin, string Msg);
        ///<summary>
        ///v2018 发送讨论组消息
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="DiscussID"> 目标讨论组号</param>
        ///<param name="Msg"> 消息内容</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_sendDiscussMsg")]
        public static extern int QY_sendDiscussMsg(int AuthCode, long QQID, long DiscussID, string Msg);
        ///<summary>
        ///v2018 发送讨论组临时消息
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="DiscussID"> 目标讨论组号</param>
        ///<param name="QQUin"> 目标QQ</param>
        ///<param name="Msg"> 消息内容</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_sendDiscussTmpMsg")]
        public static extern int QY_sendDiscussTmpMsg(int AuthCode, long QQID, long DiscussID, long QQUin, string Msg);
        ///<summary>
        ///v2018 编码Utf8到Ansi
        ///</summary>

        [DllImport("QYOffer.dll", EntryPoint = "QY_setEncodeUtf8ToAnsi")]
        public static extern string QY_setEncodeUtf8ToAnsi(int AuthCode, string Content);
        ///<summary>
        ///v2018 编码Ansi到Utf8
        ///</summary>

        [DllImport("QYOffer.dll", EntryPoint = "QY_setEncodeAnsiToUtf8")]
        public static extern string QY_setEncodeAnsiToUtf8(int AuthCode, string Content);
        ///<summary>
        ///v2018 根据域名取cookie 慎用, 此接口需要严格授权
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="Domain"> http://qun.qq.com 或 http://qun.qzone.qq.com 留空默认取http://qun.qq.com域登录跳转成功后的cookie</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_getDomainCookie")]
        public static extern string QY_getDomainCookie(int AuthCode, long QQID, string Domain);
        ///<summary>
        ///v2018 取群列表
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_getGroupList")]
        public static extern string QY_getGroupList(int AuthCode, long QQID);
        ///<summary>
        ///v2018 取好友列表
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_getFriendList")]
        public static extern string QY_getFriendList(int AuthCode, long QQID);
        ///<summary>
        ///v2018 取群成员列表
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群 //群号</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_getGroupMemberList")]
        public static extern string QY_getGroupMemberList(int AuthCode, long QQID, long dwGroupCode);
        ///<summary>
        ///v2018 置消息撤回
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setMessageSvcMsgWithDraw")]
        public static extern int QY_setMessageSvcMsgWithDraw(int AuthCode, long QQID, string MsgInfo);
        ///<summary>
        ///v2018 置添加群
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="dwGroupCode"> 目标群 //群号</param>
        ///<param name="AdditionalMsg"> 附加消息</param>
        [DllImport("QYOffer.dll", EntryPoint = "QY_setAddGroup")]
        public static extern int QY_setAddGroup(int AuthCode, long QQID, long dwGroupCode, string AdditionalMsg);
        ///<summary>
        ///v2018 加入运行日志
        ///</summary>

        [DllImport("QYOffer.dll", EntryPoint = "QY_addLog")]
        public static extern int QY_addLog(int AuthCode, long QQID, int 等级, string 事件, string 内容);
        ///<summary>
        ///v2018 取框架名
        ///</summary>

        [DllImport("QYOffer.dll", EntryPoint = "QY_getFrameName")]
        public static extern string QY_getFrameName(int AuthCode);


    }
}
