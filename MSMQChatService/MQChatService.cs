using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MSMQChatService
{
    public partial class MQChatService : ServiceBase
    {
        public MQChatService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //开启服务  这里就是你想要让服务做的操作  
            StartService();
        }

        private void StartService()
        {
            //System.Windows.Forms.MessageBox.Show("吃饭啦~~~");
        }

        protected override void OnStop()
        {
           
        }
    }
}
