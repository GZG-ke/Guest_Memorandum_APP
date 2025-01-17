﻿using System.Windows.Controls;
using Guest_Memorandum_APP.Extensions;

namespace Guest_Memorandum_APP.Views
{
    /// <summary>
    /// LoginView.xaml 的交互逻辑
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView(IEventAggregator aggregator)
        {
            InitializeComponent();

            //注册提示消息
            aggregator.ResgiterMessage(arg =>
            {
                LoginSnakeBar.MessageQueue.Enqueue(arg.Message);
            }, "Login");
        }
    }
}