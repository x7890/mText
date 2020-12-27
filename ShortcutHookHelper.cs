using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mText
{
    class ShortcutHookHelper
    {
        // 参考：https://www.cnblogs.com/SanMaoSpace/archive/2013/02/20/2919337.html
        // https://docs.microsoft.com/en-us/previous-versions/windows/desktop/legacy/ms644984(v=vs.85)
        // https://www.cnblogs.com/wangyonglai/p/12373060.html

        private const int WH_KEYBOARD = 2;
        private const int HC_ACTION = 0;

        delegate int KeyboardProc(int code, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")] static extern uint GetCurrentThreadId();
        [DllImport("user32.dll")] static extern IntPtr SetWindowsHookEx(int code, KeyboardProc func, IntPtr hInstance, uint threadID);
        [DllImport("user32.dll")] static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("user32.dll")] static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")] public static extern int GetAsyncKeyState(int nVirtKey);


        public delegate bool KeyCodeChecker(int code); // 返回1表示退出

        IntPtr khook = IntPtr.Zero;
        KeyboardProc keyboardProc;
        KeyCodeChecker listener;


        public static int VK_SHIFT = 0x10;
        public static int VK_CONTROL = 0x11;
        public static int VK_ALT = 0x12;
        public static int VK_CAPITAL = 0x14;


        public ShortcutHookHelper()
        {
            keyboardProc = new KeyboardProc(myKeyboardProc);
        }

        ~ShortcutHookHelper()
        {
            disable();
        }


        // 启用Hook
        public void enable(KeyCodeChecker listener)
        {
            this.listener = listener;
            if (khook == IntPtr.Zero)
            {
                khook = SetWindowsHookEx(WH_KEYBOARD, keyboardProc, IntPtr.Zero, GetCurrentThreadId());
            }
        }

        // 取消Hook
        public void disable()
        {
            if (khook != IntPtr.Zero)
            {
                UnhookWindowsHookEx(khook);
                khook = IntPtr.Zero;
            }
        }

        // 处理函数
        int myKeyboardProc(int code, IntPtr wParam, IntPtr lParam)
        {
            try
            {
                if (code == HC_ACTION)
                {
                    bool KeyWasAlreadyPressed = ((int)lParam & 0x8000) > 0;
                    if (KeyWasAlreadyPressed == false && listener((int)wParam))
                    {
                        // CallNextHookEx(khook, code, wParam, lParam);
                        return 1;
                    }
                }
            }
            catch
            {
            }
            return CallNextHookEx(khook, code, wParam, lParam);
        }
    }
}
