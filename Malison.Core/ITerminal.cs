using System;
using System.Collections.Generic;
using System.Text;

using Bramble.Core;

namespace Malison.Core
{
    public enum DrawBoxOptions
    {
        None          = 0x0,
        DoubleLines   = 0x1,
        ContinueLines = 0x2,

        Default = ContinueLines
    }

    public interface ITerminal : IReadableTerminal
    {
        void Write(char ascii);
        void Write(Glyph glyph);
        void Write(Character character);
        void Write(string text);
        void Write(CharacterString text);
        void Write(int spriteId);

        void Scroll(Vec offset, Func<Vec, Character> scrollOnCallback);
        void Scroll(int x, int y, Func<Vec, Character> scrollOnCallback);

        void Clear();

        void Fill(Glyph glyph);

        void DrawBox();
        void DrawBox(DrawBoxOptions options);

        ITerminal this[TermColor foreColor] { get; }
        ITerminal this[TermColor foreColor, TermColor backColor] { get; }
        ITerminal this[ColorPair color] { get; }

        ITerminal this[Vec pos] { get; }
        ITerminal this[int x, int y] { get; }
        ITerminal this[Rect rect] { get; }
        ITerminal this[Vec pos, Vec size] { get; }
        ITerminal this[int x, int y, int width, int height] { get; }

        void Set(Vec pos, Character value);
        void Set(int x, int y, Character value);
    }
}
