using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace mText.Utils
{
    class RegPref
    {
        public const string keyRoot = @"SOFTWARE\x7890\mText";

        string keyForm;
        List<Control> controls = new List<Control>();

        public RegPref(Form form) : this((form.Name + "#").Replace("Form#", ""), form.Controls) { }

        public RegPref(string subKey, Control.ControlCollection formControls)
        {
            List<Control> formControlList = new List<Control>();
            foreach (Control controlGroup in formControls)
            {
                if (controlGroup is GroupBox)
                {
                    // 仅专门的控件组需要遍历，组合型控件不需要
                    foreach (Control control in controlGroup.Controls)
                    {
                        formControlList.Add(control);
                    }
                }
                else
                {
                    formControlList.Add(controlGroup);
                }
            }

            // 仅关注可输入的控件
            keyForm = subKey;
            RegistryKey regRoot = Registry.CurrentUser.OpenSubKey(keyRoot, true);
            RegistryKey regForm = regRoot.CreateSubKey(keyForm, true);
            foreach (Control control in formControlList)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = control as CheckBox;
                    checkBox.Checked = Convert.ToBoolean(regForm.GetValue(control.Name, checkBox.Checked));
                    controls.Add(control);
                }
                else if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    if (textBox.ReadOnly == false)
                    {
                        textBox.Text = Convert.ToString(regForm.GetValue(control.Name, textBox.Text));
                        controls.Add(control);
                    }
                }
                else if (control is NumericUpDown)
                {
                    NumericUpDown upDown = control as NumericUpDown;
                    decimal value = Convert.ToDecimal(regForm.GetValue(control.Name, upDown.Value));
                    if (value < upDown.Minimum) value = upDown.Minimum;
                    if (value > upDown.Maximum) value = upDown.Maximum;
                    upDown.Value = value;
                    controls.Add(control);
                }
            }
            regForm.Close();
            regRoot.Close();
        }


        // 保存设置
        public void Save()
        {
            RegistryKey regRoot = Registry.CurrentUser.OpenSubKey(keyRoot, true);
            RegistryKey regForm = regRoot.CreateSubKey(keyForm, true);
            foreach (Control control in controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = control as CheckBox;
                    regForm.SetValue(control.Name, checkBox.Checked);
                }
                else if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    regForm.SetValue(control.Name, textBox.Text);
                }
                else if (control is NumericUpDown)
                {
                    NumericUpDown upDown = control as NumericUpDown;
                    regForm.SetValue(control.Name, upDown.Value);
                }
            }
            regForm.Close();
            regRoot.Close();
        }


        // 清空设置
        public void Reset()
        {
            RegistryKey regRoot = Registry.CurrentUser.OpenSubKey(keyRoot, true);
            regRoot.DeleteSubKeyTree(keyForm, false);
            regRoot.Close();
        }



        // 设置备份
        public static void SaveToFile()
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                FileName = "mText",
                Filter = "注册表备份文件（可双击导入）(*.reg)|*.reg"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string cmd = "regedit";
                string arg = "/e \"" + dialog.FileName + "\" \"HKEY_CURRENT_USER\\" + keyRoot + "\"";
                string allcmd = cmd + " " + arg;
                if (MessageBox.Show("即将调用注册表管理器进行导出，之后会弹出管理员权限请求框。\n由于导出数据较多，部分杀毒软件可能提醒一两次。\n导出的注册表文件可以直接双击以重新导入。\n若导出失败，请手动运行命令：" + allcmd + "\n按确定键将其复制到剪贴板，并尝试导出", "准备导出", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Clipboard.SetText(allcmd);
                    try
                    {
                        Process.Start(cmd, arg);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("错误：" + e.Message + "\n请尝试手工运行复制到剪贴板的命令", "导出失败");
                    }
                }
            }
        }
    }
}
