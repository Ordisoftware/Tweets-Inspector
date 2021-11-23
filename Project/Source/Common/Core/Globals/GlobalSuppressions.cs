﻿// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Info Code Smell", "S1135:Track uses of \"TODO\" tags", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S1066:Collapsible \"if\" statements should be merged", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S108:Nested blocks of code should not be left empty", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S112:General exceptions should never be thrown", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S1121:Assignments should not be made from within sub-expressions", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S1144:Unused private types or members should be removed", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S125:Sections of code should not be commented out", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S1854:Unused assignments should be removed", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S3358:Ternary operators should not be nested", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S3928:Parameter names used into ArgumentException constructors should match an existing one ", Justification = "Irrelevant?", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S4220:Events should have proper arguments", Justification = "Irrelevant?", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S907:\"goto\" statement should not be used", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Minor Code Smell", "S2486:Generic exceptions should not be ignored", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Minor Code Smell", "S3963:\"static\" fields should be initialized inline", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Critical Code Smell", "S1699:Constructors should only call non-overridable methods", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Critical Code Smell", "S2365:Properties should not make collection or array copies", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Critical Code Smell", "S2696:Instance members should not write to \"static\" fields", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Critical Code Smell", "S3973:A conditionally executed single line should be denoted by indentation", Justification = "Opinion based", Scope = "module")]

[assembly: SuppressMessage("Simplification", "RCS1061:Merge 'if' with nested 'if'.", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Style", "IDE0011:Ajouter des accolades", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Style", "IDE0008:Utiliser un type explicite", Justification = "Opinion based", Scope = "module")]

[assembly: SuppressMessage("Maintainability", "RCS1139:Add summary element to documentation comment.", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Maintainability", "RCS1141:Add 'param' element to documentation comment.", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Readability", "RCS1018:Add accessibility modifiers (or vice versa).", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Readability", "RCS1123:Add parentheses when necessary.", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Style", "RCS1001:Add braces (when expression spans over multiple lines).", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Style", "RCS1003:Add braces to if-else (when expression spans over multiple lines).", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Design", "RCS1225:Make class sealed.", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Redundancy", "RCS1036:Remove redundant empty line.", Justification = "Opinion based", Scope = "module")]
[assembly: SuppressMessage("Performance", "RCS1096:Convert 'HasFlag' call to bitwise operation (or vice versa).", Justification = "Opinion based", Scope = "module")]


//[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S3925:\"ISerializable\" should be implemented correctly", Justification = "Hide", Scope = "type", Target = "~T:Ordisoftware.Hebrew.Calendar.Data.DataSet")]