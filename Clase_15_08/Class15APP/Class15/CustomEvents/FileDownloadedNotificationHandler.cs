using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class15.CustomEvents
{
    public class FileDownloadedNotificationHandler
    {
        public event EventHandler<string> FileDownloaded;

        protected virtual void OnFileDownloaded(string filename)
        {
            FileDownloaded?.Invoke(this, filename);
        }

        public void SendDownloadedFileNotification(string filename)
        { 
            OnFileDownloaded(filename);
        }
    }
}
