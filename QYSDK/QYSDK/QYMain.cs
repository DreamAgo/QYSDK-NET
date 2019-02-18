using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QYSDK
{
    public class QYMain
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();//开启控制台

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FreeConsole();//关闭控制台

        ///<summary>
        /// 插件基础信息在这里返回 //本函数【禁止】处理其他任何代码
        ///</summary>
        /// <returns></returns>
        [DllExport(ExportName = nameof(AppInfo), CallingConvention = CallingConvention.StdCall)]
        public static string AppInfo()
        {

            return AppInfoEdit.getAppInfo();

        }
        ///<summary>
        /// 应用AuthCode接收 //本函数【禁止】处理其他任何代码，请不要改动本函数
        ///</summary>
        /// <param name="authcode"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        [DllExport(ExportName = nameof(Initialize), CallingConvention = CallingConvention.StdCall)]
        public static int Initialize(int AuthCode, int ProtocolType)
        {
           
            QY.AuthCode = AuthCode;
            QY.ProtocolType = ProtocolType;
            
            return 0;
        }
        ///<summary>
        /// Type=1001 启动
        ///</summary>
        /// <returns></returns>
        [DllExport(ExportName = nameof(_eventStartup), CallingConvention = CallingConvention.StdCall)]
        public static int _eventStartup()
        {

            return 0;

        }

        ///<summary>
        /// Type=1003 已被启用
        ///</summary>
        /// <returns></returns>
        [DllExport(ExportName = nameof(_eventEnable), CallingConvention = CallingConvention.StdCall)]
        public static int _eventEnable()
        {
            AllocConsole();
            Console.WriteLine($"C# AuthCode:{QY.AuthCode}");
            //ManagementCenter.Load();
            // ManagementCenter.init();

            return 0;

        }

        ///<summary>
        /// Type=1004 将被停用
        ///</summary>
        /// <returns></returns>
        [DllExport(ExportName = nameof(_eventDisable), CallingConvention = CallingConvention.StdCall)]
        public static int _eventDisable()
        {

            return 0;

        }
        ///<summary>
        /// Type=1002 退出
        ///</summary>
        /// <returns></returns>
        [DllExport(ExportName = nameof(_eventExit), CallingConvention = CallingConvention.StdCall)]
        public static int _eventExit()
        {
            FreeConsole();
            return 0;

        }
        ///<summary>
        ///Type=166 私聊消息
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="subType"> 子类型，11/来自好友 1/来自在线状态 2/来自群 3/来自讨论组 4/来自公众号</param>
        ///<param name="sendTime"> 发送时间(时间戳)</param>
        ///<param name="fromQQ"> 来源QQ</param>
        ///<param name="fromID"> 来源群号 或 讨论组ID 仅子类型为2/3/时使用</param>
        ///<param name="fromInfo"> 来源者信息</param>
        ///<param name="msg"> 消息内容</param>
        ///<param name="Info"> 信息</param>
        ///<param name="intTest"> 用于测试</param>
        /// <returns></returns>
        [DllExport(ExportName = nameof(_eventPrivateMsg), CallingConvention = CallingConvention.StdCall)]
        public static int _eventPrivateMsg(long QQID, int subType, long sendTime, long fromQQ, long fromID, string fromInfo, string msg, string Info, int intTest)
        {
            Console.WriteLine($"AuthCode：{QY.AuthCode}");
            Console.WriteLine($"接收到好友[{fromQQ}]的消息：{msg}");
            Console.WriteLine($"尝试发送消息给[{fromQQ}]");
            QY.sendFriendMsg(QQID, fromQQ, "C#测试");
            return 0;

        }

        ///<summary>
        ///Type=82 群消息
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="subType"> 子类型，目前固定为1</param>
        ///<param name="sendTime"> 发送时间(时间戳)</param>
        ///<param name="fromGroup"> 来源群号</param>
        ///<param name="fromQQ"> 来源QQ号</param>
        ///<param name="fromInfo"> 来源者信息</param>
        ///<param name="msg"> 消息内容</param>
        ///<param name="Info"> 信息</param>
        ///<param name="intTest"> 用于测试</param>
        [DllExport(ExportName = nameof(_eventGroupMsg), CallingConvention = CallingConvention.StdCall)]
        public static int _eventGroupMsg(long QQID, int subType, long sendTime, long fromGroup, long fromQQ, string fromInfo, string msg, string Info, int intTest)
        {

            Console.WriteLine($"AuthCode：{QY.AuthCode}");
            Console.WriteLine($"接收群[{fromGroup}->{fromQQ}]的消息：{msg}");
            Console.WriteLine($"尝试发送消息给群[{fromGroup}]");
            QY.sendGroupMsg(QQID, fromGroup, QY.At(fromQQ)+"C#测试");
            return QY.EVENT_IGNORE;

        }

        ///<summary>
        ///Type=83 讨论组消息
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="subtype"> 子类型，目前固定为1</param>
        ///<param name="sendTime"> 发送时间(时间戳)</param>
        ///<param name="fromDiscuss"> 来源讨论组</param>
        ///<param name="fromQQ"> 来源QQ号</param>
        ///<param name="fromInfo"> 来源者信息</param>
        ///<param name="msg"> 消息内容</param>
        ///<param name="Info"> 信息</param>
        ///<param name="intTest"> 用于测试</param>
        [DllExport(ExportName = nameof(_eventDiscussMsg), CallingConvention = CallingConvention.StdCall)]
        public static int _eventDiscussMsg(long QQID, int subtype, long sendTime, long fromDiscuss, long fromQQ, string fromInfo, string msg, string Info, int intTest)
        {
            return QY.EVENT_IGNORE;

        }
        ///<summary>
        ///Type=101 推送消息事件
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="subType"> 子类型，目前固定为1</param>
        ///<param name="sendTime"> 发送时间(时间戳)</param>
        ///<param name="fromID"> 来源ID</param>
        ///<param name="fromQQ"> 来源QQ号</param>
        ///<param name="fromQQID"> 目标QQ号</param>
        ///<param name="msg"> 事件信息</param>
        ///<param name="Info"> 信息</param>
        ///<param name="intTest"> 用于测试</param>
        [DllExport(ExportName = nameof(_eventPushMsgEvent), CallingConvention = CallingConvention.StdCall)]
        public static int _eventPushMsgEvent(long QQID, int subType, long sendTime, long fromID, long fromQQ, long fromQQID, string msg, string Info, int intTest)
        {

            return QY.EVENT_IGNORE;

        }

        ///<summary>
        ///Type=102 群事件-管理员变动
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="subtype"> 子类型，1/被取消管理员 2/被设置管理员</param>
        ///<param name="sendTime"> 发送时间(时间戳)</param>
        ///<param name="fromGroup"> 来源群号</param>
        ///<param name="beingOperateQQ"> 被操作QQ</param>
        [DllExport(ExportName = nameof(_eventSystem_GroupAdmin), CallingConvention = CallingConvention.StdCall)]
        public static int _eventSystem_GroupAdmin(long QQID, int subtype, long sendTime, long fromGroup, long beingOperateQQ)
        {


            return QY.EVENT_IGNORE;
        }

        ///<summary>
        ///Type=103 群事件-群成员减少
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="subtype"> 子类型，1/群解散 2/群员离开 3/群员被踢。</param>
        ///<param name="sendTime"> 发送时间(时间戳)</param>
        ///<param name="fromGroup"> 来源群号</param>
        ///<param name="fromQQ"> 操作者QQ(仅子类型为2、3时存在)</param>
        ///<param name="beingOperateQQ"> 被操作QQ</param>

        [DllExport(ExportName = nameof(_eventSystem_GroupMemberDecrease), CallingConvention = CallingConvention.StdCall)]
        public static int _eventSystem_GroupMemberDecrease(long QQID, int subtype, long sendTime, long fromGroup, long fromQQ, long beingOperateQQ)
        {


            return QY.EVENT_IGNORE;
        }
        ///<summary>
        ///Type=104 群事件-群成员增加
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="subtype"> 子类型，1/管理员已同意 2/管理员邀请</param>
        ///<param name="sendTime"> 发送时间(时间戳)</param>
        ///<param name="fromGroup"> 来源群号</param>
        ///<param name="fromQQ"> 操作者QQ(即管理员QQ)</param>
        ///<param name="beingOperateQQ"> 被操作QQ(即加群的QQ)</param>
        [DllExport(ExportName = nameof(_eventSystem_GroupMemberIncrease), CallingConvention = CallingConvention.StdCall)]
        public static int _eventSystem_GroupMemberIncrease(long QQID, int subtype, long sendTime, long fromGroup, long fromQQ, long beingOperateQQ)
        {


            return QY.EVENT_IGNORE;
        }

        ///<summary>
        ///Type=201 好友事件
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="subtype"> 子类型，1/好友已同意 2/好友已拒绝</param>
        ///<param name="sendTime"> 发送时间(时间戳)</param>
        ///<param name="fromQQ"> 来源QQ</param>
        ///<param name="Info"> 信息</param>
        [DllExport(ExportName = nameof(_eventFriendEvent), CallingConvention = CallingConvention.StdCall)]
        public static int _eventFriendEvent(long QQID, int subtype, long sendTime, long fromQQ, string Info)
        {


            return QY.EVENT_IGNORE;
        }

        ///<summary>
        ///Type=301 请求-好友添加
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="subtype"> 子类型，目前固定为1</param>
        ///<param name="sendTime"> 发送时间(时间戳)</param>
        ///<param name="fromQQ"> 来源QQ</param>
        ///<param name="source"> 来源信息</param>
        ///<param name="msg"> 附言</param>
        ///<param name="responseFlag"> 反馈标识(处理请求用)</param>
        [DllExport(ExportName = nameof(_eventRequest_AddFriend), CallingConvention = CallingConvention.StdCall)]
        public static int _eventRequest_AddFriend(long QQID, int subtype, long sendTime, long fromQQ, string Info)
        {


            return QY.EVENT_IGNORE;
        }
        ///<summary>
        ///Type=302 请求-群添加
        ///</summary>
        ///<param name="QQID"> 用于区分多号登录</param>
        ///<param name="subtype"> 子类型，1/他人申请入群 2/群成员邀请他人申请入群 3/自己(即登录号)受邀入群</param>
        ///<param name="sendTime"> 发送时间(时间戳)</param>
        ///<param name="fromGroup"> 来源群号</param>
        ///<param name="fromQQ"> 来源QQ</param>
        ///<param name="source"> 来源信息 1/来源 2/3/邀请人QQ</param>
        ///<param name="msg"> 附言</param>
        ///<param name="responseFlag"> 反馈标识(处理请求用)</param>
        [DllExport(ExportName = nameof(_eventRequest_AddGroup), CallingConvention = CallingConvention.StdCall)]
        public static int _eventRequest_AddGroup(long QQID, int subtype, long sendTime, long fromGroup, long fromQQ, string source, string msg, string responseFlag)
        {


            return QY.EVENT_IGNORE;
        }


    }
}
