using ow.control;
using ow.manager;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ow
{
    public class genji
    {
        private bool E;
        private bool L;
        private bool needRes;
        private const int VK_SPACE = 32;
        private const int VK_W = 87;
        private const int VK_S = 83;

        [DllImport("User32.dll")]
        private static extern void keybd_event(int kbVk, int bScan, int dwFlags, int dwExtraInfo);

        [DllImport("User32.dll")]
        private static extern short GetKeyState(int k);

        [DllImport("User32.dll")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private void mouseMove(int x, int y)
        {
            mouse_event(0x0001, x, y, 0, 0);
        }

        private void kybdDown(int k)
        {
            keybd_event(k, 0, 0, 0);
        }

        private void kybdUp(int k)
        {
            keybd_event(k, 0, 2, 0);
        }

        private bool keyPressed(int k)
        {
            return GetKeyState(k) < 0;
        }

        private bool keyReleased(int k)
        {
            return GetKeyState(k) >= 0;
        }

        private float getRate()
        {
            return (1600 / globalManager.instance.ow.mouseSpeed + 10 / (float)globalManager.instance.ow.mouseSpeedInGame) / 2;
        }
        private void getTime(Action a)
        {
            var lt = DateTime.Now;
            a();
            var t = DateTime.Now;
            var ms = (t - lt).TotalMilliseconds;
            MessageBox.Show(ms.ToString());
        }
        private void _slip(Direction r)
        {
            var rate = getRate();
            float v = 88 * rate;
            float x = r == Direction.left ? -v : v;

            for (int i = 0; i < 10; i++)
            {
                mouseMove((int)x, 0);
                Sleep(1);
            }

        }

        private void slip()
        {
            if (globalManager.instance.ow.cenDirection == Direction.right)
            {
                _slip(Direction.right);
                _slip(Direction.left);
            }
            else
            {
                _slip(Direction.left);
                _slip(Direction.right);
            }
        }

        private void Sleep(int ms)
        {
            var LastTime = DateTime.Now;
        lbl_01:
            var NowTime = DateTime.Now;
            if ((NowTime - LastTime).TotalMilliseconds < ms) goto lbl_01;

        }

        public void Init()
        {
            var MainThread = new Thread((ThreadStart)delegate
            {
                while (true)
                {
                    while (globalManager.instance.waitInput)
                    {
                        Thread.Sleep(10);
                    }
                    if (keyPressed(globalManager.instance.ow.directionKey.tokey()) && !E)
                    {
                        E = true;
                        var dir = globalManager.instance.ow.cenDirection == Direction.left ? Direction.right : Direction.left;
                        option.ins.Invoke(option.ins._valueUpdata, new object[] { dataType.dir, dir });

                    }
                    if (keyReleased(globalManager.instance.ow.directionKey.tokey()) && E)
                    {
                        E = false;
                    }
                    if (keyPressed(globalManager.instance.ow.cenKey.tokey()) && !L)
                    {
                        if (!globalManager.instance.ow.isLoop)
                        {
                            L = true;
                        }
                        if (globalManager.instance.ow.isFront)
                        {
                            // kybdDown(VK_W);
                            kybdDown(VK_S);
                            Sleep(1);
                            kybdDown(VK_SPACE);
                            Sleep(20);
                            kybdUp(VK_S);
                            Sleep(1);
                            kybdUp(VK_SPACE);
                            needRes = true;
                        }
                        else
                        {
                            kybdDown(VK_SPACE);
                            kybdUp(VK_SPACE);
                            Sleep(32);
                            slip();
                        }
                    }
                    if (keyReleased(globalManager.instance.ow.cenKey.tokey()))
                    {
                        if (globalManager.instance.ow.isFront && needRes)
                        {
                            //  kybdUp(VK_W);
                            needRes = false;
                        }
                        L = false;
                    }
                    Sleep(globalManager.instance.ow.isFront ? 100 : 10);
                }
            });
            MainThread.IsBackground = true;
            MainThread.Start();
        }


    }
}