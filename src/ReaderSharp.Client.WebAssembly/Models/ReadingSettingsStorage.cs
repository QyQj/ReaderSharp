using System.Collections.Generic;

namespace ReaderSharp.Client.WebAssembly.Models
{
    public class ReadingSettingsStorage
    {
        public List<FontInfo> AvailableFonts { get; set; }

        public FontInfo Font { get; set; }

        public string BackgroundColor { get; set; }

        public double FontSize { get; set; }

        public int FontWeight { get; set; }

        public double LineHeight { get; set; }

        public double ParagraphTopMargin { get; set; }

        public double ParagraphBottomMargin { get; set; }

        public int TextIndent { get; set; }

        public int ContainerWidth { get; set; }

        public double TextComponentLeftPadding { get; set; }

        public double TextComponentRightPadding { get; set; }
    }
}
