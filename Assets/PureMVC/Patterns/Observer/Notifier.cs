﻿using PureMVC.Interfaces;

namespace PureMVC.Patterns.Observer
{
    /// <summary>
    /// 发送消息实现接口
    /// </summary>
    public class Notifier : INotifier
    {
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="notificationName">通知的名称</param>
        /// <param name="body">此条通知所带的数据</param>
        /// <param name="type">这条通知的类型</param>
        public virtual void SendNotification(string notificationName, object body = null, string type = null)
        {
            Facade.SendNotification(notificationName, body, type);
        }

        protected IFacade Facade
        {
            get
            {
                return Patterns.Facade.Facade.GetInstance(() => new Facade.Facade());
            }
        }
    }
}
