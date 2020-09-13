/// <summary>
/// I present a builder pattern that I use in my current project 
/// The create logic is trimmed down version since it has other services that it depends on.
/// 
/// </summary>

namespace VideoBuilder
{
    public class VideoRequest
    {
        public int Interval { get; set; }
        public int Event { get; set; }
        public int Frame { get; set; }
        public int Duration { get; set; }
        public int VideoQuality { get; set; }
        
        public bool ProcessVideo()
        {
            //gets all the video requested 
            if(Duration == 0 )
                return false;

            // the data is passed to a service whcih process the request asyncronously.

            return true;
        }
    }

    /// <summary>
    /// VideoRequestBuilder abstract class to build a video request
    /// </summary>
    public abstract class VideoRequestBuilder
    {
        protected VideoRequest VideoRequest;
        
        public void CreateRequest()
        {
            VideoRequest = new VideoRequest();
        }
        public VideoRequest GetRequest()
        {
            return VideoRequest;
        }
        
        public abstract void SetInterval();
        public abstract void SetEvent();
        public abstract void SetFrames();
        public abstract void SetExpiration();
        public abstract void SetVideoQuality();
    }

    public  class ArchiveVideoBuilderWithAnalysis : VideoRequestBuilder
    {
        public override void SetInterval()
        {
            //internal configure services
        }
 
        public  override void SetEvent()
        {
            //internal configure services
        }
 
        public override void SetFrames()
        {
            //internal configure services
        }
 
        public override void SetExpiration()
        {
            //internal configure services
        }
 
        public override void SetVideoQuality()
        {
            //internal configure services
        }
    }

    public  class LiveVideoBuilder : VideoRequestBuilder
    {
        public override void SetInterval()
        {
            //internal configure services
        }
 
        public  override void SetEvent()
        {
            //internal configure services
        }
 
        public override void SetFrames()
        {
            //internal configure services
        }
 
        public override void SetExpiration()
        {
            //internal configure services
        }
 
        public override void SetVideoQuality()
        {
            //internal configure services
        }
    }

     /// <summary>
     /// VideoManager is a trimmed version since i do not have few services to request video
     /// this is a sample of Builder pattern developed.
     /// </summary>
    public class VideoManager
    {
        public VideoRequest MakeLiveVideoRequest(VideoRequestBuilder videoRequestBuilder)
        {
            videoRequestBuilder.CreateRequest();
            videoRequestBuilder.SetEvent();
            videoRequestBuilder.SetExpiration();
            videoRequestBuilder.SetFrames();
            videoRequestBuilder.SetInterval();
            videoRequestBuilder.SetVideoQuality();
            
            return videoRequestBuilder.GetRequest();
        }

        public VideoRequest MakeVideoBuilderWithAnalysis(VideoRequestBuilder videoRequestBuilder)
        {
            videoRequestBuilder.CreateRequest();
            videoRequestBuilder.SetEvent();
            videoRequestBuilder.SetExpiration();
            videoRequestBuilder.SetFrames();
            videoRequestBuilder.SetInterval();
            videoRequestBuilder.SetVideoQuality();
            
            return videoRequestBuilder.GetRequest();
        }
    }
}