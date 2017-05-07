using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public class RegionsRemoval : CSharpSyntaxRewriter
{
    public RegionsRemoval()
        : base(true)
    {
    }

    public override SyntaxNode VisitRegionDirectiveTrivia(RegionDirectiveTriviaSyntax node)
    {
        return SyntaxFactory.SkippedTokensTrivia();
    }

    public override SyntaxNode VisitEndRegionDirectiveTrivia(EndRegionDirectiveTriviaSyntax node)
    {
        return SyntaxFactory.SkippedTokensTrivia();
    }
}
