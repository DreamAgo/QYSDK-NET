using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace QYSDK
{
   public class AppInfoEdit
    {
        internal readonly static string NAME = "契约C#样例应用";
        internal readonly static string APPID = "net.example.demo";
        internal readonly static string AUTHOR = "huise";
        internal readonly static string VERSION = "1.0.0";
        internal readonly static string DESCRIPTION = "契约样例应用(v2018应用机制)C#";
        internal static string getAppInfo()
        {
            List<EventItem> eventitem = new List<EventItem> ();
            //可注释掉不需要的事件
            eventitem.Add(new EventItem(1001,1001, "QY启动事件", "_eventStartup", 30000));
            eventitem.Add(new EventItem(1002, 1002, "QY关闭事件", "_eventExit", 30000));
            eventitem.Add(new EventItem(1003, 1003, "应用已被启用", "_eventEnable", 30000));
            eventitem.Add(new EventItem(1, 166, "私聊消息处理", "_eventPrivateMsg", 30000));
            eventitem.Add(new EventItem(2, 82, "群消息处理", "_eventGroupMsg", 30000));
            eventitem.Add(new EventItem(3, 83, "讨论组消息处理", "_eventDiscussMsg", 30000));
            eventitem.Add(new EventItem(4, 101, "推送消息事件", "_eventPushMsgEvent", 30000));
            eventitem.Add(new EventItem(5, 102, "群管理变动事件处理", "_eventSystem_GroupAdmin", 30000));
            eventitem.Add(new EventItem(6, 103, "群成员减少事件处理", "_eventSystem_GroupMemberDecrease", 30000));
            eventitem.Add(new EventItem(7, 104, "群成员增加事件处理", "_eventSystem_GroupMemberIncrease", 30000));
            eventitem.Add(new EventItem(8, 201, "好友事件处理", "_eventFriendEvent", 30000));
            eventitem.Add(new EventItem(9, 301, "好友添加请求处理", "_eventRequest_AddFriend", 30000));
            eventitem.Add(new EventItem(10, 302, "群添加请求处理", "_eventRequest_AddGroup", 30000));

            List<MenuItem> menitem = new List<MenuItem>();
            menitem.Add(new MenuItem("设置A", "_menuA"));
            menitem.Add(new MenuItem("设置B", "_menuB"));

            List<int> auth = new List<int>();

            auth.Add(101);   // 发送好友消息          sendFriendMsg
            auth.Add(102);   // 发送群消息            sendGroupMsg
            auth.Add(103);   // 发送群临时消息        sendGroupTmpMsg
            auth.Add(104);   // 发送讨论组消息        sendDiscussMsg
            auth.Add(105);   // 发送讨论组临时消息    sendDiscussTmpMsg
            //auth.Add(110);   // [敏感]取Cookies       getCookies/getCsrfToken
            auth.Add(111);   // 发送名片点赞          sendLikeFavorite
            //auth.Add(112);   //[敏感]置退出群       setExitGroupChat
            //auth.Add(113);   //[敏感]置退出讨论组   setExitDiscussChat
            auth.Add(114);   //置移除群员             setGroupMembersKick
            auth.Add(115);   //置移除讨论组成员      setDiscussMembersKick
            menitem.Add(new MenuItem());
            Root root = new Root(1,2018,APPID,NAME,VERSION,1,AUTHOR,DESCRIPTION,eventitem, menitem, auth);

            return GetJson(root);
        }


        public static string GetJson<T>(T obj)

        {

            DataContractJsonSerializer json = new DataContractJsonSerializer(obj.GetType());

            using (MemoryStream stream = new MemoryStream())

            {

                json.WriteObject(stream, obj);

                string szJson = Encoding.UTF8.GetString(stream.ToArray());

                return szJson;

            }

        }

    }

    public class EventItem
    {
        public EventItem()
        {
        }

        public EventItem(int id, int type, string name, string function, int priority)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.function = function;
            this.priority = priority;
        }

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// QY启动事件
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string function { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int priority { get; set; }
    }

    public class MenuItem
    {
        public MenuItem()
        {
        }

        public MenuItem(string name, string function)
        {
            this.name = name;
            this.function = function;
        }

        /// <summary>
        /// 设置A
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string function { get; set; }
    }

    public class Root
    {

        /// <summary>
        /// 
        /// </summary>
        public int ret { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int apiver { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string appid { get; set; }
        /// <summary>
        /// 契约样例应用
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int version_id { get; set; }
        /// <summary>
        /// 契约
        /// </summary>
        public string author { get; set; }
        /// <summary>
        /// 契约样例应用(v2018应用机制)
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<EventItem> @event { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<MenuItem> menu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<int> auth { get; set; }

        public Root()
        {
        }

        public Root(int ret, int apiver, string appid, string name, string version, int version_id, string author, string description, List<EventItem> @event, List<MenuItem> menu, List<int> auth)
        {
            this.ret = ret;
            this.apiver = apiver;
            this.appid = appid;
            this.name = name;
            this.version = version;
            this.version_id = version_id;
            this.author = author;
            this.description = description;
            this.@event = @event;
            this.menu = menu;
            this.auth = auth;
        }
    }
}
