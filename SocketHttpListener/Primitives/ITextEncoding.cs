﻿using System.Text;
using MediaBrowser.Model.Text;

namespace SocketHttpListener.Primitives
{
    public static class TextEncodingExtensions
    {
        public static Encoding GetDefaultEncoding(this ITextEncoding encoding)
        {
            return Encoding.UTF8;
        }

        public static Encoding GetDefaultEncoding()
        {
            return Encoding.UTF8;
        }
    }
}
