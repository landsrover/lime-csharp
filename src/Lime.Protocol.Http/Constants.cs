﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lime.Protocol.Http
{
    internal static class Constants
    {
        public const string ROOT = "/";
        public const string MESSAGES_PATH = "messages";
        public const string COMMANDS_PATH = "commands";
        public const string NOTIFICATIONS_PATH = "notifications";
        public const string HTTP_METHOD_GET = "GET";
        public const string HTTP_METHOD_POST = "POST";
        public const string HTTP_METHOD_DELETE = "DELETE";
        public const string CONTENT_TYPE_HEADER = "Content-Type";
        public const string TEXT_PLAIN_HEADER_VALUE = "text/plain";
        public const string SESSION_ID_HEADER = "X-Session-Id";
        public const string ENVELOPE_ID_HEADER = "X-Id";
        public const string ENVELOPE_ID_QUERY = "id";
        public const string ENVELOPE_FROM_HEADER = "X-From";
        public const string ENVELOPE_FROM_QUERY = "from";
        public const string ENVELOPE_TO_HEADER = "X-To";
        public const string ENVELOPE_TO_QUERY = "to";
        public const string ENVELOPE_PP_HEADER = "X-Pp";
        public const string ENVELOPE_PP_QUERY = "pp";
        public const string ASYNC_QUERY = "async"; 
    }
}
