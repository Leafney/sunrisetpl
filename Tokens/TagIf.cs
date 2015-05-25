﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Igs.Hcms.Tmpl.Elements
{
    internal class IfStatement : Tag {
        private Tag falseBranch;
        private Expression _when;

        public IfStatement(int line, int col, Expression when) : base(line, col, "if")
        {
            _when = when;
        }

        public Tag FalseBranch
        {
            get {
                return this.falseBranch;
            } set {
                this.falseBranch = value;
            }
        }
        public Expression Test
        {
            get {
                return _when;
            }
        }
    }
}
