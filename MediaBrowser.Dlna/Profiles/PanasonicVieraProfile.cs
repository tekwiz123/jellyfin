﻿using MediaBrowser.Controller.Dlna;

namespace MediaBrowser.Dlna.Profiles
{
   public class PanasonicVieraProfile : DefaultProfile
    {
       public PanasonicVieraProfile()
       {
           Name = "Panasonic Viera";
           ClientType = "DLNA";

           Identification = new DeviceIdentification
           {
               FriendlyName = @"VIERA",
               Manufacturer = "Panasonic",

               Headers = new[]
               {
                   new HttpHeaderInfo
                   {
                       Name = "User-Agent",
                       Value = "Panasonic MIL DLNA",
                       Match = HeaderMatchType.Substring
                   }
               }
           };

           TimelineOffsetSeconds = 10;

           TranscodingProfiles = new[]
           {
               new TranscodingProfile
               {
                   Container = "mp3",
                   AudioCodec = "mp3",
                   Type = DlnaProfileType.Audio
               },
               new TranscodingProfile
               {
                   Container = "ts",
                   AudioCodec = "ac3",
                   VideoCodec = "h264",
                   Type = DlnaProfileType.Video
               },
               new TranscodingProfile
               {
                   Container = "jpeg",
                   Type = DlnaProfileType.Photo
               }
           };

           DirectPlayProfiles = new[]
           {
               new DirectPlayProfile
               {
                   Container = "mpeg",
                   VideoCodec = "mpeg2video,mpeg4",
                   AudioCodec = "ac3,mp3",
                   Type = DlnaProfileType.Video
               },

               new DirectPlayProfile
               {
                   Container = "mkv",
                   VideoCodec = "h264",
                   AudioCodec = "aac,ac3,mp3,pcm",
                   Type = DlnaProfileType.Video
               },

               new DirectPlayProfile
               {
                   Container = "ts",
                   VideoCodec = "h264",
                   AudioCodec = "aac,mp3",
                   Type = DlnaProfileType.Video
               },

               new DirectPlayProfile
               {
                   Container = "mp4",
                   VideoCodec = "h264",
                   AudioCodec = "aac,ac3,mp3,pcm",
                   Type = DlnaProfileType.Video
               },

               new DirectPlayProfile
               {
                   Container = "mov",
                   VideoCodec = "h264",
                   AudioCodec = "aac,pcm",
                   Type = DlnaProfileType.Video
               },

               new DirectPlayProfile
               {
                   Container = "avi",
                   VideoCodec = "mpeg4",
                   AudioCodec = "pcm",
                   Type = DlnaProfileType.Video
               },

               new DirectPlayProfile
               {
                   Container = "flv",
                   VideoCodec = "h264",
                   AudioCodec = "aac",
                   Type = DlnaProfileType.Video
               },

               new DirectPlayProfile
               {
                   Container = "mp3",
                   AudioCodec = "mp3",
                   Type = DlnaProfileType.Audio
               },

               new DirectPlayProfile
               {
                   Container = "mp4",
                   AudioCodec = "aac",
                   Type = DlnaProfileType.Audio
               },

               new DirectPlayProfile
               {
                   Container = "jpeg",
                   Type = DlnaProfileType.Photo
               }
           };

           ContainerProfiles = new[]
            {
                new ContainerProfile
                {
                    Type = DlnaProfileType.Photo,

                    Conditions = new []
                    {
                        new ProfileCondition
                        {
                            Condition = ProfileConditionType.LessThanEqual,
                            Property = ProfileConditionValue.Width,
                            Value = "1920"
                        },
                        new ProfileCondition
                        {
                            Condition = ProfileConditionType.LessThanEqual,
                            Property = ProfileConditionValue.Height,
                            Value = "1080"
                        }
                    }
                }
            };

           CodecProfiles = new[]
           {
               new CodecProfile
               {
                   Type = CodecType.VideoCodec,

                   Conditions = new[]
                   {
                       new ProfileCondition
                       {
                           Condition = ProfileConditionType.LessThanEqual,
                           Property = ProfileConditionValue.Width,
                           Value = "1920"
                       },
                       new ProfileCondition
                       {
                           Condition = ProfileConditionType.LessThanEqual,
                           Property = ProfileConditionValue.Height,
                           Value = "1080"
                       },
                       new ProfileCondition
                       {
                           Condition = ProfileConditionType.LessThanEqual,
                           Property = ProfileConditionValue.VideoBitDepth,
                           Value = "8",
                           IsRequired = false
                       }
                   }
               }
           };
       }
    }
}