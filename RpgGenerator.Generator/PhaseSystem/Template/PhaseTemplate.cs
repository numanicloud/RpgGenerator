﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 16.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace RpgGenerator.Generator.PhaseSystem.Template
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class PhaseTemplate : PhaseTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("// <autogenerated />\r\n#nullable enable\r\nusing System;\r\nusing System.Threading.Tas" +
                    "ks;\r\nusing RpgGenerator.Basic;\r\n");
            
            #line 11 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
	foreach(var import in Root.GetImports()) { 
            
            #line default
            #line hidden
            this.Write("using ");
            
            #line 12 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(import));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 13 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
	} 
            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 15 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Root.DefinitionTypeName.FullNamespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 17 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
	foreach(var context in Root.ContextTypes) {  
            
            #line default
            #line hidden
            this.Write("\tinternal sealed class ");
            
            #line 18 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(context.TypeName));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n");
            
            #line 20 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
		var delegation = context.ContextDelegationProperties; 
            
            #line default
            #line hidden
            
            #line 21 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
		if(delegation != null) { 
            
            #line default
            #line hidden
            this.Write("\t\tprivate ");
            
            #line 22 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(delegation.ContextTypeName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 22 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(delegation.GetPropertyName()));
            
            #line default
            #line hidden
            this.Write(" { get; }\r\n");
            
            #line 23 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
			foreach(var property in delegation.Properties) { 
            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 24 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Type.Name));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 24 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.PropertyName));
            
            #line default
            #line hidden
            this.Write(" => ");
            
            #line 24 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(delegation.GetPropertyName()));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 24 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.PropertyName));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 25 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
			} 
            
            #line default
            #line hidden
            
            #line 26 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
		} 
            
            #line default
            #line hidden
            
            #line 27 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
		foreach(var property in context.ContextProperties) { 
            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 28 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Type.Name));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 28 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.PropertyName));
            
            #line default
            #line hidden
            this.Write(" { get; }\r\n");
            
            #line 29 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
		} 
            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic ");
            
            #line 31 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(context.TypeName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 31 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(context.GetCtorParamList()));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t{\r\n");
            
            #line 33 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
		if(delegation != null) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 34 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(delegation.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 34 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(delegation.ParameterName));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 35 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
		} 
            
            #line default
            #line hidden
            
            #line 36 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
		foreach(var property in context.ContextProperties) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 37 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 37 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.GetParameterName()));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 38 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
		} 
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\t}\r\n\r\n");
            
            #line 42 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
	} 
            
            #line default
            #line hidden
            this.Write("\tinternal sealed class ");
            
            #line 43 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Root.PhaseHandler.TypeName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 43 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Root.DefinitionTypeName.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n\t\tprivate readonly ");
            
            #line 45 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Root.PhaseLogic.TypeName));
            
            #line default
            #line hidden
            this.Write(" _logic;\r\n\r\n\t\tpublic ");
            
            #line 47 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Root.PhaseHandler.TypeName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 47 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Root.PhaseLogic.TypeName));
            
            #line default
            #line hidden
            this.Write(" logic)\r\n\t\t{\r\n\t\t\t_logic = logic;\r\n\t\t}\r\n\r\n");
            
            #line 52 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
	foreach(var method in Root.PhaseHandler.PhaseHandlerMethods) { 
            
            #line default
            #line hidden
            this.Write("\t\tpublic async Task<PhaseResult<");
            
            #line 53 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.ResultType.TypeName.Name));
            
            #line default
            #line hidden
            this.Write(">> ");
            
            #line 53 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 53 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.GetParamList()));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t{\r\n\t\t\tvar __phase = new ");
            
            #line 55 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.GetContextTypeName()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 55 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.GetContextArgList()));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\treturn await HandlePhaseFlowAsync(() => _logic.");
            
            #line 56 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.LogicMethodName));
            
            #line default
            #line hidden
            this.Write("(__phase, this));\r\n\t\t}\r\n\r\n");
            
            #line 59 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
	}  
            
            #line default
            #line hidden
            this.Write(@"		private async Task<PhaseResult<TResult>> HandlePhaseFlowAsync<TResult>(Func<Task<PhaseResult<TResult>>> logic)
		{
			while (true)
			{
				switch (await logic.Invoke())
				{
				case Cancelled<TResult> cancelled: return new Backed<TResult>();
				case Finished<TResult> finished: return finished;
				}
			}
		}

		private sealed class Backed<T> : PhaseResult<T>
		{
			public override T? UnWrapOrDefault() => default;
		}
	}

	internal interface ");
            
            #line 78 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Root.PhaseLogic.TypeName));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n");
            
            #line 80 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
	foreach(var method in Root.PhaseLogic.PhaseLogicMethods) { 
            
            #line default
            #line hidden
            this.Write("\t\tTask<PhaseResult<");
            
            #line 81 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.ResultTypeName));
            
            #line default
            #line hidden
            this.Write(">> ");
            
            #line 81 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 81 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.ContextTypeName));
            
            #line default
            #line hidden
            this.Write(" phase, ");
            
            #line 81 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Root.DefinitionTypeName.Name));
            
            #line default
            #line hidden
            this.Write(" handler);\r\n");
            
            #line 82 "D:\Naohiro\MyDocuments\Projects\Repos\Games\ZeroOpera\Modules\RpgGenerator\RpgGenerator.Generator\PhaseSystem\Template\PhaseTemplate.tt"
	} 
            
            #line default
            #line hidden
            this.Write("\t}\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class PhaseTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
