using System;
using System.Runtime.InteropServices;

namespace PDFiumSharp.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FPDF_FORMFILLINFO
    {
        public int version;

        private IntPtr Release;

        private IntPtr FFI_Invalidate;

        private IntPtr FFI_OutputSelectedRect;

        private IntPtr FFI_SetCursor;

        private IntPtr FFI_SetTimer;

        private IntPtr FFI_KillTimer;

        private IntPtr FFI_GetLocalTime;

        private IntPtr FFI_OnChange;

        private IntPtr FFI_GetPage;

        private IntPtr FFI_GetCurrentPage;

        private IntPtr FFI_GetRotation;

        private IntPtr FFI_ExecuteNamedAction;

        private IntPtr FFI_SetTextFieldFocus;

        private IntPtr FFI_DoURIAction;

        private IntPtr FFI_DoGoToAction;

        private IntPtr m_pJsPlatform;

        // XFA support i.e. version 2

        private IntPtr FFI_DisplayCaret;

        private IntPtr FFI_GetCurrentPageIndex;

        private IntPtr FFI_SetCurrentPage;

        private IntPtr FFI_GotoURL;

        private IntPtr FFI_GetPageViewRect;

        private IntPtr FFI_PageEvent;

        private IntPtr FFI_PopupMenu;

        private IntPtr FFI_OpenFile;

        private IntPtr FFI_EmailTo;

        private IntPtr FFI_UploadTo;

        private IntPtr FFI_GetPlatform;

        private IntPtr FFI_GetLanguage;

        private IntPtr FFI_DownloadFromURL;

        private IntPtr FFI_PostRequestURL;

        private IntPtr FFI_PutRequestURL;
    }
}