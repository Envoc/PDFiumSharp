using System;
using System.Runtime.InteropServices;

namespace PDFiumSharp.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FPDF_FORMFILLINFO
    {
        public int version;

        public IntPtr Release;

        public IntPtr FFI_Invalidate;

        public IntPtr FFI_OutputSelectedRect;

        public IntPtr FFI_SetCursor;

        public IntPtr FFI_SetTimer;

        public IntPtr FFI_KillTimer;

        public IntPtr FFI_GetLocalTime;

        public IntPtr FFI_OnChange;

        public IntPtr FFI_GetPage;

        public IntPtr FFI_GetCurrentPage;

        public IntPtr FFI_GetRotation;

        public IntPtr FFI_ExecuteNamedAction;

        public IntPtr FFI_SetTextFieldFocus;

        public IntPtr FFI_DoURIAction;

        public IntPtr FFI_DoGoToAction;

        public IntPtr m_pJsPlatform;

        public int xfa_disabled;

        public IntPtr FFI_DisplayCaret;

        public IntPtr FFI_GetCurrentPageIndex;

        public IntPtr FFI_SetCurrentPage;

        public IntPtr FFI_GotoURL;

        public IntPtr FFI_GetPageViewRect;

        public IntPtr FFI_PageEvent;

        public IntPtr FFI_PopupMenu;

        public IntPtr FFI_OpenFile;

        public IntPtr FFI_EmailTo;

        public IntPtr FFI_UploadTo;

        public IntPtr FFI_GetPlatform;

        public IntPtr FFI_GetLanguage;

        public IntPtr FFI_DownloadFromURL;

        public IntPtr FFI_PostRequestURL;

        public IntPtr FFI_PutRequestURL;

        public IntPtr FFI_OnFocusChange;
    }
}