﻿using ClineControlApp.Utilities.Contracts;
using System;
using System.Threading.Tasks;

namespace ClineControlApp.Utilities.Extentions
{
    public static class TaskEx
    {
        public static async void FireAndForgetSafeAsync(this Task task, IErrorHandler handler = null)
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                handler?.HandleError(ex);
            }
        }
    }
}
