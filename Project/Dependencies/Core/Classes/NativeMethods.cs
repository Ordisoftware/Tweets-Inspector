/// <license>
/// This file is part of Ordisoftware Core Library.
/// Copyright 2004-2021 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at 
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file, 
/// then You may include the notice in a location(such as a LICENSE file in a 
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2016-04 </created>
/// <edited> 2021-02 </edited>
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Ordisoftware.Core
{

  static partial class NativeMethods
  {

    // WorkStation

    [DllImport("user32.dll", SetLastError = true)]
    static public extern bool LockWorkStation();

    // Windows

    public const int MAX_PATH = 260;

    public const uint SW_RESTORE = 0x09;

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
      public int left;
      public int top;
      public int right;
      public int bottom;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HARDWAREINPUT
    {
      public uint Msg;
      public ushort ParamL;
      public ushort ParamH;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct KEYBDINPUT
    {
      public ushort Vk;
      public ushort Scan;
      public uint Flags;
      public uint Time;
      public IntPtr ExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MOUSEINPUT
    {
      public int X;
      public int Y;
      public uint MouseData;
      public uint Flags;
      public uint Time;
      public IntPtr ExtraInfo;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MOUSEKEYBDHARDWAREINPUT
    {
      [FieldOffset(0)]
      public HARDWAREINPUT Hardware;
      [FieldOffset(0)]
      public KEYBDINPUT Keyboard;
      [FieldOffset(0)]
      public MOUSEINPUT Mouse;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct INPUT
    {
      public uint Type;
      public MOUSEKEYBDHARDWAREINPUT Data;
    }

    [DllImport("user32.dll")]
    static public extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll", SetLastError = true)]
    static public extern uint SendInput(uint numberOfInputs, INPUT[] inputs, int sizeOfInputStructure);

    [DllImport("user32.dll")]
    static public extern int ShowWindow(IntPtr hWnd, uint Msg);

    // WinMedia

    public const int WM_APPCOMMAND = 0x319;
    public const int APPCOMMAND_VOLUME_MUTE = 0x80000;

    [DllImport("winmm.dll", CharSet = CharSet.Unicode)]
    static public extern uint mciSendString(string command, StringBuilder returnValue, int returnLength, IntPtr winHandle);

    // Screensaver

    public const int WM_SYSCOMMAND = 0x0112;
    public const int SC_SCREENSAVE = 0xF140;
    public const int SPI_GETSCREENSAVERRUNNING = 0x0072;

    [DllImport("user32.dll")]
    static public extern bool SystemParametersInfo(int action, int param, ref int retval, int updini);

    [DllImport("user32.dll")]
    static public extern bool GetWindowRect(HandleRef hWnd, [In, Out] ref RECT rect);

    [DllImport("user32.dll")]
    static public extern IntPtr GetForegroundWindow();

    // Clipboard

    [DllImport("User32.dll", CharSet = CharSet.Auto)]
    static public extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
    static public IntPtr ClipboardViewerNext;

    // Taskbar

    public const int ABM_GETTASKBARPOS = 5;

    public struct APPBARDATA
    {
      public int cbSize;
      public IntPtr hWnd;
      public int uCallbackMessage;
      public int uEdge;
      public RECT rc;
      public IntPtr lParam;
    }

    [DllImport("shell32.dll")]
    public static extern IntPtr SHAppBarMessage(int msg, ref APPBARDATA data);

    // Shell icons
    // https://stackoverflow.com/questions/1309738/how-do-i-get-an-image-for-the-various-messageboximages-or-messageboxicons#25429905

    public enum SHSTOCKICONID : uint
    {
      SIID_DOCNOASSOC = 0,
      SIID_DOCASSOC = 1,
      SIID_APPLICATION = 2,
      SIID_FOLDER = 3,
      SIID_FOLDEROPEN = 4,
      SIID_DRIVE525 = 5,
      SIID_DRIVE35 = 6,
      SIID_DRIVEREMOVE = 7,
      SIID_DRIVEFIXED = 8,
      SIID_DRIVENET = 9,
      SIID_DRIVENETDISABLED = 10,
      SIID_DRIVECD = 11,
      SIID_DRIVERAM = 12,
      SIID_WORLD = 13,
      SIID_SERVER = 15,
      SIID_PRINTER = 16,
      SIID_MYNETWORK = 17,
      SIID_FIND = 22,
      SIID_HELP = 23,
      SIID_SHARE = 28,
      SIID_LINK = 29,
      SIID_SLOWFILE = 30,
      SIID_RECYCLER = 31,
      SIID_RECYCLERFULL = 32,
      SIID_MEDIACDAUDIO = 40,
      SIID_LOCK = 47,
      SIID_AUTOLIST = 49,
      SIID_PRINTERNET = 50,
      SIID_SERVERSHARE = 51,
      SIID_PRINTERFAX = 52,
      SIID_PRINTERFAXNET = 53,
      SIID_PRINTERFILE = 54,
      SIID_STACK = 55,
      SIID_MEDIASVCD = 56,
      SIID_STUFFEDFOLDER = 57,
      SIID_DRIVEUNKNOWN = 58,
      SIID_DRIVEDVD = 59,
      SIID_MEDIADVD = 60,
      SIID_MEDIADVDRAM = 61,
      SIID_MEDIADVDRW = 62,
      SIID_MEDIADVDR = 63,
      SIID_MEDIADVDROM = 64,
      SIID_MEDIACDAUDIOPLUS = 65,
      SIID_MEDIACDRW = 66,
      SIID_MEDIACDR = 67,
      SIID_MEDIACDBURN = 68,
      SIID_MEDIABLANKCD = 69,
      SIID_MEDIACDROM = 70,
      SIID_AUDIOFILES = 71,
      SIID_IMAGEFILES = 72,
      SIID_VIDEOFILES = 73,
      SIID_MIXEDFILES = 74,
      SIID_FOLDERBACK = 75,
      SIID_FOLDERFRONT = 76,
      SIID_SHIELD = 77,
      SIID_WARNING = 78,
      SIID_INFO = 79,
      SIID_ERROR = 80,
      SIID_KEY = 81,
      SIID_SOFTWARE = 82,
      SIID_RENAME = 83,
      SIID_DELETE = 84,
      SIID_MEDIAAUDIODVD = 85,
      SIID_MEDIAMOVIEDVD = 86,
      SIID_MEDIAENHANCEDCD = 87,
      SIID_MEDIAENHANCEDDVD = 88,
      SIID_MEDIAHDDVD = 89,
      SIID_MEDIABLURAY = 90,
      SIID_MEDIAVCD = 91,
      SIID_MEDIADVDPLUSR = 92,
      SIID_MEDIADVDPLUSRW = 93,
      SIID_DESKTOPPC = 94,
      SIID_MOBILEPC = 95,
      SIID_USERS = 96,
      SIID_MEDIASMARTMEDIA = 97,
      SIID_MEDIACOMPACTFLASH = 98,
      SIID_DEVICECELLPHONE = 99,
      SIID_DEVICECAMERA = 100,
      SIID_DEVICEVIDEOCAMERA = 101,
      SIID_DEVICEAUDIOPLAYER = 102,
      SIID_NETWORKCONNECT = 103,
      SIID_INTERNET = 104,
      SIID_ZIPFILE = 105,
      SIID_SETTINGS = 106,
      SIID_DRIVEHDDVD = 132,
      SIID_DRIVEBD = 133,
      SIID_MEDIAHDDVDROM = 134,
      SIID_MEDIAHDDVDR = 135,
      SIID_MEDIAHDDVDRAM = 136,
      SIID_MEDIABDROM = 137,
      SIID_MEDIABDR = 138,
      SIID_MEDIABDRE = 139,
      SIID_CLUSTEREDDRIVE = 140,
      SIID_MAX_ICONS = 175
    }

    [Flags]
    public enum SHGSI : uint
    {
      SHGSI_ICONLOCATION = 0,
      SHGSI_ICON = 0x000000100,
      SHGSI_SYSICONINDEX = 0x000004000,
      SHGSI_LINKOVERLAY = 0x000008000,
      SHGSI_SELECTED = 0x000010000,
      SHGSI_LARGEICON = 0x000000000,
      SHGSI_SMALLICON = 0x000000001,
      SHGSI_SHELLICONSIZE = 0x000000004
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct SHSTOCKICONINFO
    {
      public uint cbSize;
      public IntPtr hIcon;
      public int iSysIconIndex;
      public int iIcon;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
      public string szPath;
    }

    [DllImport("Shell32.dll", SetLastError = false)]
    static public extern Int32 SHGetStockIconInfo(SHSTOCKICONID siid, SHGSI uFlags, ref SHSTOCKICONINFO psii);

  }

}