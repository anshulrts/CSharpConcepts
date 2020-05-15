using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class DelegateClass
    {
        public void start()
        {
            Video vid = new Video("Abc");
            VideoEncoder videoEncoder = new VideoEncoder();

            VideoEncoder.EncodeSuccessHandle encodeSuccess = sendEmail;

            videoEncoder.Encode(vid, encodeSuccess);
        }

        private void sendEmail(Video vid)
        {
            Console.WriteLine("Called Successfully with Video : " + vid.Name);
        }
    }

    public class VideoEncoder
    {
        public delegate void EncodeSuccessHandle(Video vid);
        
        public void Encode(Video v, EncodeSuccessHandle encodeSuccess)
        {
            encodeSuccess(v);
        }
    }

    public class Video
    {
        public Video(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
