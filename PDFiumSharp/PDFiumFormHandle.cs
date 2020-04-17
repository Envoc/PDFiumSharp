using PDFiumSharp.Types;

namespace PDFiumSharp
{
    public sealed class PDFiumFormHandle : NativeWrapper<FPDF_FORMHANDLE>
    {
        public PDFiumFormHandle(FPDF_FORMHANDLE handle) : base(handle)
        {
        }
    }
}