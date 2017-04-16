﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SixLabors.Fonts.Tests.Issues
{
    public class Issues_23
    {
        [Fact]
        public void BleadingFonts()
        {
            // wendy one returns wrong points for 'o'
            var font = new FontCollection().Install(TestFonts.WendyOneFile);

            var r = new GlyphRenderer();

            new TextRenderer(r).RenderText("o", new FontSpan(new Font(font, 30), 72));

            Assert.DoesNotContain(System.Numerics.Vector2.Zero, r.ControlPoints);
        }
    }
}