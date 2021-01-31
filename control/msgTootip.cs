using System.Windows.Forms;

namespace ow.control
{
    public static class msgTootip
    {
        private static NotifyIcon _notifyIcon { get; set; }

        public static void tipHide()
        {
            _notifyIcon.Visible = false;
        }

        public static void show(string msg, string tile = "")
        {
            int tipShowMilliseconds = 500;
            string tipTitle = tile;
            string tipContent = msg;
            ToolTipIcon tipType = ToolTipIcon.Info;
            _notifyIcon.ShowBalloonTip(tipShowMilliseconds, tipTitle, tipContent, tipType);
        }
        public static void show(string msg, string tile, int ms)
        {
            int tipShowMilliseconds = ms;
            string tipTitle = tile;
            string tipContent = msg;
            ToolTipIcon tipType = ToolTipIcon.Info;
            _notifyIcon.ShowBalloonTip(tipShowMilliseconds, tipTitle, tipContent, tipType);
        }
        public static void show(string msg, string tile, ToolTipIcon _type)
        {
            int tipShowMilliseconds = 500;
            string tipTitle = tile;
            string tipContent = msg;
            ToolTipIcon tipType = _type;
            _notifyIcon.ShowBalloonTip(tipShowMilliseconds, tipTitle, tipContent, tipType);
        }
        public static void show(string msg, string tile, ToolTipIcon _type, int ms)
        {
            int tipShowMilliseconds = ms;
            string tipTitle = tile;
            string tipContent = msg;
            ToolTipIcon tipType = _type;
            _notifyIcon.ShowBalloonTip(tipShowMilliseconds, tipTitle, tipContent, tipType);
        }
    }

}