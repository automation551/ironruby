﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Microsoft Public License. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the  Microsoft Public License, please send an email to 
 * dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Microsoft Public License.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/

#if !CLR2
using System.Linq.Expressions;
#else
using Microsoft.Scripting.Ast;
#endif

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using IronPython.Runtime.Operations;
using Microsoft.Scripting;
using Microsoft.Scripting.Actions;
using Microsoft.Scripting.Runtime;
using Microsoft.Scripting.Utils;
using AstUtils = Microsoft.Scripting.Ast.Utils;

namespace IronPython.Runtime.Binding {
    /// <summary>
    /// Fallback action for performing a new() on a foreign IDynamicMetaObjectProvider.  used
    /// when call falls back.
    /// </summary>
    class CreateFallback : CreateInstanceBinder, IPythonSite {
        private readonly CompatibilityInvokeBinder/*!*/ _fallback;

        public CreateFallback(CompatibilityInvokeBinder/*!*/ realFallback, CallInfo /*!*/ callInfo)
            : base(callInfo) {
            _fallback = realFallback;
        }

        public override DynamicMetaObject/*!*/ FallbackCreateInstance(DynamicMetaObject/*!*/ target, DynamicMetaObject/*!*/[]/*!*/ args, DynamicMetaObject errorSuggestion) {
            return _fallback.InvokeFallback(target, args, BindingHelpers.GetCallSignature(this), errorSuggestion);
        }

        #region IPythonSite Members

        public PythonContext Context {
            get { return _fallback.Context; }
        }

        #endregion
    }

}
