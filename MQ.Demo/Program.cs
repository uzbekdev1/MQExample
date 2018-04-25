using System;
using System.IO;
using System.Text;
using System.Threading;
using UzEx.TMQ;
using UzEx.TMQ.Helpers;
using UzEx.TMQ.Models;
using UzEx.TMQ.Repositories;
using UzEx.TMQ.Services;

namespace MQ.Demo
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            using (var mq = new TUzExRepository())
            {
                mq.Open();

                mq.ReceiveAndSendTResult();
                mq.SendUzExData();

            }

            Console.ReadKey();
        }
    }
}