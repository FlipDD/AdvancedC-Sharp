using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events
{
    class VideoEncoder
    {
        // 1. Define delegate
        // 2. Define an event based on the delegate
        // 3. Raise the event

        // EventHandler
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;

        // EventHandler<TEventArgs> - Generic way -- Looks much better, writing less code too
        public event EventHandler<VideoEventArgs> VideoEncoded;
        // No params
        //public event EventHandler VideoEncoding;

        internal void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(2000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            // If there are subscribers
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}
