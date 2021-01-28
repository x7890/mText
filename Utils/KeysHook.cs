using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace mText.Utils
{
    class KeysHook
    {
        // 参考：
        // https://www.cnblogs.com/SanMaoSpace/archive/2013/02/20/2919337.html
        // https://www.cnblogs.com/wangyonglai/p/12373060.html

        public delegate bool KeyConsumer(Keys modifier, Keys key); // 检测是否是需要的按键，返回true表示已消耗
        KeyConsumer listener = null;

        delegate int HookProc(int code, IntPtr wParam, IntPtr lParam); // 内部用来实际挂钩的回调
        HookProc keyboardProc = null;
        IntPtr hHook = IntPtr.Zero;

        [DllImport("kernel32.dll")] static extern uint GetCurrentThreadId();
        [DllImport("user32.dll")] static extern IntPtr SetWindowsHookEx(int code, HookProc func, IntPtr hInstance, uint threadID);
        [DllImport("user32.dll")] static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("user32.dll")] static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);


        public KeysHook(KeyConsumer consumer)
        {
            const int WH_KEYBOARD = 2;
            listener = consumer;
            keyboardProc = new HookProc(hookProc);
            hHook = SetWindowsHookEx(WH_KEYBOARD, keyboardProc, IntPtr.Zero, GetCurrentThreadId());
        }

        ~KeysHook()
        {
            Disable();
        }

        // 禁用钩子
        public void Disable()
        {
            if (hHook != IntPtr.Zero)
            {
                UnhookWindowsHookEx(hHook);
                hHook = IntPtr.Zero;
            }
        }


        // 处理函数
        int hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            try
            {
                const int HC_ACTION = 0;
                if (code == HC_ACTION)
                {
                    bool KeyWasAlreadyPressed = ((int)lParam & 0x8000) > 0;
                    if (KeyWasAlreadyPressed == false)
                    {
                        // if (listener != null)
                            if (listener(Control.ModifierKeys, (Keys)wParam))
                                return 1; // 已处理，阻断传播
                    }
                }
            }
            catch
            {
            }
            return CallNextHookEx(hHook, code, wParam, lParam); // 继续传播
        }
    }
}
