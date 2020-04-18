using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube web service
                // Read the data
                // Create a list Video objects
                throw new Exception("oops some low level youtube error.");
            }
            catch (Exception ex)
            {
                // Log
                throw new YoutubeException("Could not fetch the videos from YouTube.", ex);
            }

            return new List<Video>();
        }
    }
}
