﻿using System;

namespace NPetrovich.Utils
{
    internal static class Guard
    {
        internal static void IfArgumentNullOrWhitespace(string value, string parameterName = null, string message = null)
        {
            if (string.IsNullOrWhiteSpace(value))
                ThrowArgumentNullException(parameterName, message);
        }

        internal static void IfArgumentNull(object value, string parameterName = null, string message = null)
        {
            if (value == null)
                ThrowArgumentNullException(parameterName, message);
        }

        #region Throw utils
        private static void ThrowArgumentNullException(string parameterName, string message)
        {
            parameterName = string.IsNullOrWhiteSpace(parameterName) ? "value" : parameterName;

            throw (string.IsNullOrWhiteSpace(message)
                       ? new ArgumentNullException(parameterName)
                       : new ArgumentNullException(parameterName, message));
        }
        #endregion
    }
}
