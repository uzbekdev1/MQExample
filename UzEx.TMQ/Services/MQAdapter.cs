using System;
using System.Text;
using IBM.WMQ;
using UzEx.TMQ.Helpers;

namespace UzEx.TMQ.Services
{
    /// <summary>
    ///     Put/Get Messages To/From Local Queue
    /// </summary>
    public sealed class MQAdapter
    {
        private static string _sendQueueName;
        private static string _receiveQueueName;
        private static string _queueManagerName;
        private static string _channelInfo;
        private string _channelName;
        private string _connectionName;
        private string _message;
        private MQQueue _queue;
        private MQGetMessageOptions _queueGetMessageOptions;
        private MQQueueManager _queueManager;
        private MQMessage _queueMessage;
        private MQPutMessageOptions _queuePutMessageOptions;
        private string _transportType;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="queueManagerName">Queue Manager Name</param>
        /// <param name="channelInfo">Channel Information</param>
        public MQAdapter(string queueManagerName, string channelInfo)
        {
            _queueManagerName = queueManagerName;
            _channelInfo = channelInfo;
        }

        /// <summary>
        /// Error message
        /// </summary>
        public string ResultMessage { get; set; }

        /// <summary>
        /// Successfully result
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Sender Queue Name
        /// </summary>
        /// <param name="queueName">Queue Name</param>  
        public void SetSenderQueue(string queueName)
        {
            _sendQueueName = queueName;
        }

        /// <summary>
        /// Receiver QueueName
        /// </summary>
        /// <param name="queueName">Queue Name</param> 
        public void SetReceiverQueue(string queueName)
        {
            _receiveQueueName = queueName;
        }

        /// <summary>
        ///     Connect to MQ Server
        /// </summary> 
        /// <returns></returns>
        public void Open()
        {
            var separator = new[] { '/' };
            var channelParams = _channelInfo.Split(separator);

            _channelName = channelParams[0];
            _transportType = channelParams[1];
            _connectionName = channelParams[2];

            try
            {
                _queueManager = new MQQueueManager(_queueManagerName, _channelName, _connectionName);

                ResultMessage = "Connected Successfully";
                IsSuccess = true;
            }
            catch (Exception exp)
            {
                ResultMessage = "Exception: " + exp.Message;
                IsSuccess = false;
            }

        }

        /// <summary>
        ///     Disconnect to MQ Server
        /// </summary> 
        /// <returns></returns>
        public void Close()
        {
            try
            {
                _message = "";
                _queueMessage = null;
                _queue.Close();
                _queueManager.Disconnect();
            }
            catch (Exception)
            {
                //TODO:
            }
        }

        /// <summary>
        ///     Write Message to Local Queue
        /// </summary>
        /// <param name="input">Text Message</param> 
        /// <returns></returns>
        public void Send(string input)
        {
            try
            {
                _queue = _queueManager.AccessQueue(_sendQueueName, MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING);
                _message = MQHelper.Encode(input);
                _queueMessage = new MQMessage();
                _queueMessage.WriteString(_message);
                _queueMessage.Format = MQC.MQFMT_STRING;
                _queuePutMessageOptions = new MQPutMessageOptions();
                _queue.Put(_queueMessage, _queuePutMessageOptions);

                ResultMessage = "Message sent to the queue successfully";
                IsSuccess = true;
            }
            catch (Exception exp)
            {
                ResultMessage = "Exception: " + exp.Message;
                IsSuccess = false;
            }
        }

        /// <summary>
        ///     Read Message from Local Queue
        /// </summary> 
        /// <returns>Text Message</returns>
        public void Receive()
        {
            try
            {
                _queue = _queueManager.AccessQueue(_receiveQueueName, MQC.MQOO_INPUT_AS_Q_DEF + MQC.MQOO_FAIL_IF_QUIESCING);
                _queueMessage = new MQMessage
                {
                    Format = MQC.MQFMT_STRING
                };
                _queueGetMessageOptions = new MQGetMessageOptions();
                _queue.Get(_queueMessage, _queueGetMessageOptions);
                _message = _queueMessage.ReadString(_queueMessage.MessageLength);

                ResultMessage = MQHelper.Decode(_message);
                IsSuccess = true;
            }
            catch (Exception exp)
            {
                ResultMessage = "Exception: " + exp.Message;
                IsSuccess = false;
            }
        }


    }
}