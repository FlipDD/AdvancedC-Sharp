using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    interface IEncodingSubscriber
    {
        void OnVideoEncoded(object source, VideoEventArgs args);
    }
}
