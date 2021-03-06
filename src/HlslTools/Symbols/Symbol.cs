﻿namespace HlslTools.Symbols
{
    public abstract class Symbol
    {
        public SymbolKind Kind { get; }
        public string Name { get; }
        public string Documentation { get; }
        public Symbol Parent { get; set; }

        protected Symbol(SymbolKind kind, string name, string documentation, Symbol parent)
        {
            Kind = kind;
            Name = name;
            Documentation = documentation;
            Parent = parent;
        }
    }
}