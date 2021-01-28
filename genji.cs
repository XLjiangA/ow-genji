using control;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

public class genji
{
    private bool E;
    private bool L;
    private bool needRes;
    private const int VK_SPACE = 32;
    private const int VK_W = 87;
    private const int VK_S = 83;

    private float screenX;

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
        return (1600 / globalManager.ins.game.mouseSpeed + 10 / (float)globalManager.ins.game.mouseSpeedInGame) / 2;
    }
    private void _slip(Direction r)
    {
        var rate = getRate();
        float v = 88 * rate;
        float x = (r == Direction.left) ? -v : v;
        for (int i = 0; i < 10; i++)
        {
            mouseMove((int)x, 0);
            Thread.Sleep(1);
        }
    }

    private void slip()
    {
        if (globalManager.ins.game.cenDirection == Direction.right)
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

    public void Init()
    {
        screenX = Screen.PrimaryScreen.WorkingArea.Width / 20;
        Thread thread = new Thread((ThreadStart)delegate
        {
            while (true)
            {
                while (globalManager.ins.waitInput)
                {
                    Thread.Sleep(10);
                }
                if (keyPressed(globalManager.ins.game.directionKey.tokey()) && !E)
                {
                    E = true;
                    var dir = globalManager.ins.game.cenDirection == Direction.left ? Direction.right : Direction.left;
                    option.ins.Invoke(option.ins._valueUpdata, new object[] { dataType.dir, dir });

                }
                if (keyReleased(globalManager.ins.game.directionKey.tokey()) && E)
                {
                    E = false;
                }
                if (keyPressed(globalManager.ins.game.cenKey.tokey()) && !L)
                {
                    if (!globalManager.ins.game.isLoop)
                    {
                        L = true;
                    }
                    if (globalManager.ins.game.isFront)
                    {
                        // kybdDown(VK_W);
                        kybdDown(VK_S);
                        kybdDown(VK_SPACE);
                        kybdUp(VK_SPACE);
                        Thread.Sleep(1);
                        kybdUp(VK_S);
                        kybdDown(VK_S);
                        kybdUp(VK_S);
                        needRes = true;

                    }
                    else
                    {
                        kybdDown(VK_SPACE);
                        kybdUp(VK_SPACE);
                        Thread.Sleep(32);
                        slip();
                    }
                }
                if (keyReleased(globalManager.ins.game.cenKey.tokey()))
                {
                    if (globalManager.ins.game.isFront && needRes)
                    {
                        //  kybdUp(VK_W);
                        needRes = false;
                    }
                    L = false;
                }
                Thread.Sleep(10);
            }
        });
        thread.IsBackground = true;
        thread.Start();
    }


}

