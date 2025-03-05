using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace BookingEnginePMS.Helper
{
    public static class SessionCacheManager
    {
        private static Dictionary<string, Dictionary<string, object>> _sessionCache = new Dictionary<string, Dictionary<string, object>>();

        /// <summary>
        /// Lưu toàn bộ session hiện tại vào cache và trả về SessionID
        /// </summary>
        public static string CacheCurrentSession(this HttpSessionStateBase session)
        {
            string sessionId = Guid.NewGuid().ToString(); // Tạo một session ID ngẫu nhiên

            Dictionary<string, object> sessionData = new Dictionary<string, object>();
            foreach (string key in session.Keys)
            {
                sessionData[key] = session[key];
            }

            _sessionCache[sessionId] = sessionData;
            return sessionId;
        }

        /// <summary>
        /// Khôi phục session từ cache dựa vào SessionID
        /// </summary>
        public static bool RestoreSession(this HttpSessionStateBase session, string sessionId)
        {
            if (_sessionCache.ContainsKey(sessionId))
            {
                foreach (var kvp in _sessionCache[sessionId])
                {
                    session[kvp.Key] = kvp.Value;
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Xóa session khỏi cache dựa vào SessionID
        /// </summary>
        public static void RemoveSession(string sessionId)
        {
            if (_sessionCache.ContainsKey(sessionId))
            {
                _sessionCache.Remove(sessionId);
            }
        }
        public static void RemoveSession(this HttpSessionStateBase session, string sessionId) => RemoveSession(sessionId);
    }
}