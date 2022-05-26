using System;

namespace ReaderSharp.Client.WebAssembly.Models
{
    public class ReadingSettings
    {
        public string FontFamily { get; set; } = "SimSun";

        private string _backgroundColor = "#FFFFFF";

        public string BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                _backgroundColor = value;
                StateHasChanged();
            }
        }

        public string _fontSizePX = "16px";
        private double _fontSize = 16;
        public double FontSize
        {
            get => _fontSize;
            set
            {
                _fontSize = value;
                _fontSizePX = value + "px";
                StateHasChanged();
            }
        }

        private int _fontWeight = 100;
        public int FontWeight
        {
            get => _fontWeight;
            set
            {
                _fontWeight = value;
                StateHasChanged();
            }
        }

        private double _lineHeight = 2;
        public double LineHeight
        {
            get => _lineHeight;
            set
            {
                _lineHeight = value;
                StateHasChanged();
            }
        }

        public string _paragraphTopMarginPX = "8px";
        private double _paragraphTopMargin = 8;
        public double ParagraphTopMargin
        {
            get => _paragraphTopMargin;
            set
            {
                _paragraphTopMargin = value;
                _paragraphTopMarginPX = value + "px";
                StateHasChanged();
            }
        }

        public string _paragraphBottomMarginPX = "8px";
        private double _paragraphBottomMargin = 8;
        public double ParagraphBottomMargin
        {
            get => _paragraphBottomMargin;
            set
            {
                _paragraphBottomMargin = value;
                _paragraphBottomMarginPX = value + "px";
                StateHasChanged();
            }
        }

        public string _textIndentEM = "2em";
        private int _textIndent = 2;
        public int TextIndent
        {
            get => _textIndent;
            set
            {
                _textIndent = value;
                _textIndentEM = value + "em";
                StateHasChanged();
            }
        }

        public string _containerWidthPX = "1000px";
        private int _containerWidth = 1000;
        public int ContainerWidth
        {
            get => _containerWidth;
            set
            {
                _containerWidth = value;
                _containerWidthPX = value + "px";
                StateHasChanged();
            }
        }

        public string _textComponentLeftPaddingPX = "8px";
        private double _textComponentLeftPadding = 8;
        public double TextComponentLeftPadding
        {
            get => _textComponentLeftPadding;
            set
            {
                _textComponentLeftPadding = value;
                _textComponentLeftPaddingPX = value + "px";
                StateHasChanged();
            }
        }

        public string _textComponentRightPaddingPX = "8px";
        private double _textComponentRightPadding = 8;
        public double TextComponentRightPadding
        {
            get => _textComponentRightPadding;
            set
            {
                _textComponentRightPadding = value;
                _textComponentRightPaddingPX = value + "px";
                StateHasChanged();
            }
        }

        public delegate void ReadingSettingsChangedEventHandler(object source, EventArgs args);

        public event ReadingSettingsChangedEventHandler ReadingSettingsChanged;

        protected void StateHasChanged()
        {
            if (ReadingSettingsChanged != null)
                ReadingSettingsChanged(this, null);
        }
    }
}
