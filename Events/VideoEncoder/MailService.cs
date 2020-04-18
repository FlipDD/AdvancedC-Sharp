using System;

namespace Events
{
    class MailService : IEncodingSubscriber
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService: Sending email..." + args.Video.Title);
        }
    }
}
