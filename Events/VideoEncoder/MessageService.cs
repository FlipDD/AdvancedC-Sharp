using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class MessageService : IEncodingSubscriber
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message..." + args.Video.Title);
        }
    }
}
