using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UzEx.TMQ.Helpers;
using UzEx.TMQ.Models;
using UzEx.TMQ.Services;

namespace UzEx.TMQ.Repositories
{
    public sealed class TUzExRepository : IDisposable
    {
        private MQAdapter _adapter;

        public TUzExRepository()
        {
            _adapter = new MQAdapter(MQConfig.QueueManagerName, MQConfig.ChannelInfo);
            _adapter.SetReceiverQueue(MQConfig.ReceiverQueueName);
            _adapter.SetSenderQueue(MQConfig.SenderQueueName);
        }

        public void Open()
        {
            _adapter.Open();

            if (!_adapter.IsSuccess)
                throw new Exception(_adapter.ResultMessage);
        }

        public void ReceiveAndSendTResult()
        {
            _adapter.Receive();

            if (!_adapter.IsSuccess)
                throw new Exception(_adapter.ResultMessage);

            var result = _adapter.ResultMessage;

            //TODO:need to import our database and fill to UzEx transformation model
            var model = IOHelper.XmlDecode<CC_Info_Main>(result);

            //TODO: Send to test result data
            var path = Path.Combine(Environment.CurrentDirectory, "Test", "IMResult.xml");
            var data = File.ReadAllText(path);

            _adapter.Send(data);
        }

        public void SendUzExData()
        {
            //TODO: read and send test data
            var path = Path.Combine(Environment.CurrentDirectory, "Test", "IMMain.xml");
            var data = File.ReadAllText(path);
            var xml = IOHelper.XmlEncode(data);

            _adapter.Send(xml);
        }

        public void Dispose()
        {
            if (_adapter != null)
            {
                _adapter.Close();
                _adapter = null;
            }

            GC.SuppressFinalize(this);
        }

    }
}
