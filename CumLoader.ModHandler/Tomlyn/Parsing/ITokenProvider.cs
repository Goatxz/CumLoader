// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license. 
// See license.txt file in the project root for full license information.
using System.Collections.Generic;
using CumLoader.Tomlyn.Syntax;
using CumLoader.Tomlyn.Text;

namespace CumLoader.Tomlyn.Parsing
{
    internal interface ITokenProvider<out TSourceView>  where TSourceView : ISourceView 
    {
        /// <summary>
        /// Gets a boolean indicating whether this lexer has errors.
        /// </summary>
        bool HasErrors { get; }

        TSourceView Source { get; }

        LexerState State { get; set; }

        bool MoveNext();

        SyntaxTokenValue Token { get; }

        /// <summary>
        /// Gets error messages.
        /// </summary>
        IEnumerable<DiagnosticMessage> Errors { get; }
    }
}